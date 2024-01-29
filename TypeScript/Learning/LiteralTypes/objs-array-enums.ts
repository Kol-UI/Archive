enum Role { ADMIN = 5, READ_ONLY, AUTHOR }; // Other are 6 and 7 instead of 0, 1 & 2

const person = {
    name: 'Maxime',
    nickname: 'Max',
    age: 30,
    hobbies: ['Sports', 'Cooking'],
    role: Role.ADMIN
};

console.log(person.name);
if (person.role === Role.ADMIN){
    console.log('is admin')
}
if (person.role === Role.AUTHOR){
    console.log('is author')
}
if (person.role === Role.READ_ONLY){
    console.log('is reader')
}

let favoriteActivities: string[];
favoriteActivities = ['Sports'];