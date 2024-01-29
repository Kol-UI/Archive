<script>
export default {
  // component options
  // declare some reactive state here.
  data() {
    return {
      message: 'Hello World!'
    }
  }
}
</script>

<template>
  <h1>Make me dynamic!</h1>
  <h1>{{ message }}</h1>
  <h1>{{ message.split('').reverse().join('') }}</h1>
</template>

<!--
The message property will be made available in the template.
This is how we can render dynamic text based on the value of message
-->