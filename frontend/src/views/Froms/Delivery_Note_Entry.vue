<template>
<v-app id="inspire">
  <v-card>
     <v-card-text>

              <v-btn @click="Browse" color="success"><v-icon></v-icon>Browse</v-btn>
              <v-btn @click="Hawb" color="primary"><v-icon></v-icon>Hawb</v-btn>
              <v-btn @click="charge" color="primary"><v-icon></v-icon>Charge</v-btn>
              <v-btn color="primary"><v-icon></v-icon>File</v-btn>
              <v-btn @click="Truck" color="primary"><v-icon></v-icon>Truck</v-btn>
              <v-btn @click="Manifest" color="primary"><v-icon></v-icon>Manifest</v-btn>
              <v-btn @click="Label" color="primary"><v-icon></v-icon>Label</v-btn>
              <v-btn color="primary"><v-icon></v-icon>Event log</v-btn>
              <v-container grid-list-md>
                <h3 class="text-center">Delivery Note Entry </h3>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md3>
                    <v-text-field  label="HAWB"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field  label="MAWB"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field  label="Job#"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field  label="Shipper"></v-text-field>
                  </v-flex>                  
                </v-layout>
                <v-layout justify-center>
                   <v-flex xs12 sm6 md3>
                   <v-layout justify-center> 
                   <v-flex xs12 sm6 md4>                    
                   <v-menu ref="menu" v-model="menu" :close-on-content-click="false" :nudge-right="40" lazy transition="scale-transition" offset-y full-width max-width="290px" min-width="290px">
                   <v-text-field slot="activator" v-model="date" label="ETD -/+Days" readonly></v-text-field>
                   <v-date-picker  v-model="date" :max="new Date().toISOString().substr(0, 10)" min="01-01-1997" @change="save"></v-date-picker>
                  </v-menu>
                  </v-flex>
                    <v-flex xs12 sm6 md4>
                      <v-text-field  label=""></v-text-field>
                    </v-flex>
                    <v-flex xs12 sm6 md4>
                      <v-text-field  label=""></v-text-field>
                    </v-flex>
                  </v-layout>
                  </v-flex>
                  <v-flex xs12 sm6 md3>     
                  <v-select :items="Freehand" label="Freehand"></v-select>     
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field  label="POL"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field  label="Consignee"></v-text-field>
                  </v-flex>                  
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md3>
                  <v-layout justify-center> 
                    <v-flex xs12 sm6 md4>
                  <v-menu ref="menuto" v-model="menuto" :close-on-content-click="false" :nudge-right="40" lazy transition="scale-transition" offset-y full-width max-width="290px" min-width="290px">
                   <v-text-field slot="activator" v-model="date1" label="ETA -/+Days" readonly></v-text-field>
                   <v-date-picker  v-model="date1" :max="new Date().toISOString().substr(0, 10)" min="01-01-1997" @change="savetodate"></v-date-picker>
                  </v-menu>
                  </v-flex>
                    <v-flex xs12 sm6 md4>
                      <v-text-field  label=""></v-text-field>
                    </v-flex>
                    <v-flex xs12 sm6 md4>
                      <v-text-field  label=""></v-text-field>
                    </v-flex>
                  </v-layout>
                  </v-flex>
                  <v-flex xs12 sm6 md3>     
                  <v-select :items="Terms" label="Terms"></v-select>              
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field  label="POD"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field  label="Agent"></v-text-field>
                  </v-flex>                  
                </v-layout>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md3>    
                  <v-select :items="Division" label="Division"></v-select>             
                  </v-flex>
                   <v-flex xs12 sm6 md3>
                  <v-select :items="Status" label="Status"></v-select>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                  <v-select :items="Hello" label="User"></v-select>
                  </v-flex>
                  <v-flex xs12 sm6 md3>
                    <v-text-field  label="Customer"></v-text-field>
                  </v-flex>                  
                </v-layout>             
              </v-container>
            </v-card-text>  
            <v-card-actions>
              <v-spacer></v-spacer>  
                         
              <v-dialog v-model="dialog" max-width="50pc">
              <v-btn round slot="activator" color="primary" style="margin-right:5px"><v-icon>search</v-icon>Search</v-btn>
                <v-card>
                <v-card-title>
                <v-spacer></v-spacer>
                <v-text-field v-model="search" append-icon="search" label="Search" single-line hide-details></v-text-field>
                </v-card-title>
                <v-data-table :headers="headers" :items="desserts" :search="search">
              <template slot="items" slot-scope="props">
              <td>{{ props.item.name }}</td>
              <td class="text-xs">{{ props.item.calories }}</td>
              <td class="text-xs">{{ props.item.fat }}</td>
              <td class="text-xs">{{ props.item.carbs }}</td>
              <td class="text-xs">{{ props.item.protein }}</td>
              <td class="text-xs">{{ props.item.iron }}</td>
            </template>
            <v-alert slot="no-results" :value="true" color="error" icon="warning">
              Your search for "{{ search }}" found no results.
            </v-alert>
            </v-data-table>
            </v-card>
            </v-dialog>
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
      search: '',
      headers: [
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
      desserts: [
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
       date: null,
    menu: false,
    date1: null,
    menuto: false
    }),
    watch: {
    menu (val) {
      val && this.$nextTick(() => (this.$refs.picker.activePicker = 'YEAR'))
    },
    menuto (val) {
      val && this.$nextTick(() => (this.$refs.picker.activePicker = 'YEAR'))
    }
  },
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
