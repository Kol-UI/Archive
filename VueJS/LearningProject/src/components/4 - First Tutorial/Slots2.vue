<script>
import ChildComp from './ChildComp.vue'
import SlotsChildComp from './SlotsChildComp.vue'

export default {
  components: {
    ChildComp,
    SlotsChildComp,
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
    <SlotsChildComp> Message: {{ msg }}</SlotsChildComp>
</template>