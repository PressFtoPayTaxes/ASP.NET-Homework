<template>
  <div id="app">
    <div class='header'>
      <img src='./assets/logo.jpg'>
      <h3>Show the world your pics</h3>  
    </div>

    <router-view></router-view>
  </div>
</template>

<script>
export default {
  name: 'app',
  data () {
    return {
      msg: 'Welcome to Your Vue.js App'
    }
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

h1, h2 {
  font-weight: normal;
}

ul {
  list-style-type: none;
  padding: 0;
}

li {
  display: inline-block;
  margin: 0 10px;
}

a {
  color: #42b983;
}

.header{
  width: 100%;
  display: flex;
  height: 70px;
  background-color: #01a66a;
  justify-content: center;
}

.header img{
  width: 100px;
}

.header h3{
  line-height: 40px;
  color: white;
}

input[type='text'], input[type='password']{
  height: 30px;
  margin: 10px 0;
  font-size: 24px;
}

button{
  font-size: 16px;
  padding: 15px 30px;
  color: white;
  border: 0;
  background-color: #01a66a;
  border-radius: 5%;
  margin: 10px 0;
}
</style>
