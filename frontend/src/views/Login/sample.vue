<template>
<v-app id="inspire">
<v-navigation-drawer :clipped="$vuetify.breakpoint.lgAndUp"
v-model="drawer"
fixed
app>
<v-list>

<v-list-group>
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>AirFreght</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(AirFreght, i) in AirFreghts"
:key="i">
<v-list-tile-title v-text="AirFreght[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="AirFreght[1]">AirFreght</v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

<v-list-group>
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>Inbound</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(inbound, i) in Inbounds"
:key="i">
<v-list-tile-title v-text="Inbound[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="Inbound[1]">Inbound</v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

<v-list-group>
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>Outbound</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(outbound, i) in Outbounds"
:key="i">
<v-list-tile-title v-text="outbound[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="outbound[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

<v-list-group>
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>Miscellaneous</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(miscellaneous, i) in Miscellaneouss"
:key="i">
<v-list-tile-title v-text="miscellaneous[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="miscellaneous[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

<v-list-group prepend-icon="">
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>Report</v-list-tile-title>
</v-list-tile>

<v-list-group no-action
sub-group
value="true">
<v-list-tile slot="activator">
<v-list-tile-title>outdound</v-list-tile-title>
</v-list-tile>

<v-list-group no-action
sub-group
value="true">
<v-list-tile slot="activator">
<v-list-tile-title>Cargo Sales Report</v-list-tile-title>
</v-list-tile>
</v-list-group>

<v-list-group no-action
sub-group
value="true">
<v-list-tile slot="activator">
<v-list-tile-title>XML EDI Status Report</v-list-tile-title>
</v-list-tile>
</v-list-group>


<v-list-group no-action
sub-group>
<v-list-tile slot="activator">
<v-list-tile-title>FEC Status Report</v-list-tile-title>
</v-list-tile>
</v-list-group>
<v-list-tile v-for="(report, i) in Reports"
:key="i">
<v-list-tile-title v-text="report[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="report[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

<v-list-group sub-group
no-action>
<v-list-tile slot="activator">
<v-list-tile-title>Air Accrual Analysis</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(AccrualAnalysiss, i) in AirAccrualAnalysiss"
:key="i">
<v-list-tile-title v-text="AccrualAnalysiss[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="AccrualAnalysiss[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>


<v-list-group sub-group
no-action>
<v-list-tile slot="activator">
<v-list-tile-title>Air PL Summary By Job</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(PLSummaryByJob, i) in AirPLSummaryByJobs"
:key="i">
<v-list-tile-title v-text="PLSummaryByJob[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="PLSummaryByJob[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

<v-list-group sub-group
no-action>
<v-list-tile slot="activator">
<v-list-tile-title>Air ProfitLoss Sheet by Date</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(ProfitLossSheetbyDate, i) in AirProfitLossSheetbyDates"
:key="i">
<v-list-tile-title v-text="ProfitLossSheetbyDate[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="ProfitLossSheetbyDate[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

<v-list-group sub-group
no-action>
<v-list-tile slot="activator">
<v-list-tile-title>Report Generator</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(ReportGenerator, i) in ReportGenerators"
:key="i">
<v-list-tile-title v-text="ReportGenerator[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="ReportGenerator[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

</v-list-group>

<v-list-group prepend-icon="">
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>Invoice</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(invoice, i) in Invoices"
:key="i">
<v-list-tile-title v-text="invoice[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="invoice[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

 
 <v-list-group prepend-icon="">
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>Tariff</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(tariff, i) in Tariffs"
:key="i">
<v-list-tile-title v-text="tariff[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="tariff[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>


<v-list-group prepend-icon="">
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>Master</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(master, i) in Masters"
:key="i">
<v-list-tile-title v-text="master[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="master[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>


<v-list-group prepend-icon="">
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>Sea-Air </v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(seaair, i) in SeaAirs"
:key="i">
<v-list-tile-title v-text="seaair[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="seaair[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

<v-list-group prepend-icon="">
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>Utility</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(utility, i) in Utilitys"
:key="i">
<v-list-tile-title v-text="utility[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="utility[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

</v-list>
</v-navigation-drawer>
<v-toolbar :clipped-left="$vuetify.breakpoint.lgAndUp"
color="blue darken-3"
dark
app
fixed>
<v-toolbar-title style="width: 300px; margin-left:-7pc" >
Dashbord
</v-toolbar-title>
<v-spacer></v-spacer>
</v-toolbar>
<v-content>
<v-container>
</v-container>
</v-content>
</v-app>
</template>




<script>
  export default {
       name: 'App',
    data: () => ({
        home: [
],
gallery: [
['Graphics', ''],
['Photoshop', '']
],
outbo: [
['Customer/Vender Group', 'people_outline'],
['Customer/Subgroup MainTenance', 'settings'],
['Salesman Master', 'settings'],
['Departmant Master', 'settings'],
['Nature Master', 'settings'],
['Opertional Team', 'settings']
],
headers: [
{ text: '+', value: '+' },
{
text: 'Code',
align: 'left',
sortable: false,
value: 'Code'
},
{ text: 'Name', value: 'Name' },
{ text: 'Email', value: 'Email' },
{ text: 'Phone', value: 'Phone' },
{ text: 'Inactive', value: 'Inactive' },
{ text: 'Created User', value: 'Created User' },
{ text: 'Create Time', value: 'Create Time' },
{ text: 'Station', value: 'Station' },
{ text: 'User', value: 'User' },
{ text: 'Time', value: 'Time' },
{ text: 'Chg After Approved', value: 'Chg After Approved' },
{ text: 'Site Code', value: 'Site Code' },
{ text: 'Site Name', value: 'Site Name' }
],
items: ['Foo', 'Bar', 'Fizz', 'Buzz'],

desserts: [
{
value: true,
No: 1,
Code:'USAM' ,
Nmae:'Matt Motsick' ,
Email: 'matt.matsick@swivelsoftware.com',
Phone: '310-848-4884',
Inactive: '',
CreatedUser: 'ico',
CreateTime: '2018/06/21 6:18:20',
Station: 'USA HQ',
Status: 'y',
User: 'ico',
Time: '2018/06/21 6:18:20',
ChgAfterApproval: '',
Sitecode: '',
Sitename:'USA HQ'

},
{
value: true,
No: 2,
Code: 'HKMMA',
Nmae: 'MANDY MAK',
Email: 'MANDY.MAK@SWIVELSOFTWARE.COM',
Phone: '2760-7811',
Inactive: '',
CreatedUser: 'ico',
CreateTime: '2018/06/21 6:18:20',
Station: 'HKG',
Status: 'y',
User: 'ico',
Time: '2018/06/21 6:18:20',
ChgAfterApproval: '',
Sitecode: '',
Sitename: 'HKG'

}

]
    })
}      
</script>
