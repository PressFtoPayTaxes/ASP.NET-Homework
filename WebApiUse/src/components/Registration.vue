<template>
  <div>
      <form>
          <legend><h2>Registration</h2></legend>
          <input type="text" placeholder="Login" v-model='login'>
          <br>
          <input type="password" placeholder="Password" v-model='password'>
          <br>
          <button @click="register()">Register</button>
      </form>
  </div>
</template>

<script>
export default {
    data(){
        return {
            login: '',
            password: ''
        }
    },
    methods:{
        register(){
            if(this.login == '' || this.password == ''){
                alert("Some fields are empty")
                return;
            }

            var user = {
                login: this.login,
                password: this.password
            }

            this.$http.post('users', user).then(response => {
                console.log(response);
            });
        }
    }
}
</script>

<style>

</style>