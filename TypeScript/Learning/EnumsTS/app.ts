//const ADMIN = 0;
//const READ_ONLY = 1;
//const AUTHOR = 2;

enum Role { ADMIN = 5, READ_ONLY, AUTHOR }; // Other are 6 and 7 instead of 0, 1 & 2

const person = {
    name: 'Maxime',
    nickname: 'Max',
    age: 30,
    hobbies: ['Sports', 'Cooking'],
    role: Role.ADMIN
    //role: ADMIN
};

console.log(person.name);


//person.role.push('admin');
//person.role[1] = 100;
//person.role = [0, 'admin'];

if (person.role === Role.ADMIN){
    console.log('is admin')
}
if (person.role === Role.AUTHOR){
    console.log('is author')
}
if (person.role === Role.READ_ONLY){
    console.log('is reader')
}