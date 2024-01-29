<!-- Minimal Example -->

<div id="app">
    <button @click="count++">
      Count is: {{ count }}
    </button>
</div>

import { createApp } from 'vue'

createApp({
  data() {
    return {
      count: 0
    }
  }
}).mount('#app')