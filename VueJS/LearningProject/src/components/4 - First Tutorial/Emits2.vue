<script>
import ChildComp from './ChildComp.vue'
import EmitsChildComp from './EmitsChildComp.vue';

export default {
  components: {
    ChildComp,
    EmitsChildComp
},
  data() {
    return {
      childMsg: 'No child msg yet'
    }
  }
}
</script>

<template>
  <EmitsChildComp @response="(msg) => childMsg = msg" />
  <p>{{ childMsg }}</p>
</template>