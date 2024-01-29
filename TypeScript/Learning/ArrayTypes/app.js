var favoriteActivities;
favoriteActivities = ['Sports', 'Cooking', 'Chilling'];
var favoriteColors;
favoriteColors = ['Yellow', 'Orange'];
var favoriteNumbers;
favoriteNumbers = [23, 3];
var animalsArray;
animalsArray = ['Dogs', 2, 'Cats', 2, 'Fishes', 3, 'Mouses', 2];
var person = {
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
for (var _i = 0, _a = person.hobbies; _i < _a.length; _i++) {
    var hobby = _a[_i];
    console.log(hobby);
}
for (var _b = 0, _c = person.colors; _b < _c.length; _b++) {
    var color = _c[_b];
    console.log(color);
}
for (var _d = 0, _e = person.number; _d < _e.length; _d++) {
    var nb = _e[_d];
    console.log(nb);
}
for (var _f = 0, _g = person.animals; _f < _g.length; _f++) {
    var animal = _g[_f];
    console.log(animal);
}
for (var _h = 0, _j = person.activities; _h < _j.length; _h++) {
    var activity = _j[_h];
    console.log(activity);
}
for (var _k = 0, _l = person.bestColors; _k < _l.length; _k++) {
    var bestColor = _l[_k];
    console.log(bestColor);
}
for (var _m = 0, _o = person.numbers; _m < _o.length; _m++) {
    var nbs = _o[_m];
    console.log(nbs);
}
for (var _p = 0, _q = person.newAnimals; _p < _q.length; _p++) {
    var newAnimal = _q[_p];
    console.log(newAnimal);
}
