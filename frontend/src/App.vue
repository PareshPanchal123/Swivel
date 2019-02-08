<template>
 <div id="appRoot">
<template v-if="!$route.meta.public">
      <v-app id="inspire" class="app">
        <app-drawer class="app--drawer">
        </app-drawer>
                    <app-toolbar class="app--toolbar"></app-toolbar>
        <v-content>
          <!-- Page Header -->
          <page-header v-if="$route.meta.breadcrumb"></page-header>
          <div class="page-wrapper">
            <router-view></router-view>
          </div>   
             <!-- App Footer -->
           	<v-footer fixed dark height="auto">
		        <v-card class="flex" color="primary darken-3" flat tile>
            <v-card-title class="grad">
            <strong class="subheading white--text" ></strong>
            <v-spacer></v-spacer>
      </v-card-title>
      <v-card-actions class="primary darken-3 justify-center white--text">
       <strong>&copy;{{ new Date().getFullYear() }}</strong><strong></strong>
      </v-card-actions>
    </v-card>
  </v-footer>
       <!-- End Of FooterPart -->
        </v-content>

  </v-app>
</template>
  <template v-else>
      <transition>
        <keep-alive>
          <router-view :key="$route.fullpath"></router-view>
        </keep-alive>
      </transition>
    </template>
    <!-- <v-snackbar
      :timeout="3000"
      bottom
      right
      :color="snackbar.color"
      v-model="snackbar.show"
    >
      {{ snackbar.text }}
      <v-btn dark flat @click.native="snackbar.show = false" icon> 
        <v-icon>close</v-icon>
      </v-btn>
    </v-snackbar>     -->
  </div>
</template>
<script>
import HelloWorld from './components/HelloWorld';
import AppDrawer from '@/components/AppDrawer';
import AppToolbar from '@/components/AppToolbar';
import AppFab from '@/components/AppFab';
import PageHeader from '@/components/PageHeader';
import VWidget from '@/components/VWidget';
import AppEvents from  './event';

import axios from 'axios';

export default {
  
  name: 'App',
  components: {
    HelloWorld,
     AppToolbar,
    AppDrawer,
    AppFab,
    PageHeader,
    VWidget
  },
  
  data () {
    return {
            
    }
  }
  
   

}
</script>

<style lang="stylus" scoped>
  .setting-fab 
    top:50%!important; 
    right:0;
    border-radius:0  
  .page-wrapper
    min-height:calc(100vh - 64px - 50px - 81px );  

</style>
