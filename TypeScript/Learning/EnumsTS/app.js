//const ADMIN = 0;
//const READ_ONLY = 1;
//const AUTHOR = 2;
var Role;
(function (Role) {
    Role[Role["ADMIN"] = 0] = "ADMIN";
    Role[Role["READ_ONLY"] = 1] = "READ_ONLY";
    Role[Role["AUTHOR"] = 2] = "AUTHOR";
})(Role || (Role = {}));
;
var person = {
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
if (person.role === Role.ADMIN) {
    console.log('is admin');
}
if (person.role === Role.AUTHOR) {
    console.log('is author');
}
if (person.role === Role.READ_ONLY) {
    console.log('is reader');
}
