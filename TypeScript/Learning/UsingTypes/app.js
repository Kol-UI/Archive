function add(n1, n2, n3, showResult, phrase) {
    //if (typeof n1 === 'number' && typeof n2 === 'number'){
    //    throw new Error('Incorrect input!');
    //}
    var result = n1 + n2;
    n3 = 11;
    if (showResult) {
        console.log(phrase + result);
    }
    else {
        return result;
    }
    return result;
}
var number1 = 5;
var number2 = 2.8;
var number3;
number3 = 10;
var printResult = true;
var resultPhrase = 'Result is: ';
//const result = add(number1, number2, printResult);
//console.log(result);
add(number1, number2, number3, printResult, resultPhrase);
