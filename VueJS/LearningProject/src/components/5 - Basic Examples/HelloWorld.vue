<!--
Say Hello World with Vue!
-->

<script>
export default {
  data() {
    return {
      message: 'Hello World!'
    }
  }
}
</script>

<template>
  <h1>{{ message }}</h1>
</template>

<!--
    HTML :

    <script type="module">
    import { createApp } from 'vue'

    createApp({
    data() {
        return {
        message: 'Hello World!'
        }
    }
    }).mount('#app')
    </script>

    <div id="app">
        <h1>{{ message }}</h1>
    </div>
-->