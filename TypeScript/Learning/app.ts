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

// Returns Never
function generateError(message: string, code: number): never {
    throw {message: message, errorCode: code};
    // while(true){}
}

generateError('An Error occurred !', 500);
// const result = generateError('An Error occurred !', 500);
// console.log(result);