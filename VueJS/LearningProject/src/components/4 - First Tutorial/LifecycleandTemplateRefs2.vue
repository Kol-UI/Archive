<script>
export default {
  mounted() {
    this.$refs.p.textContent = 'mounted!'
  }
}
</script>

<template>
  <p ref="p">hello</p>
</template>

<!--
To run code after mount, we can use the mounted option:

js
export default {
  mounted() {
    // component is now mounted.
  }
}
-->