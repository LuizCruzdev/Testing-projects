<template>
<div class='container'>
  <header>
    <h1>Planilha da Família Baleiorca Suprema!</h1>
  </header>

  <body>
    <b-form>
      <b-row>
        <b-col>
          <label>Meio de pagamento</label>
          <select class="meio" v-model="nubank" id="inputGroupSelect01" >
            <option selected>Choose...</option>
            <option value="1">Dinheiro</option>
            <option value="2" class='nubank'>Nubank</option>
            <option value="3">BB</option>
            <option value="4">VR</option>
          </select>
        </b-col>
        <b-col>
          <div class ='pag' v-if='nubank == true' :display=true>
          <label>Forma de Pagamento de pagamento</label>
            <select class="custom-select" id="inputGroupSelect01">
              <option selected>Choose...</option>
              <option value="1">Débito</option>
              <option value="2">Crédito</option>
            </select>
          </div>
        </b-col>
      </b-row>
    </b-form>
  </body>

</div>

</template>


<script>

// data() {
//     return {
//         option: null
//     }
// }
// var vm = new Vue({
//     data: {
//         key: ""
//     },
//     methods: {
//         onChange(event) {
//             console.log(event.target.value)
//         }
//     }
// })
</script>

<style>

</style>
