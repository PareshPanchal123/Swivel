using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using swivel.Auth;
using swivel.Data;

using swivel.Helpers;
using swivel.models;
using swivel.Services;

namespace swivel.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        //applicationuser.cs file references with database //Data folder create in two file create in ApplicationDbContext.cs and ApplicationUser.cs 
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IJwtFactory _jwtFactory;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JwtIssuerOptions _jwtOptions;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        sysMasterContext db = new sysMasterContext();

        //constucture laod in all function check again 
        //jwtfactory file create in  security token generate use //Auth folder create in two file create in interface and class file
        //JwtIssuerOptions.cs in class file create in field  
        //Emailsender file in email send // Services folder is create in emailsender.cs two file create in interface and class file 
        public AuthController(UserManager<ApplicationUser> userManager,
            IJwtFactory jwtFactory, IOptions<JwtIssuerOptions> jwtOptions, IEmailSender emailSender, ILogger<AuthController> logger)
        {
            _userManager = userManager;
            _jwtFactory = jwtFactory;
            _jwtOptions = jwtOptions.Value;
            _emailSender = emailSender;
            _userManager = userManager;
            _emailSender = emailSender;
            _logger = logger;

        }

        [TempData]
        public string ErrorMessage { get; set; }


        [HttpPost("resetpassword")]//vue js to references with action methode
        public async Task<IActionResult> ResetPassword([FromBody]ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }
            return new OkObjectResult(model);

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        //POST api/auth/login
        [HttpPost("login")]
        public async Task<ActionResult> Post([FromBody] LoginModel credentials)
        {

            AspNetUsers model = new AspNetUsers();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            bool UserIsEmail = false; //this function email check 
            bool IsPassword = false;// this password check 

            UserIsEmail = IsValid(credentials.userName);

            string[] values = credentials.userName.Split('.').Select(sValue => sValue.Trim()).ToArray();
            var CompanyCode = values[0];
            //Emailid  is true this  function is working 
            if (UserIsEmail)
            {
                List<AspNetUsers> Aspnet = db.AspNetUsers.Where(s => s.Email == credentials.userName).ToList();
                if (Aspnet.Count > 1)
                {
                    return BadRequest(Errors.AddErrorToModelState("", "Multiple Email Id Exist Please Use UserName.", ModelState));
                }
                else
                {
                    IsPassword = IsValidPassword(credentials.userName, credentials.password);
                }
            }
            //get the companycode with username to login    

            else if (IsValidCompnayCode(CompanyCode))
            {
                var UserName = credentials.userName.Replace(CompanyCode + ".", "");
                AspNetUsers Aspnet = db.AspNetUsers.Where(s => s.UserName == UserName && s.CompCode == CompanyCode).FirstOrDefault();
                if (Aspnet != null)
                {
                    IsPassword = IsValidPassword(UserName, credentials.password);
                }
                else
                {
                    return BadRequest(Errors.AddErrorToModelState("", "InValid User.", ModelState));// this invalid user  error show 

                }
            }
            //username to login 
            else
            {
                List<AspNetUsers> Aspnet = db.AspNetUsers.Where(s => s.UserName == credentials.userName).ToList();
                if (Aspnet.Count > 1)
                {
                    return BadRequest(Errors.AddErrorToModelState("", "Invalid Username.", ModelState));

                }
                else
                {
                    IsPassword = IsValidPassword(credentials.userName, credentials.password);
                }
            }

            if (IsPassword)
            {
                return BadRequest(Errors.AddErrorToModelState("", "Login Successfull.", ModelState));


            }

            return new OkResult();
        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool IsValidPassword(string Username, string Password, string CompnayId = null, int LoginType = 0)
        {
            AspNetUsers Aspnet = new AspNetUsers();
            if (LoginType == 0)
            {
                Aspnet = db.AspNetUsers.Where(s => s.Email == Username && s.PasswordHash == Password).FirstOrDefault();
                if (Aspnet != null)
                {

                }
            }
            else if (LoginType == 1)
            {
                Aspnet = db.AspNetUsers.Where(s => s.UserName == Username && s.PasswordHash == Password).FirstOrDefault();

            }
            else if (LoginType == 3 && CompnayId != null)
            {
                Aspnet = db.AspNetUsers.Where(s => s.UserName == Username && s.PasswordHash == Password && s.CompCode == CompnayId).FirstOrDefault();
            }
            if (Aspnet != null)
            {
                return true;
            }
            return false;
        }
        public bool IsValidCompnayCode(string Comp)
        {
            AspNetUsers Aspnet = db.AspNetUsers.Where(s => s.CompCode == Comp).FirstOrDefault();
            if (Aspnet != null)
            {
                return true;
            }
            return false;
        }
        // this function create in login method is access
        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return await Task.FromResult<ClaimsIdentity>(null);

            // get the user to verifty
            var userToVerify = await _userManager.FindByNameAsync(userName);

            if (userToVerify == null) return await Task.FromResult<ClaimsIdentity>(null);

            // check the credentials
            if (await _userManager.CheckPasswordAsync(userToVerify, password))
            {
                return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(userName, userToVerify.Id));
            }

            // Credentials are invalid, or account doesn't exist
            return await Task.FromResult<ClaimsIdentity>(null);
        }

        [HttpPost("forgotpassword")]
        // POST api/auth/forgotpassword
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    return Ok();
                }
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);

                // access in emailsender function use in mail send the code with emailsender file 
                await _emailSender.SendEmailAsync(model.Email, "Reset Password",
                $"Please reset your password by clicking here: <a href='http://localhost:8080/ResetPassword?id='" + user.Id + "&code=" + code + "'&res='" + Request.Scheme + "'>link</a>");

            }
            return new OkObjectResult(ModelState);
        }


        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        [HttpGet("getjson")]
        public async Task<ActionResult> GetResult()
        {
            List<StaticDataTable> sd = new List<StaticDataTable>();
            sd.Add(new StaticDataTable
            {
                id = 1,
                name = "Frozen Yogurt",
                calories = "159",
                fat = "6.0",
                carbs = "24",
                protein = "4.0",
                iron = "1%"

            });
            var jsonresult = JsonConvert.SerializeObject(sd);
            var jsonarray = JArray.Parse(jsonresult);
            if (jsonarray != null)
            {
                return new OkObjectResult(jsonarray);
            }
            return Json("");
        }
    }
}
