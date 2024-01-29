<!--
A nested tree component that recursively renders itself.
You can double click on an item to turn it into a folder.
-->

<script>
import TreeItem from './TreeItem.vue'

const treeData = {
  name: 'My Tree',
  children: [
    { name: 'hello' },
    { name: 'wat' },
    {
      name: 'child folder',
      children: [
        {
          name: 'child folder',
          children: [{ name: 'hello' }, { name: 'wat' }]
        },
        { name: 'hello' },
        { name: 'wat' },
        {
          name: 'child folder',
          children: [{ name: 'hello' }, { name: 'wat' }]
        }
      ]
    }
  ]
}

export default {
  components: {
    TreeItem
  },
  data() {
    return {
      treeData
    }
  }
}
</script>

<template>
  <ul>
    <TreeItem class="item" :model="treeData"></TreeItem>
  </ul>
</template>

<style>
.item {
  cursor: pointer;
  line-height: 1.5;
}
.bold {
  font-weight: bold;
}
</style>


<!-- 
    HTML :

<script type="module">
import { createApp } from 'vue'
import TreeItem from './TreeItem.js'

const treeData = {
  name: 'My Tree',
  children: [
    { name: 'hello' },
    { name: 'wat' },
    {
      name: 'child folder',
      children: [
        {
          name: 'child folder',
          children: [{ name: 'hello' }, { name: 'wat' }]
        },
        { name: 'hello' },
        { name: 'wat' },
        {
          name: 'child folder',
          children: [{ name: 'hello' }, { name: 'wat' }]
        }
      ]
    }
  ]
}

createApp({
  components: {
    TreeItem
  },
  data() {
    return {
      treeData
    }
  }
}).mount('#app')
</script>

<div id="app">
  <ul>
    <tree-item class="item" :model="treeData"></tree-item>
  </ul>
</div>
-->

<!--
    TreeItem.js :
export default {
  name: 'TreeItem', // necessary for self-reference
  props: {
    model: Object
  },
  data() {
    return {
      isOpen: false
    }
  },
  computed: {
    isFolder() {
      return this.model.children && this.model.children.length
    }
  },
  methods: {
    toggle() {
      if (this.isFolder) {
        this.isOpen = !this.isOpen
      }
    },
    changeType() {
      if (!this.isFolder) {
        this.model.children = []
        this.addChild()
        this.isOpen = true
      }
    },
    addChild() {
      this.model.children.push({
        name: 'new stuff'
      })
    }
  },
  template: `
  <li>
    <div
      :class="{ bold: isFolder }"
      @click="toggle"
      @dblclick="changeType">
      {{ model.name }}
      <span v-if="isFolder">[{{ isOpen ? '-' : '+' }}]</span>
    </div>
    <ul v-show="isOpen" v-if="isFolder">
      <tree-item
        class="item"
        v-for="model in model.children"
        :model="model">
      </tree-item>
      <li class="add" @click="addChild">+</li>
    </ul>
  </li>
  `
}
-->


<!--
    CSS :
.item {
  cursor: pointer;
  line-height: 1.5;
}
.bold {
  font-weight: bold;
}

-->