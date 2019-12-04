import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router'
import VueResource from 'vue-resource'
import router from './routes'

Vue.use(VueRouter);
Vue.use(VueResource);

Vue.http.options.root = "http://localhost:51287/api/"

new Vue({
  el: '#app',
  render: h => h(App),
  router
})
