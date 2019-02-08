import axios from 'axios';
import { Credentials } from '@/models/credentials.interface';
import { BaseService } from './base.service';
import { Observable } from 'rxjs/Rx';
import {forgotpassword} from'@/models/Forgot.interface';
import {Resetpassword} from '@/models/resetpassword.interface';
import { observable } from 'rxjs';
import { ajaxPost } from 'rxjs/internal-compatibility';
import { async } from 'rxjs/internal/scheduler/async';
// import 'rxjs/add/observable/fromPromise';

class AuthService extends BaseService {

    private static instance: AuthService;

    private constructor() {  super(); }

    public static get Instance() {
       // Do you need arguments? Make it a regular method instead.
       return this.instance || (this.instance = new this());
    }

    public login(credentials: Credentials): Observable<any> {
        return Observable.fromPromise(axios.post(`${this.api}/auth/login`, credentials))
        .map((res: any) => res.data.auth_token)
        .catch((error: any) => this.handleError(error.response));    
         
    }
    public forgot(Forgot: forgotpassword): Observable<any> {
        return Observable.fromPromise(axios.post(`${this.api}/auth/forgotpassword`, Forgot))
        .map((res: any) => res.data.auth_token)
        .catch((error: any) => this.handleError(error.response));    
    }
    public reset(Reset: Resetpassword): Observable<any> {
        return Observable.fromPromise(axios.post(`${this.api}/auth/resetpassword`, Reset))
        .map((res: any) => res.data.auth_token)
        .catch((error: any) => this.handleError(error.response));    
    }
   
    
}

// export a singleton instance in the global namespace
export const authService = AuthService.Instance;
