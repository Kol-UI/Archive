let userInput: unknown;
let userName: string;
let userInput2: any;

userInput = 5;
userInput = 'Test';
// Error
// userName = userInput;

userInput2 = 10;
userInput2 = 'Test 2';
userName = userInput2;

if (typeof userInput === 'string'){
    userName = userInput;
}