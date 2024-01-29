let favoriteActivities: string[];
favoriteActivities = ['Sports', 'Cooking', 'Chilling'];

let favoriteColors: string[];
favoriteColors = ['Yellow', 'Orange'];

let favoriteNumbers: number[];
favoriteNumbers = [23, 3]

let animalsArray: any[];
animalsArray = ['Dogs', 2, 'Cats', 2, 'Fishes', 3, 'Mouses', 2]

const person = {
    name: 'Maxime',
    nickname: 'Max',
    age: 30,
    hobbies: ['Sports', 'Cooking'],
    activities: favoriteActivities,
    colors: ['Green', 'Blue'],
    bestColors: favoriteColors,
    number: [23],
    numbers: favoriteNumbers,
    animals: ['Dogs', 2, 'Cats', 2, 'Fishes', 3],
    newAnimals: animalsArray
};

console.log(person);
console.log(person.name);
console.log(person.nickname);
console.log(person.hobbies);

for(const hobby of person.hobbies){
    console.log(hobby);
}
for(const color of person.colors){
    console.log(color);
}
for(const nb of person.number){
    console.log(nb);
}
for(const animal of person.animals){
    console.log(animal);
}

for(const activity of person.activities){
    console.log(activity);
}
for(const bestColor of person.bestColors){
    console.log(bestColor);
}
for(const nbs of person.numbers){
    console.log(nbs);
}
for(const newAnimal of person.newAnimals){
    console.log(newAnimal);
}