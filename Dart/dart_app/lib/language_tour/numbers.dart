void numbersMain(){
  print("");
  print("--- Numbers ---");
  var numbersList = [1, 1000, 5000, 12, 4, 0, -8, 100, 10, -10, -12, 17, 19, 20, 22, -2, 75, -35];
  var numbersList2 = [1.3, 7.4, 9.9, 4.2, 2.123];
  var numbersList3 = List.from(numbersList)..addAll(numbersList2);

  intAndDouble();
  parsing();

  print("");
  print("--- Get Hashcode ---");
  for(var i = 0; i< numbersList.length; i++){
    getHashcode(numbersList[i]);
  }

  print("");
  print("--- Is Finite ---");
  for(var i = 0; i< numbersList.length; i++){
    knowIsFinite(numbersList[i]);
  }

  print("");
  print("--- Is InFinite ---");
  for(var i = 0; i< numbersList.length; i++){
    knowIsInFinite(numbersList[i]);
  }

  print("");
  print("--- Is Negative ---");
  for(var i = 0; i< numbersList.length; i++){
    knowIsNegative(numbersList[i]);
  }

  print("");
  print("--- Is Even ---");
  for(var i = 0; i< numbersList.length; i++){
    knowIsEven(numbersList[i]);
  }

  print("");
  print("--- Is Odd ---");
  for(var i = 0; i< numbersList.length; i++){
    knowIsOdd(numbersList[i]);
  }

  print("");
  print("--- Get Absolute ---");
  for(var i = 0; i< numbersList.length; i++){
    getAbsolute(numbersList[i]);
  }

  print("");
  print("--- Get Ceiling ---");
  for(var i = 0; i< numbersList2.length; i++){
    getCeiling(numbersList2[i]);
  }

  compareTo();

  print("");
  print("--- Get Floor ---");
  for(var i = 0; i< numbersList2.length; i++){
    getFloor(numbersList2[i]);
  }

  print("");
  print("--- Get Remainder ---");
  getRemainder();

  print("");
  print("--- Round ---");
  toRound();

  print("");
  print("--- To Double ---");
  for(var i = 0; i< numbersList.length; i++){
    toDoubleFunc(numbersList[i]);
  }

  print("");
  print("--- To Int ---");
  for(var i = 0; i< numbersList2.length; i++){
    toIntFunc(numbersList2[i]);
  }

  print("");
  print("--- To String ---");
  toStringFunc();

  print("");
  print("--- Get Truncated Value ---");
  for(var i = 0; i< numbersList3.length; i++){
    getTruncatedValue(numbersList3[i]);
  }

  print("");
  print("--- Sign ---");
  for(var i = 0; i< numbersList3.length; i++){
    knowSign(numbersList3[i]);
  }

}

void intAndDouble(){
  print("");
  print("--- Int & Double ---");
  int num1 = 10;             
  double num2 = 10.50;
  print("$num1 is a int.");
  print("$num2 is a double.");
}

void parsing(){
  print("");
  print("--- Int & Double Parsing ---");
  print(num.parse('12')); 
  print(num.parse('10.91'));
}

void getHashcode(int n){
  print(n.hashCode); 
}

void knowIsFinite(int n){
  print("Is $n finite ? ${n.isFinite}");
}

void knowIsInFinite(int n){
  print("Is $n infinite ? ${n.isInfinite}");
}

void knowIsNegative(int n){
  print("Is $n negative ? ${n.isNegative}");
}

void knowIsEven(int n){
  print("Is $n even number ? ${n.isEven}");
}

void knowIsOdd(int n){
  print("Is $n odd number ? ${n.isOdd}");
}

void getAbsolute(int n){
  print("$n Absolute: ${n.abs()}");
}

void getCeiling(double n){
  print("The ceiling value of $n = ${n.ceil()}"); 
}

void compareTo(){
  print("");
  print("--- Compare To ---");
  var a = 2.4; 
  print(a.compareTo(12)); 
  print(a.compareTo(2.4)); 
  print(a.compareTo(0)); 
}

void getFloor(double n){
  print("The floor value of $n = ${n.floor()}"); 
}

void getRemainder(){
  var a = 10; 
  var b = 17; 
  var c = 2;
  print("The remainder of $a and $c is egal to ${a.remainder(c)}"); 
  print("The remainder of $b and $c is egal to ${b.remainder(c)}"); 
}

void toRound(){
  double n1 = 12.023; 
  double n2 = 12.89; 
  
  var value = n1.round(); 
  print("The round value of $n1 is $value."); 
  
  value = n2.round(); 
  print("The round value of $n2 is $value."); 
}

void toDoubleFunc(int n){ 
  var value = n.toDouble(); 
  print("Double of $n = $value");
}

void toIntFunc(double n){
  var value = n.toInt(); 
  print("Int of $n = $value");
}

void toStringFunc(){
  int n1 = 2;   
  var value = n1.toString();
  // ignore: unnecessary_type_check
  print("is $n1 a string now ? ${value is String}");
}

void getTruncatedValue(var n){
  var value = n.truncate(); 
  print("The truncated value of $n = $value"); 
}

void knowSign(var n){
  print("");
  print("What is $n's sign ? ${n.sign}");
  switch(n.sign){
    case 1: {  
      print("$n's sign is positive !"); 
      } 
    break;
    case -1: {  
      print("$n's sign is negative !"); 
      } 
    break;
    case 0: {  
      print("$n is egal to zero !"); 
      } 
    break;
    default: {  
      print("$n is Infinite, Null or Unknown !"); 
      } 
    break;
  }
}