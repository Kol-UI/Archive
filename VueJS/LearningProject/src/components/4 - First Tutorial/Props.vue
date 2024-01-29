<script>
import ChildComp from './ChildComp.vue'
import PropsChildComp from './PropsChildComp.vue';

export default {
  components: {
    ChildComp,
    PropsChildComp
},
  data() {
    return {
      greeting: 'Hello from parent'
    }
  }
}
</script>

<template>
  <PropsChildComp />
</template>