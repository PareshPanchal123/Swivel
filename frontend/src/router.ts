import Vue from "vue";
import Router from "vue-router";
import Home from "./views/Home.vue";
import LoginPage from "./views/Login/LoginPage.vue";
import sample  from "./views/Login/sample.vue"
import store from './store/store';

Vue.use(Router);

export default new Router({
  mode: "history",
  base: process.env.BASE_URL,
  routes: [
    {
      path: "/",
      meta: {
        public: true,
      },
      name: "LoginPage",
      component: LoginPage
    },
    {
      path: "/LoginPage",
      name: "LoginPage",
      component: LoginPage
    },
    {
      path: "/sample",
      name: "sample",
      component: sample
    },
    {
      path: "/about",
      name: "about",
      component: () =>
        import("./views/About.vue")
    },
    {
      path: "/con845",
      name: "con845",
      component: () =>
        import("./views/con845.vue")
    },
    {
      path: "/ResetPassword",
      meta: {
        public: true,
      },
      name: "ResetPassword",
       
      component: () =>
        import("./views/Login/ResetPassword.vue")
    },

    {
      path: "/IndexjsonData",
      name: "IndexjsonData",
       
      component: () =>
        import("./views/IndexjsonData.vue")
    },
    {
      path: "/ForgotPassword",
      meta: {
        public: true,
      },
      name: "ForgotPassword",
      component: () =>
        import("./views/Login/ForgotPassword.vue")
    },
    {
      path:"/ForgotPasswordConfirmation",
      meta: {
        public: true,
      },
      name :"ForgotPasswordConfirmation",
      component: () =>
              import("./views/Login/ForgotPasswordConfirmation.vue")
    },
    {
      path: '/Outbound_Analysis',
      name: 'Outbound_Analysis',
      component: () => import(
        `@/views/Froms/Outbound_Analysis.vue`
      )
    },
    {
      path: '/Bill_Distribution',
      name: 'Bill_Distribution',
      component: () => import(
        `@/views/Froms/Bill_Distribution.vue`
      )
    },
    {
      path: '/Delivery_Entry',
      name: 'Delivery_Entry',
      component: () => import(
        `@/views/Froms/Delivery_Note_Entry.vue`
      )
    },
    {
      path: '/Delivery_Entry-Hawb',
      name: 'Delivery_Entry-Hawb',
      component: () => import(
        `@/views/Froms/Delivery_Entry-Hawb.vue`
      )
    },
    {
      path: '/Delivery_Entry-charge',
      name: 'Delivery_Entry-charge',
      component: () => import(
        `@/views/Froms/Delivery_Entry-Charge.vue`
      )
    },
    {
      path: '/Delivery_Entry-Truck',
      name: 'Delivery_Entry-Truck',
      component: () => import(
        `@/views/Froms/Delivery_Entry-Truck.vue`
      )
    },
    {
      path: '/Delivery_Entry-Label',
      name: 'Delivery_Entry-Label',
      component: () => import(
        `@/views/Froms/Delivery_Entry-Label.vue`
      )
    },
    {
      path: '/Delivery_Entry-Manifest',
      name: 'Delivery_Entry-Manifest',
      component: () => import(
        `@/views/Froms/Delivery_Entry-Manifest.vue`
      )
    },

    {
      path: '/OutboundMawbStock',
      name: 'OutboundMawbStock',
      component: () => import(
        `@/views/Froms/OutboundMawbStock.vue`
      )
    },
    {
      path: '/OutboundMawbStockAE',
      name: 'OutboundMawbStockAE',
      component: () => import(
        `@/views/Froms/OutboundMawbStockAE.vue`
      )
    },
    {
      path: '/subtotal',
      name: 'subtotal',
      component: () => import(
        `@/views/subtotal.vue`
      )
    },
    
  ]
});


