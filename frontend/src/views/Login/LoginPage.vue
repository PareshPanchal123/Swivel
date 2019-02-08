 <template>
 <center>
  <v-app id="inspire" class="mx-auto">

        <v-container fluid fill-height>
        <v-layout align-center justify-center>
      <v-flex xs12 sm8 md4>
      <v-card class="elevation-24">
       
        <v-card-title class="headline font-weight-regular blue white--text elevation-24">Login
        <v-img :src="require('../../assets/swivel.png')"
                class="my-0"
                contain 
                height="50px"
                width="50"
                 aspect-ratio="2.75" style="margin-left: 15pc;">
              </v-img>
        </v-card-title>
          <v-card flat class="elevation-24">
            <v-card-title primary-title>
            </v-card-title>
             <article class="message is-success" v-if="$route.query.new">
          <div class="message-body">
            <strong>You're all set {{$route.query.firstName}}!</strong> Login with your password to continue.
          </div>
          </article>
            <form @submit.prevent="handleSubmit">
            <v-text-field prepend-icon="person"   label="UserName" required v-model="credentials.userName"></v-text-field>
            <v-text-field prepend-icon="lock"   label="Password" type="password" required v-model="credentials.password"></v-text-field>
            <v-spacer class="1"></v-spacer>
            <div v-bind:show="isBusy"> </div>
            <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn color="primary" type="submit" class="" style="margin-right:1.5pc" medium>Login</v-btn>
              <a href="ForgotPassword" color="danger">Forgot Password</a>
            </v-card-actions > 
            <br>     
            <h1 v-if="errors" style="color:red;font-size:14px;">
             {{errors}}
            </h1>
        
            </form>
          </v-card>
        
        </v-card>
      </v-flex>
      </v-layout>
      </v-container>
  </v-app> 
      </center> 
</template>

<script lang="ts">
import Spinner from '@/components/Spinner.vue'; // @ is an alias to /src
import { Component, Vue } from 'vue-property-decorator';
import { Credentials } from '@/models/credentials.interface';

// this.$route.query.page

@Component({
  components: {
    Spinner,
  },
})

export default class LoginForm extends Vue {
  private isBusy: boolean = false;
private errors: string = '';
private credentials = {} as Credentials;



private handleSubmit() {
     this.isBusy = true;
     
     this.$store.dispatch('auth/authRequest', this.credentials).then((result) => {
        this.$router.push('/con845');
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





<style>
.container{
    margin-left:1pc;
}
.v-text-field{
    max-width:30pc;
    margin-left:5pc;
    margin-right:5pc;
}
</style>

