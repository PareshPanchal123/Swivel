<template>
 <v-app id="inspire">
    <v-content>
      <v-container fluid fill-height>
        <v-layout align-center justify-center>
          <v-flex xs12 sm8 md4>
            <v-card class="elevation-12">
              <v-toolbar dark color="primary">
                <v-toolbar-title>ForgotPassword</v-toolbar-title>
                <v-spacer></v-spacer>
              </v-toolbar>
              <br>
              <form @submit.prevent="handleSubmit">
              <v-card-text>
                
                   <v-text-field prepend-icon="email" v-model="forgotpass.email" type="email"   label="EmailId"  required></v-text-field>
               
              </v-card-text>
              <v-card-actions>
                <v-spacer></v-spacer>
                <v-btn color="primary" type="submit" style="margin-right:1.5pc" >Send</v-btn>
              </v-card-actions>
               </form>
                <v-spacer></v-spacer>
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
import { forgotpassword } from '@/models/Forgot.interface';



// this.$route.query.page

@Component({
  components: {
    Spinner,
  },
})

export default class ForgotForm extends Vue {
  private isBusy: boolean = false;
private errors: string = '';
private forgotpass = {} as forgotpassword;

private handleSubmit()
{
     this.isBusy = true;
     this.$store.dispatch('auth/forgot',this.forgotpass).then((result) => {
        this.$router.push('/ForgotPasswordConfirmation');
    })
   .catch((err) => {
    this.errors = err;
  })
  .then(() => {
    this.isBusy = false;
  });

}
}
</script>

