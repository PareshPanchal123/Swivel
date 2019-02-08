<template>
<v-app id="inspire">
  <v-card>
     <v-card-text>


              <v-container grid-list-md>
              
    <v-flex xs12 sm12 md12 class="table-responsive"> 
        <v-btn @click="Browse" color="info"><v-icon></v-icon>Browse</v-btn>   
 
<v-btn @click="createPDF" color="danger"><v-icon></v-icon>pdf</v-btn>          
 <v-btn @click="ExcelData" color="success"><v-icon></v-icon>Excel</v-btn>
<v-spacer></v-spacer>
</v-flex>

      <table id="example" class=""  width="100%">
    <thead>
    <tr>
      <th colspan="4">Complete</th>
      <th colspan="4">InProgres</th>
    </tr>
    <tr>
		<th class="th-sm"> ID</th>
		<th class="th-sm">Name</th>
		<th class="th-sm">Calories</th>
		<th class="th-sm">Fat</th>
		<th class="th-sm">Carbs</th>
    <th class="th-sm">Protein</th>
    <th class="th-sm">Iron </th>
    <th></th>
	</tr>
    </thead>					
 <tbody>
    <tr v-for="question in response" :key="question.id" >
        <td>{{question.id}}</td>
        <td>{{question.name}}</td>
        <td>{{question.calories}}</td>
        <td>{{question.fat}}</td>
        <td>{{question.carbs}}</td>
        <td>{{question.protein}}</td>
        <td>{{question.iron}}</td>
        <td></td>
        </tr>
 </tbody>
 <tfoot>
   <tr>
     <th colspan="2">Sub Total </th>
     <th colspan="1">1107</th>
     <th colspan="1">42.0</th>
     <th colspan="2">Sub Total</th>
     <th colspan="1">5</th>
     <th></th>
     </tr>
 </tfoot>
      </table>
    </v-container>
    </v-card-text> 
    </v-card>
    <br><br><br><br>
  </v-app>
</template>



<script lang="ts">
import Spinner from '@/components/Spinner.vue'; // @ is an alias to /src
import { Component, Vue } from 'vue-property-decorator';
import axios from 'axios';
import jsPDF from 'jspdf';
//  import { autoTable } from 'jspdf-autotable'; 
import    'jspdf-autotable';
import XLSX from 'xlsx'
var pdfMake = require('pdfmake/build/pdfmake.js');
    var pdfFonts = require('pdfmake/build/vfs_fonts.js');
    pdfMake.vfs = pdfFonts.pdfMake.vfs;




// this.$route.query.page

Component({
  components: {
    Spinner,

  },
})


export default  {
  el:'#example',
 data: () => ({
      isBusy : false,
     errors :  '',
    response : [],    
 }),

 methods: {
 
 Browse : function(){
       axios.get('https://localhost:44314/api/auth/getjson').then((response)=>{
        
        this.response = response.data;
      
        })
      },

createPDF()
    {
    var doc=new jsPDF('p','pt');
    // doc.text('hello',10,12)
    doc.autoTable({html:'#example'});
    doc.save('datatable.pdf')

    },
ExcelData()
    {
        

   
    // export json to Worksheet of Excel
      // only array possible
  
      //var tbl =document.getElementById('example')
      const tHeader=['Id', 'Title', 'Author', 'Readings', 'Date']

      var animalWS = XLSX.utils.table_to_sheet(document.getElementById('example'))
    
    //var animalWS=XLSX.utils.table_to_book(tbl)
    // A workbook is the name given to an Excel file
      var wb = XLSX.utils.book_new() // make Workbook of Excel
      
      // add Worksheet to Workbook
      // Workbook contains one or more worksheets
      XLSX.utils.book_append_sheet(wb, animalWS, 'animals') 
       // export Excel file
    
    XLSX.writeFile(wb, 'book.xlsx') // name of the file is 'book.xlsx'
   
    

    }
 
 }    
}  
</script>
<style>
#example {
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#example td, #example th {
  border: 1px solid #ddd;
  padding: 8px;
}

#example tr:nth-child(even){background-color: #f2f2f2;}

#example tr:hover {background-color: #ddd;}

#example th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color:#1976d2 ;
  color: white;
}
</style>

