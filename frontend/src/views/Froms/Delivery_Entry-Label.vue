<template>
<v-app id="inspire">
  <v-card>
     <v-card-text>

              <v-btn @click="Browse" color="primary"><v-icon></v-icon>Browse</v-btn>
              <v-btn @click="Hawb" color="primary"><v-icon></v-icon>Hawb</v-btn>
              <v-btn @click="charge" color="primary"><v-icon></v-icon>Charge</v-btn>
              <v-btn color="primary"><v-icon></v-icon>File</v-btn>
              <v-btn @click="Truck" color="primary"><v-icon></v-icon>Truck</v-btn>
              <v-btn @click="Manifest" color="primary"><v-icon></v-icon>Manifest</v-btn>
              <v-btn @click="Label" color="success"><v-icon></v-icon>Label</v-btn>
              <v-btn color="primary"><v-icon></v-icon>Event log</v-btn>
              <v-container grid-list-md>
                <h3 class="text-center">Delivery Note Entry</h3>
                <v-layout justify-center>
                  <v-flex xs12 sm6 md6>
                    <v-text-field v-model="HAWB" label="HAWB#"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md6>
                    <v-text-field v-model="MAWB" label="MAWB"></v-text-field>
                  </v-flex>       
                </v-layout>

    <v-flex xs12 sm12 md12>        
    <v-data-table
      :headers="headers"
      :items="desserts"
      class="elevation-1"
      prev-icon="mdi-menu-left"
      next-icon="mdi-menu-right"
      sort-icon="mdi-menu-down"
    >
      <template slot="items" slot-scope="props">
        <td>{{ props.item.name }}</td>
        <td class="text-xs-right">{{ props.item.calories }}</td>
        <td class="text-xs-right">{{ props.item.fat }}</td>
        <td class="text-xs-right">{{ props.item.carbs }}</td>
        <td class="text-xs-right">{{ props.item.protein }}</td>
        <td class="text-xs-right">{{ props.item.iron }}</td>
      </template>
    </v-data-table> 
    </v-flex>
    </v-container>
    </v-card-text> 
    </v-card>
    <br><br><br><br>
  </v-app>
</template>
<script>
  export default {
    data: () => ({

        HAWB : 'TS985999',
        MAWB : '160-4885-688',
      headers: [
        {
          text: 'Label Number',
          align: 'left',
          sortable: false,
          value: 'name'
        },
        { text: 'Type', align: 'right', value: 'calories' },
        { text: 'Seal Number', align: 'right', value: 'fat' },
        { text: 'Status', align: 'right', value: 'carbs' },
        { text: 'Time', align: 'right', value: 'protein' },
        { text: 'Received By', align: 'right', value: 'iron' }
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
