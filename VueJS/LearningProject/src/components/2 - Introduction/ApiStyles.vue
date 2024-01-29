<script>
export default {
  // Properties returned from data() become reactive state
  // and will be exposed on `this`.
  data() {
    return {
      count: 0
    }
  },

  // Methods are functions that mutate state and trigger updates.
  // They can be bound as event handlers in templates.
  methods: {
    increment() {
      this.count++
    }
  },

  // Lifecycle hooks are called at different stages
  // of a component's lifecycle.
  // This function will be called when the component is mounted.
  mounted() {
    console.log(`The initial count is ${this.count}.`)
  }
}
</script>

<template>
  <button @click="increment">Count is: {{ count }}</button>
</template>


<!-- Equivalent JS 
/* Analyzed bindings: {
    "count": "data",
    "increment": "options"
  } */
  
  const __sfc__ = {
    // reactive state
    data() {
      return {
        count: 0
      }
    },
  
    // functions that mutate state and trigger updates
    methods: {
      increment() {
        this.count++
      }
    },
  
    // lifecycle hooks
    mounted() {
      console.log(`The initial count is ${this.count}.`)
    }
  }
  
  import { toDisplayString as _toDisplayString, openBlock as _openBlock, createElementBlock as _createElementBlock } from "vue"
  function render(_ctx, _cache, $props, $setup, $data, $options) {
    return (_openBlock(), _createElementBlock("button", {
      onClick: _cache[0] || (_cache[0] = (...args) => ($options.increment && $options.increment(...args)))
    }, "Count is: " + _toDisplayString($data.count), 1 /* TEXT */))
  }
  __sfc__.render = render
  __sfc__.__file = "App.vue"
  export default __sfc__
-->


<!-- Equivalent CSS
/* No <style> tags present */
-->


<!-- SSR
/* Analyzed bindings: {
  "count": "data",
  "increment": "options"
} */

const __sfc__ = {
  // reactive state
  data() {
    return {
      count: 0
    }
  },

  // functions that mutate state and trigger updates
  methods: {
    increment() {
      this.count++
    }
  },

  // lifecycle hooks
  mounted() {
    console.log(`The initial count is ${this.count}.`)
  }
}

import { ssrRenderAttrs as _ssrRenderAttrs, ssrInterpolate as _ssrInterpolate } from "vue/server-renderer"
function ssrRender(_ctx, _push, _parent, _attrs, $props, $setup, $data, $options) {
  _push(`<button${
    _ssrRenderAttrs(_attrs)
  }>Count is: ${
    _ssrInterpolate($data.count)
  }</button>`)
}
__sfc__.ssrRender = ssrRender
__sfc__.__file = "App.vue"
export default __sfc__
-->