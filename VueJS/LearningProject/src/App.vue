<script setup>
import HelloWorld from './components/HelloWorld.vue'
import TheWelcome from './components/TheWelcome.vue'
import HelloWorld2 from './components/5 - Basic Examples/HelloWorld.vue'
import HandlingUserInput from './components/5 - Basic Examples/HandlingUserInput.vue'
import AttributeBindings from './components/5 - Basic Examples/AttributeBindings.vue'
import ConditionalsandLoops from './components/5 - Basic Examples/ConditionalsandLoops.vue'
import FormBindings from './components/5 - Basic Examples/FormBindings.vue'
import SimpleComponent from './components/5 - Basic Examples/SimpleComponent.vue'
import MarkdownEditor from './components/6 - Practical Examples/MarkdownEditor.vue'
import FetchingData from './components/6 - Practical Examples/FetchingData.vue'
import GridWithSortAndFilter from './components/6 - Practical Examples/GridWithSortAndFilter.vue'
import TreeView from './components/6 - Practical Examples/TreeView.vue'
import SVGGraph from './components/6 - Practical Examples/SVGGraph.vue'
import ModalWithTransitions from './components/6 - Practical Examples/ModalWithTransitions.vue'
import ListWithTransitions from './components/6 - Practical Examples/ListWithTransitions.vue'
import TodoMVC from './components/6 - Practical Examples/TodoMVC.vue'
import Counter from './components/7 - GUI Examples/Counter.vue'
import TemperatureConverter from './components/7 - GUI Examples/TemperatureConverter.vue'
import Timer from './components/7 - GUI Examples/Timer.vue'
import CRUD from './components/7 - GUI Examples/CRUD.vue'
import Cells from './components/7 - GUI Examples/Cells.vue'
</script>

<template>
  <header>
    <img alt="Vue logo" class="logo" src="./assets/logo.svg" width="125" height="125" />

    <div class="wrapper">
      <HelloWorld msg="You did it!" />
    </div>
  </header>

  <main>
    <TheWelcome />
  </main>

  <div class="wrapper">
    <HelloWorld2 msg="Hello World!" />
  </div>
  <div class="wrapper">
    <HandlingUserInput />
  </div>

  <div class="wrapper">
    <AttributeBindings />
  </div>
  <div class="wrapper">
    <ConditionalsandLoops />
  </div>

  <div class="wrapper">
    <FormBindings />
  </div>
  <div class="wrapper">
    <SimpleComponent />
  </div>

  <div class="wrapper">
    <MarkdownEditor />
  </div>
  <div class="wrapper">
    <FetchingData />
  </div>

  <div class="wrapper">
    <GridWithSortAndFilter />
  </div>
  <div class="wrapper">
    <TreeView />
  </div>

  <div class="wrapper">
    <SVGGraph />
  </div>
  <div class="wrapper">
    <ModalWithTransitions />
  </div>

  <div class="wrapper">
    <ListWithTransitions />
  </div>
  <div class="wrapper">
    <Counter />
  </div>

  <div class="wrapper">
    <TemperatureConverter />
  </div>
  <div class="wrapper">
    <Timer />
  </div>

  <div class="wrapper">
    <CRUD />
  </div>
  <div class="wrapper">
    <Cells />
  </div>
</template>

<style scoped>
header {
  line-height: 1.5;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>
