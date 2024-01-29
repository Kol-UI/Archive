<script>
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
  <EmitsChildComp />
  <p>{{ childMsg }}</p>
</template>