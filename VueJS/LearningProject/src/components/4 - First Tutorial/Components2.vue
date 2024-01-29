<!-- 
    A parent component can render another component in its template as a child component.
    To use a child component, we need to first import it:
-->
<script>
import ChildComp from './ChildComp.vue'

export default {
  components: {
    ChildComp
  }
}
</script>

<template>
    <!--
        We also need to register the component using the components option.
        Here we are using the object property shorthand to register the ChildComp component under the ChildComp key.
        Then, we can use the component in the template as:
    --> 
  <ChildComp />
</template>