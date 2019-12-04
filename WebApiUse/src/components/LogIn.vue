<template>
  <div>
      <form>
          <legend><h2>Log In</h2></legend>
          <input type="text" placeholder="Login" v-model='login'>
          <br>
          <input type="password" placeholder="Password" v-model='password'>
          <br>
          <router-link to='/register'><a>Don't have account yet? Register now</a></router-link>
          <br>
          <button @click="logIn()">Log In</button>
      </form>
  </div>
</template>

<script>
import Vue from 'vue'
export default {
    data(){
        return {
            login: "",
            password: ''
        }
    },
    methods:{
        logIn(){
            var users;
            this.$http.get('users').then(response => {
                var isLoggedIn = false;
                for(var i = 0; i < response.data.length; i++){
                    if(response.data[i].Login == this.login && response.data[i].Password == this.password){
                        this.$router.push({ name: 'posts', params: { id: response.data[i].Id }});
                        isLoggedIn = true;
                    }
                }
                if(isLoggedIn == false){
                    alert("There's no account with such credentials");
                }
            });

        }
    }
}
</script>

<style>

</style>