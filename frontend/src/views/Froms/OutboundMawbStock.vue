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
            <sheet-footer>
               <v-card-text>
              <v-container grid-list-md>
                <h3 class="text-center">OUTBOUND MAWB STOCK</h3>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md4>                    
                   <v-text-field  label="MAWB#"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  label="Lot#"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                      <v-container>
                        <v-lable>Borrow</v-lable>
                                <v-checkbox v-model="checkbox" style="margin-left:3pc;margin-top:-1.5pc"></v-checkbox> 
                      </v-container> 
                  </v-flex>                  
                </v-layout>
                <v-layout justify-center style="margin-top:-1.5pc">
                  <v-flex xs12 sm6 md4>     
                 <v-text-field  label="Issuing Agent"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  label="Fr/To Agent"></v-text-field>
                  </v-flex> 
                  <v-flex xs12 sm6 md4>
                  </v-flex>               
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md4>    
                  <v-select :items="Division" label="Division"></v-select>             
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                  <v-select :items="Status" label="Status"></v-select>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                   <v-btn slot="activator" type="submit" color="primary" style="margin-left:1.5pc;margin-top:1pc"><v-icon>search</v-icon>Search</v-btn>
                  </v-flex>                
                </v-layout>             
              </v-container>
            </v-card-text> 
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
        Division: ['AE','BE', 'CE', 'DE', 'FE'],
      Status: ['Normal', 'Highest','Lowest'],
    })
}
</script>
