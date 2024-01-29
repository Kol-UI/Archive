<script>
import SlotsChildComp from './SlotsChildComp.vue'

export default {
  components: {
    SlotsChildComp
  },
  data() {
    return {
      msg: 'from parent'
    }
  }
}
</script>

<template>
  <SlotsChildComp></SlotsChildComp>
</template>