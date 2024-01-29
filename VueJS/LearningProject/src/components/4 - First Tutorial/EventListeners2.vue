<script>
export default {
  data() {
    return {
      count: 0
    }
  },
  methods: {
    increment() {
        // update component state
        this.count++
    }
  }
}
</script>

<template>
  <button @click="increment">count is: {{ count }}</button>
</template>