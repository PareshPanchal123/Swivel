<template>
  <v-app id="inspire">
    <v-container grid-list-sm>
      <v-layout
        flex-child
        wrap
      >
        <v-flex
          xs12
          md12
          d-flex
          class="elevation-10"
        >
          <v-sheet>
            <v-flex xs12 sm6 md4>
                <v-btn round slot="activator" type="submit" color="primary"><v-icon></v-icon>Browse</v-btn>
                <v-btn round slot="activator" type="submit" color="primary" style="margin-left:-8px;" ><v-icon></v-icon>Detail</v-btn>
            </v-flex>
            <sheet-footer>
               <v-card-text>
              <v-container grid-list-md>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md4>                                       
                   <v-text-field  label="Lot#*"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                 <v-menu ref="menu" v-model="menu" :close-on-content-click="false" :nudge-right="40" lazy transition="scale-transition" offset-y full-width max-width="290px" min-width="290px">
                   <v-text-field slot="activator" v-model="date" label="Date" readonly></v-text-field>
                   <v-date-picker  v-model="date" :max="new Date().toISOString().substr(0, 10)" min="01-01-1997" @change="save"></v-date-picker>
                  </v-menu>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                       <v-container>
                        <v-lable style="margin-left:-1.5pc" >Borrow Flag</v-lable>
                                <v-checkbox style="margin-left:6pc;margin-top:-1.5pc"></v-checkbox> 
                      </v-container> 
                  </v-flex>
                </v-layout>
                <v-layout justify-center style="margin-top:-1.5pc">
                  <v-flex xs12 sm6 md4>     
                 <v-text-field  label="MAWB#*"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                      <v-text-field  label="Issuing Agent"></v-text-field>              
                  </v-flex>   
                  <v-flex xs12 sm6 md4>
                      <v-text-field  label="Name"></v-text-field>
                  </v-flex>          
                </v-layout>
                <v-layout justify-center>    
                   <v-flex xs12 sm6 md4>
                    <v-text-field  label="Status"></v-text-field>              
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  label="Fr/To Agent"></v-text-field>           
                  </v-flex> 
                  <v-flex xs12 sm6 md4> 
                    <v-text-field  label="Reason"></v-text-field>
                  </v-flex>               
                </v-layout> 

                <v-layout justify-center>
                  <v-flex xs12 sm6 md4>     
                 <v-text-field  label="Reserve/Cancel"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                      <v-text-field  label="Load Minimum"></v-text-field>
                  </v-flex>   
                  <v-flex xs12 sm6 md4>
                      <v-text-field  label="Load Unit"></v-text-field>
                  </v-flex>          
                </v-layout>
              </v-container>
            </v-card-text> 
            <v-flex xs12 sm12 md12>
                <center>
                   <v-btn slot="activator" type="submit" color="primary"><v-icon>add</v-icon>Add</v-btn>
                   <v-btn slot="activator" type="submit" color="success"><v-icon>edit</v-icon>Edit</v-btn>
                   <v-btn slot="activator" type="submit" color="error"><v-icon>delete</v-icon>Delete</v-btn>
                </center>
            </v-flex>
            </sheet-footer>
          </v-sheet>
        </v-flex>
      </v-layout>
    </v-container>
  </v-app>
</template>

<script>
export default{
    data: () => ({
       date: null,
    menu: false
    }),
    watch: {
    menu (val) {
      val && this.$nextTick(() => (this.$refs.picker.activePicker = 'YEAR'))
    }
  },
  methods: {
    save (date) {
      this.$refs.menu.save(date)
    }
  }
}
</script>
<!-- <style lang="stylus">
.v-text-field{
   max-width:17pc;
} 
</style> -->
