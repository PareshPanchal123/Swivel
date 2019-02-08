
<template>
  <v-app>
    <v-toolbar dark color="#1e4584">
      <v-flex>
        <v-btn depressed small color="info" style="padding-left: 0px; height: 28px;"><v-icon small color="dark right" style=" padding-right: 6px; padding-left: 6px;">notes</v-icon>Rel.Notes</v-btn>
        <v-btn depressed small color="info" style="padding-left: 0px; height: 28px;"><v-icon small color="dark right" style=" padding-right: 6px; padding-left: 6px;">help</v-icon>User Guide</v-btn>
        <v-btn depressed small color="info" style="padding-left: 0px; height: 28px;"><v-icon small color="dark right" style=" padding-right: 6px; padding-left: 6px;">ondemand_video</v-icon>Video Guide </v-btn>
        <v-btn depressed small color="error" style="padding-left: 0px; height: 28px;"><v-icon small color="dark right" style=" padding-right: 6px; padding-left: 6px;">person</v-icon>Log in</v-btn>
  
      </v-flex>
      <v-flex>
      </v-flex>
      <v-spacer></v-spacer>
      <v-flex fixed>
      <v-img :src="require('../assets/Swivel_ERP.png')"
                class="responsive-img"
                contain                 
                fixed                
                 aspect-ratio="2.75" style="margin-right: -24px; max-height: 62px;background-color: white;">
              </v-img>
              </v-flex>
    </v-toolbar>
  </v-app>
</template>