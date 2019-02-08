<template>
  <v-navigation-drawer
    id="appDrawer"
    :mini-variant.sync="mini"
    fixed
    :dark="$vuetify.dark"
    app
    v-model="drawer"
    width="260"
    >
    <v-toolbar color="primary darken-1" dark>
    <v-card style="left:-24px">
          <v-img
            src=""
          width="4pc"></v-img></v-card>
      <v-toolbar-title class="ml-0 pl-3">
              
      </v-toolbar-title>       
    </v-toolbar>
    <vue-perfect-scrollbar class="drawer-menu--scroll" :settings="scrollSettings">
      <v-list dense expand>
<v-list-group>
<v-list-tile slot="activator">
<v-list-tile-action>
<v-icon></v-icon>
</v-list-tile-action>
<v-list-tile-title>AirFreght</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(airFreght, i) in AirFreghts"
:key="i">
<v-list-tile-title v-text="airFreght[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="airFreght[1]">airFreght</v-icon>
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

<v-list-group sub-group
no-action>
<v-list-tile slot="activator">
<v-list-tile-title>Inbound</v-list-tile-title>
</v-list-tile>

<v-list-tile v-for="(inbound, i) in Inbounds"
:key="i">
<v-list-tile-title v-text="inbound[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="inbound[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>
</v-list-group>

<v-list-group no-action
sub-group
value="true">
<v-list-tile slot="activator">
<v-list-tile-title>Outbound</v-list-tile-title>
</v-list-tile>
<v-list-tile v-for="(outbound, i) in outbounds"
:key="i">
<v-list-tile-title v-text="outbound[0]"></v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="outbound[1]">outbound</v-icon>
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
    </vue-perfect-scrollbar>        
  </v-navigation-drawer>
</template>
<script>
import VuePerfectScrollbar from 'vue-perfect-scrollbar';
export default {
  name: 'app-drawer',
  components: {
    VuePerfectScrollbar,
  },
  props: {
    expanded: {
      type: Boolean,
      default: true
    },
  },
  data: () => ({
    mini: false,
    drawer: true,
    scrollSettings: {
      maxScrollbarLength: 160
    },
    outbounds: [
        ['Cargo Sales Report', 'report '],
        ['XML EDI Status Report', 'report'],
        ['FEC Status Report', 'report']
    ]    
  }),
  computed: {
    computeGroupActive () {
      return true;
    },
    sideToolbarColor () {
      return this.$vuetify.options.extra.sideNav;
    }    
  },
  created () {
    window.getApp.$on('APP_DRAWER_TOGGLED', () => {
      this.drawer = (!this.drawer);
    });
  },
  

  methods: {
    genChildTarget (item, subItem) {
      if (subItem.href) return;
      if (subItem.component) {
        return {
          name: subItem.component,
        };
      }
      return { name: `${item.group}/${(subItem.name)}` };
    },
  }
};
</script>


<style lang="stylus">
// @import '../../node_modules/vuetify/src/stylus/settings/_elevations.styl';

#appDrawer
  overflow: hidden
  .drawer-menu--scroll
    height: calc(100vh - 48px)
    overflow: auto

</style>
