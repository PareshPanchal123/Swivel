<template>
  <v-toolbar
    color="primary darken-1"
    fixed
    dark
    app
    >
    <v-toolbar-title class="ml-0 pl-3">
      <v-toolbar-side-icon @click.stop="handleDrawerToggle"></v-toolbar-side-icon>
    </v-toolbar-title>
      <v-text-field
        flat
        solo-inverted
        label="Search"
        class="hidden-sm-and-down"
        >
      </v-text-field><v-icon style="margin-left: 10px;">search</v-icon>
      <v-spacer></v-spacer>   
      <v-btn icon @click="handleFullScreen()">
        <v-icon>fullscreen</v-icon>
      </v-btn>      
  </v-toolbar>
  
</template>
<script>
import Util from '@/util';
export default {
  name: 'app-toolbar',
  components: {
  },
  data: () => ({
    drawer: false,
    items: [
      {
        icon: 'account_circle',
        href: '#',
        title: 'Profile',
        click: (e) => {
          console.log(e);
        }
      },
      {
        icon: 'fullscreen_exit',
        href: '#',
        title: 'Logout',
        click: (e) => {
          window.getApp.$emit('APP_LOGOUT');
        }
      }
    ],
  }),
  computed: {
    toolbarColor () {
      return this.$vuetify.options.extra.mainNav;
    }
  },
  methods: {
    handleDrawerToggle () {
      window.getApp.$emit('APP_DRAWER_TOGGLED');
    },
    handleFullScreen () {
      Util.toggleFullScreen();
    }
  }
};
</script>
