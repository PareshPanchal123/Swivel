<template>
  <v-app id="inspire">
    <v-content>
      <v-container fluid fill-height>
        <v-layout align-center justify-center>
          <v-flex xs12 sm8 md4>
            <v-card class="elevation-12">
              <v-toolbar dark color="primary">
                <v-toolbar-title>Reset Password</v-toolbar-title>
                <v-spacer></v-spacer>
         
              </v-toolbar>

              <v-form @submit.prevent="handleSubmit">
              
              <v-card-text>
                <v-text-field prepend-icon="person"   v-on:onload.prevent="mounted()" v-model="reset.code" label="Code" type="text" required></v-text-field>
                 <v-text-field prepend-icon="person" v-model="reset.Email"   label="Username" type="text" required></v-text-field>
                  <v-text-field prepend-icon="lock" v-model="reset.Password"   label="New Password" type="password" required></v-text-field>
                  <v-text-field prepend-icon="lock" v-model="reset.ConfirmPassword"  label="Confirm Password" type="password" required></v-text-field>
        
              </v-card-text>
              <v-card-actions>
                <v-spacer></v-spacer>
               <v-btn color="primary" type="submit" class="" medium  style="margin-right:1.5pc">Reset</v-btn>
              </v-card-actions>
              <br>     
            <div v-if="errors" style="color:red;font-size:14px;">
             {{errors}}
            </div>
        
        </v-form>
              <v-flex>
              <v-spacer></v-spacer>
              </v-flex>
            </v-card>
          </v-flex>
        </v-layout>
      </v-container>
    </v-content>
  </v-app>
</template>

<script lang="ts">
import Spinner from '@/components/Spinner.vue'; // @ is an alias to /src
import { Component, Vue } from 'vue-property-decorator';
import { Resetpassword } from '@/models/resetpassword.interface';


// this.$route.query.page

@Component({
  components: {
    Spinner,
  },
})


export default class resetForm extends Vue {
  private isBusy: boolean = false;
private errors: string = '';
private reset:any= {} as Resetpassword;
private nm: string='';
private handleSubmit()
{

  this.isBusy = true;
    
     this.$store.dispatch('auth/resetpassword', this.reset).then((result) => {
        this.$router.push('/LoginPage');
        
      })
   .catch((err) => {
    this.errors = err;
  })
  .then(() => {
    this.isBusy = false;
  });

}
private mounted()
{
  this.reset.code =this.$route.query.code;
}
}
</script>

