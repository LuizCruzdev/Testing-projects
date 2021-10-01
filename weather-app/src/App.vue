<template>
  <div id="app">
    <main>
        <div class='search-box'>
          <input type='text' class='search-bar' placeholder='Search...'>

        </div>
      </main>
  </div>
</template>

<script>

export default {
  name: 'App',
  data () {
    return {
      api_key: '50763ceb6b5cb0cdfcbc97ec36ff0f08'
    }

  }
}

</script>

<style>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}
 body {
   font-family:'montserrat', sans-serif;
  
 }

 #app {
   background-image: url('./assets/cold-bg.jpg');
   background-size: cover;
   background-position: bottom;
   transition: 0.4s;
 }

main {

   min-height: 100vh;
   padding: 25px;
   background-image: linear-gradient(to bottom, rgba(0,0,0,0.25), rgba(0,0,0,0.75))
}

.search-box{
  width: 100%;
  margin-bottom: 30px;
}

.search-box .search-bar {
  display: block;
  width: 100%;
  padding: 15px;

  color:black;
  font-size: 20px;
  
  appearance:none;
  border:none;
  outline:none;
  background: none;

  background-color: rgba(255,255,255,0.5)
}
</style>
