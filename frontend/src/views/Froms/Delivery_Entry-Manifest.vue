<template>
<v-app id="inspire">
  <v-card>
     <v-card-text>

              <v-btn @click="Browse" color="primary"><v-icon></v-icon>Browse</v-btn>
              <v-btn @click="Hawb" color="primary"><v-icon></v-icon>Hawb</v-btn>
              <v-btn @click="charge" color="primary"><v-icon></v-icon>Charge</v-btn>
              <v-btn color="primary"><v-icon></v-icon>File</v-btn>
              <v-btn @click="Truck" color="primary"><v-icon></v-icon>Truck</v-btn>
              <v-btn @click="Manifest" color="success"><v-icon></v-icon>Manifest</v-btn>
              <v-btn @click="Label" color="primary"><v-icon></v-icon>Label</v-btn>
              <v-btn color="primary"><v-icon></v-icon>Event log</v-btn>
              <v-container grid-list-md>
                <h3 class="text-center">Delivery Note Entry</h3>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md6>
      
                    <v-chip  label>Shipper*</v-chip>
                    
                  </v-flex>
                  <v-flex xs12 sm6 md6>
                    <v-chip  label>Manifest Shipper's Name & Address</v-chip>
                  </v-flex>       
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md6>
                  
                      <blockquote class="blockquote">A0003 <br>ABC FOOTWEAR CO LTD <br>
                      SHENZHEN BUILDING <br>
                      SHENZHEN, CHINA</blockquote>
                  
                  </v-flex>
                  <v-flex xs12 sm6 md6>
                    <blockquote class="blockquote">ABC FOOTWEAR CO LTD <br>
                      SHENZHEN BUILDING <br>
                      SHENZHEN, CHINA</blockquote>
                  </v-flex>       
                </v-layout>

                <v-layout justify-center>
                  <v-flex xs12 sm6 md6>
      
                    <v-chip  label>Consignee*</v-chip>
                    
                  </v-flex>
                  <v-flex xs12 sm6 md6>
                    <v-chip  label>Manifest Consignee's Name & Address</v-chip>
                  </v-flex>       
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md6>
                  
                      <blockquote class="blockquote">A0001 <br>ABC SHOES NEW YORK OFFICE<br>
                      NEW YORK, UNITED STATES <br>
                      154-09 146TH AVENUE 3RD FLOOR <br>
                      JAMAICA, NY 11434 <br>
                      TEL: 718-276 1212 EXT.12 FAX: 718 276 1199</blockquote>
                  
                  </v-flex>
                  <v-flex xs12 sm6 md6>
                    <blockquote class="blockquote">ABC SHOES NEW YORK OFFICE 
                      <br>
                      NEW YORK UNITED STATES <br>
                      154-09 146TH AVENUE 3RD FLOOR <br>
                      JAMAICA, NY 11434</blockquote>
                  </v-flex>       
                </v-layout>

                <v-layout justify-center>
                  <v-flex xs12 sm6 md6>
      
                    <v-chip  label>Notify#1</v-chip>
                    
                  </v-flex>
                  <v-flex xs12 sm6 md6>
                    <v-chip  label>Manifest Notify#1's Name & Address</v-chip>
                  </v-flex>       
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md6>
                  
                      <blockquote class="blockquote"> <br>
                      SAME AS CONSIGNEE </blockquote>
                  
                  </v-flex>
                  <v-flex xs12 sm6 md6>
                    <blockquote class="blockquote"></blockquote>
                  </v-flex>       
                </v-layout>

                <v-layout justify-center>
                  <v-flex xs12 sm6 md6>
      
                    <v-chip  label>Agent</v-chip>
                    
                  </v-flex>
                  <v-flex xs12 sm6 md6>
                   
                  </v-flex>       
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md6>
                  
                      <blockquote class="blockquote">S0001 <br>
                      SWIVEL FREIGHT (HONG KONG) LTD.<br>
                      HONG KONG </blockquote>
                  
                  </v-flex>
                  <v-flex xs12 sm6 md6>
                    
                  </v-flex>       
                </v-layout>
    </v-container>
    </v-card-text> 
    </v-card>
    <br><br><br><br>
  </v-app>
</template>
<script>
  export default {
    data: () => ({
      Action: ['Booking', 'Cancel', 'Delete', 'Read'],
      Freehand: ['Demo', 'Data', 'Test', 'Freehand'],
      Terms: ['MyTerm', 'Test', 'Terms'],
      Status: ['All', 'Highest','Lowest'],
      Hello: ['Foo', 'Bar', 'Fizz', 'Buzz'],
      Salesman: ['Nikul', 'Paresh', 'Mitesh', 'Bhargav','Shankar'],
      HAWB : 'TS985999',
      MAWB : '160-4885-688',
      Job : 'AIHKG181000003',
      Shipper : 'A0003  ABC FOOTWEAR CO LTD',
      Consignee : 'A0001  ABC SHOES NEW YORK OFFICE',
      DestAgent : 'S0001 SWIVEL FREIGHT (HONG KONG) LTD.',
      FlightNo : '8887',
      Qty : '10',
      ETDdate : '09/10/2018',
      ETAdate : '11/10/2018',
      GrossWgt : '1000.00',
      POL : 'HKG',
      POD : 'HKG',
      F : 'F',
      VolumeWgt : '1200.00',
      ChargeableWgt : '1200.00',
      CBM : '0.000',
      FRTTerms : 'PP',
      OTHTerms : 'PP',
      
    

    }),

  methods: {

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
