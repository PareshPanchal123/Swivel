<template>
<v-app id="inspire">
  <v-card>
     <v-card-text>

              <v-btn @click="Browse" color="primary"><v-icon></v-icon>Browse</v-btn>
              <v-btn @click="Hawb" color="primary"><v-icon></v-icon>Hawb</v-btn>
              <v-btn @click="charge" color="success"><v-icon></v-icon>Charge</v-btn>
              <v-btn color="primary"><v-icon></v-icon>File</v-btn>
              <v-btn @click="Truck" color="primary"><v-icon></v-icon>Truck</v-btn>
              <v-btn @click="Manifest" color="primary"><v-icon></v-icon>Manifest</v-btn>
              <v-btn @click="Label" color="primary"><v-icon></v-icon>Label</v-btn>
              <v-btn color="primary"><v-icon></v-icon>Event log</v-btn>
              <v-container grid-list-md>
                <h3 class="text-center">Delivery Note Entry</h3>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md4>
                    <v-text-field v-model="HAWB" label="HAWB"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field v-model="MAWB" label="MAWB"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  v-model="Job" label="Job"></v-text-field>
                  </v-flex>          
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md8>
                    <v-text-field v-model="Shipper" label="Shipper*"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  label="Quotation(PP)"></v-text-field>
                  </v-flex>                  
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md12>
                    <v-text-field  v-model="Consignee" label="Consignee*"></v-text-field>
                  </v-flex>                  
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md8>    
                  <v-text-field  v-model="DestAgent" label="Dest.Agent"></v-text-field>             
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field  label="Quotation(CC)"></v-text-field>
                  </v-flex>                  
                </v-layout> 
                <v-layout justify-center>
                  <v-flex xs12 sm6 md3>    
                  <v-text-field  v-model="FlightNo" label="Flight No."></v-text-field>             
                  </v-flex>
                  <v-flex xs12 sm6 md3> 
                   <v-text-field v-model="ETDdate" label="ETD Date/Time"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field v-model="ETAdate" label="ETA Date/Time"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field  label="Customer"></v-text-field>
                  </v-flex>                  
                </v-layout>  
                 <v-layout justify-center>
                  <v-flex xs12 sm6 md3>    
                  <v-text-field  v-model="Qty" label="Qty"></v-text-field>             
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field v-model="GrossWgt" label="Gross Wgt."></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                   <v-text-field v-model="VolumeWgt" label="Volume Wgt."></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-layout justify-center>
                      <v-flex xs12 sm6 md6>
                        <v-text-field v-model="ChargeableWgt" label="Chargeable Wgt."></v-text-field>
                      </v-flex>
                      <v-flex xs12 sm6 md6>
                        <v-text-field v-model="CBM" label="CBM"></v-text-field>
                      </v-flex>
                    </v-layout>
                  </v-flex>                  
                </v-layout> 
                    <v-layout justify-center>
                  <v-flex xs12 sm6 md3>    
                  <v-text-field  v-model="FRTTerms" label="FRT Terms"></v-text-field>             
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field v-model="OTHTerms" label="OTH Terms"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                   <v-text-field v-model="POL" label="POL"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                   <v-layout justify-center>
                      <v-flex xs12 sm6 md6>
                        <v-text-field v-model="POD" label="POD"></v-text-field>
                      </v-flex>
                      <v-flex xs12 sm6 md6>
                        <v-text-field v-model="F" label="F"></v-text-field>
                      </v-flex>
                    </v-layout>
                  </v-flex>                  
                </v-layout> 
              </v-container>
            </v-card-text>  
           
            <!-- Sales & Purchase Datatable  -->
            <v-dialog v-model="dialog" max-width="50pc">
              <v-btn round slot="activator" color="primary" style="margin-right:5px">Sales</v-btn>
                <v-card>
                <v-card-title>
                <v-spacer></v-spacer>
                <v-text-field v-model="searchsales" append-icon="search" label="Search" single-line hide-details></v-text-field>
                </v-card-title>
                <v-data-table :headers="headerssales" :items="dessertssales" :search="searchsales">
              <template slot="items" slot-scope="props">
              <td>{{ props.item.name }}</td>
              <td class="text-xs">{{ props.item.calories }}</td>
              <td class="text-xs">{{ props.item.fat }}</td>
              <td class="text-xs">{{ props.item.carbs }}</td>
              <td class="text-xs">{{ props.item.protein }}</td>
              <td class="text-xs">{{ props.item.iron }}</td>
            </template>
            <v-alert slot="no-results" :value="true" color="error" icon="warning">
              Your search for "{{ searchsales }}" found no results.
            </v-alert>
            </v-data-table>
            </v-card>
            </v-dialog>

            <!-- Purchase -->
             <v-dialog v-model="dialog1" max-width="50pc">
              <v-btn round slot="activator" color="warning" style="margin-right:5px">Purchase</v-btn>
                <v-card>
                <v-card-title>
                <v-spacer></v-spacer>
                <v-text-field v-model="searchpurchase" append-icon="search" label="Search" single-line hide-details></v-text-field>
                </v-card-title>
                <v-data-table :headers="headerspurchase" :items="dessertspurchase" :search="searchpurchase">
              <template slot="items" slot-scope="propspurchase">
              <td>{{ propspurchase.item.name }}</td>
              <td class="text-xs">{{ propspurchase.item.calories }}</td>
              <td class="text-xs">{{ propspurchase.item.fat }}</td>
              <td class="text-xs">{{ propspurchase.item.carbs }}</td>
              <td class="text-xs">{{ propspurchase.item.protein }}</td>
              <td class="text-xs">{{ propspurchase.item.iron }}</td>
            </template>
            <v-alert slot="no-results" :value="true" color="error" icon="warning">
              Your search for "{{ searchpurchase }}" found no results.
            </v-alert>
            </v-data-table>
            </v-card>
            </v-dialog>
            <!-- End Purchase -->

            <!-- End -->
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
      
      searchsales: '',
      searchpurchase: '',
      headerssales: [
        {
          text: 'Dessert (100g serving)',
          align: 'left',
          sortable: false,
          value: 'name'
        },
        { text: 'Calories', value: 'calories' },
        { text: 'Fat (g)', value: 'fat' },
        { text: 'Carbs (g)', value: 'carbs' },
        { text: 'Protein (g)', value: 'protein' },
        { text: 'Iron (%)', value: 'iron' }
      ],
      headerspurchase: [
        {
          text: 'Dessert (100g serving)',
          align: 'left',
          sortable: false,
          value: 'name'
        },
        { text: 'Calories', value: 'calories' },
        { text: 'Fat (g)', value: 'fat' },
        { text: 'Carbs (g)', value: 'carbs' },
        { text: 'Protein (g)', value: 'protein' },
        { text: 'Iron (%)', value: 'iron' }
      ],
      dessertssales: [
        {
          name: 'Frozen Yogurt',
          calories: 159,
          fat: 6.0,
          carbs: 24,
          protein: 4.0,
          iron: '1%'
        },
        {
          name: 'Ice cream sandwich',
          calories: 237,
          fat: 9.0,
          carbs: 37,
          protein: 4.3,
          iron: '1%'
        },
        {
          name: 'Eclair',
          calories: 262,
          fat: 16.0,
          carbs: 23,
          protein: 6.0,
          iron: '7%'
        },
        {
          name: 'Cupcake',
          calories: 305,
          fat: 3.7,
          carbs: 67,
          protein: 4.3,
          iron: '8%'
        },
        {
          name: 'Gingerbread',
          calories: 356,
          fat: 16.0,
          carbs: 49,
          protein: 3.9,
          iron: '16%'
        },
        {
          name: 'Jelly bean',
          calories: 375,
          fat: 0.0,
          carbs: 94,
          protein: 0.0,
          iron: '0%'
        },
        {
          name: 'Lollipop',
          calories: 392,
          fat: 0.2,
          carbs: 98,
          protein: 0,
          iron: '2%'
        },
        {
          name: 'Honeycomb',
          calories: 408,
          fat: 3.2,
          carbs: 87,
          protein: 6.5,
          iron: '45%'
        },
        {
          name: 'Donut',
          calories: 452,
          fat: 25.0,
          carbs: 51,
          protein: 4.9,
          iron: '22%'
        },
        {
          name: 'KitKat',
          calories: 518,
          fat: 26.0,
          carbs: 65,
          protein: 7,
          iron: '6%'
        }
      ],
      dessertspurchase: [
        {
          name: 'Nikul',
          calories: 159,
          fat: 6.0,
          carbs: 24,
          protein: 4.0,
          iron: '1%'
        },
        {
          name: 'Mitesh',
          calories: 237,
          fat: 9.0,
          carbs: 37,
          protein: 4.3,
          iron: '1%'
        },
        {
          name: 'Eclair',
          calories: 262,
          fat: 16.0,
          carbs: 23,
          protein: 6.0,
          iron: '7%'
        },
        {
          name: 'Paresh Panchal',
          calories: 305,
          fat: 3.7,
          carbs: 67,
          protein: 4.3,
          iron: '8%'
        },
        {
          name: 'Gingerbread',
          calories: 356,
          fat: 16.0,
          carbs: 49,
          protein: 3.9,
          iron: '16%'
        },
        {
          name: 'Jelly bean',
          calories: 375,
          fat: 0.0,
          carbs: 94,
          protein: 0.0,
          iron: '0%'
        },
        {
          name: 'Lollipop',
          calories: 392,
          fat: 0.2,
          carbs: 98,
          protein: 0,
          iron: '2%'
        },
        {
          name: 'Honeycomb',
          calories: 408,
          fat: 3.2,
          carbs: 87,
          protein: 6.5,
          iron: '45%'
        },
        {
          name: 'Donut',
          calories: 452,
          fat: 25.0,
          carbs: 51,
          protein: 4.9,
          iron: '22%'
        },
        {
          name: 'KitKat',
          calories: 518,
          fat: 26.0,
          carbs: 65,
          protein: 7,
          iron: '6%'
        }
      ]

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

