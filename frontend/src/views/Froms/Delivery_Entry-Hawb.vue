<template>
<v-app id="inspire">
  <v-card>
     <v-card-text>

              <v-btn @click="Browse" color="primary"><v-icon></v-icon>Browse</v-btn>
              <v-btn @click="Hawb" color="success"><v-icon></v-icon>Hawb</v-btn>
              <v-btn @click="charge" color="primary"><v-icon></v-icon>Charge</v-btn>
              <v-btn color="primary"><v-icon></v-icon>File</v-btn>
              <v-btn @click="Truck" color="primary"><v-icon></v-icon>Truck</v-btn>
              <v-btn @click="Manifest" color="primary"><v-icon></v-icon>Manifest</v-btn>
              <v-btn @click="Label" color="primary"><v-icon></v-icon>Label</v-btn>
              <v-btn color="primary"><v-icon></v-icon>Event log</v-btn>
              <v-container grid-list-md>
                <h3 class="text-center">Delivery Note Entry</h3>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md4>
                    <v-text-field v-model="HAWB" label="HAWB#"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field v-model="MAWB" label="MAWB#"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  v-model="Job" label="Job"></v-text-field>
                  </v-flex>                  
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md6>             
                      <v-text-field v-model="Shipper" label="Shipper*"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md6>     
                    <v-text-field v-model="Service_Type" label="Service Type"></v-text-field>     
                  </v-flex>                  
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md4>
                    <v-lable>Show Identifier</v-lable>
                          <v-checkbox v-model="checkbox" style="margin-left:8pc;margin-top:-1.5pc"></v-checkbox> 
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  label="Sub Master B/L#"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  label="Manifest Number"></v-text-field>
                  </v-flex>                  
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md3>    
                    <blockquote class="blockquote"
                    style="position:relative; top:-25px; left:-25px;">A0003 <br>ABC FOOTWEAR CO LTD <br>
                      SHENZHEN BUILDING <br>
                      SHENZHEN, CHINA</blockquote>
                  </v-flex>
                  <v-flex xs12 sm6 md9>
                    <v-text-field v-model="Freehand" label="Freehand*"></v-text-field>
                  </v-flex>                  
                </v-layout>     
                 <v-layout justify-center>
                  <v-flex xs12 sm6 md6>
                    <v-text-field v-model="Controlling_Customer" label="Controlling Customer*"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md6>
                    <v-text-field v-model="Name" label="Name"></v-text-field>
                  </v-flex>                  
                </v-layout>

                 <v-layout justify-center>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  label="Brand"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  label="Network"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field v-model="Customer_Salesman" label="Customer Salesman*"></v-text-field>
                  </v-flex>                  
                </v-layout>

              </v-container>
            </v-card-text>  
            <v-card-actions>
              <v-spacer></v-spacer>  
             
      </v-card-actions>
    </v-card>
  </v-app>
</template>
<script>
  export default {
    data: () => ({
      Action: ['Booking', 'Cancel', 'Delete', 'Read'],
      Freehand: ['Demo', 'Data', 'Test', 'Freehand'],
      Terms: ['MyTerm', 'Test', 'Terms'],
      Division: ['AI','BE', 'CE', 'DE'],
      Status: ['All', 'Highest','Lowest'],
      Hello: ['Foo', 'Bar', 'Fizz', 'Buzz'],
      Salesman: ['Nikul', 'Paresh', 'Mitesh', 'Bhargav','Shankar'],
      HAWB : 'TS985999',
      MAWB : '160-4885-688',
      Job : 'AIHKG181000003',
      Shipper : 'A0003  ABC FOOTWEAR CO LTD',
      Service_Type : 'AIR IMPORT',
      Freehand : 'F',
      Controlling_Customer : 'A0001',
      Name : 'ABC SHOES NEW YORK OFFICE',
      Customer_Salesman : 'HKMMA',
      
    }),
  methods: {
    save (date) {
      this.$refs.menu.save(date)
    },
    savetodate (date1) {
      this.$refs.menuto.save(date1)
    },

    Browse : function(){
      window.location.href = '/Delivery_Entry';
    },
    Hawb : function(){
      window.location.href = '/Delivery_Entry-Hawb';
    },
    charge : function(){
      window.location.href = '/Delivery_Entry-Charge';
    },
    Truck : function(){
      window.location.href = '/Delivery_Entry-Truck';
    },
    Label : function(){
      window.location.href = '/Delivery_Entry-Label';
    },
    Manifest : function(){
      window.location.href = '/Delivery_Entry-Manifest';
    }
    
  }
  }
</script>
