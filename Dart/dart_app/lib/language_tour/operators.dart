void operators(){
  print("--- Operators ---");
  const a = 10;
  const b = 25;
  printValues(a, b);
  addition(a, b);
  subtract(a, b);
  multiply(a, b);
  divide(a, b);
  modulo(a, b);
  increment(a, b);
  decrement(a, b);
  greaterThan(a, b);
  lowerThan(a, b);
  nullAssignement();
  otherAssignmentOperators();
  equalityAndRelationalOperators();
  typeTestOperator();
  biteWiseOperator();
  logicalOperators();
}

void printValues(int a, int b){
  print("Values are : a = $a & b = $b");
}

void addition(int a, int b){
  print("");
  print("--- Addition ---");
  print("$a + $b = ${a+b}");
}

void subtract(int a, int b){
  print("");
  print("--- Subtract ---");
  print("$a - $b = ${a-b}");
}

void multiply(int a, int b){
  print("");
  print("--- Multiply ---");
  print("$a * $b = ${a*b}");
}

void divide(int a, int b){
  print("");
  print("--- Divide ---");
  print("$a / $b = ${a/b}");
}

void modulo(int a, int b){
  print("");
  print("--- Modulo ---");
  int c = (a * b) * 2;
  print("c = ($a * $b)*2 = $c");
  print("$b % $c = ${b%c}");
}

void increment(int a, int b){
  print("");
  print("--- Increment ---");
  a++;
  b++;
  print("a++ = $a");
  print("b++ = $b");
}

void decrement(int a, int b){
  print("");
  print("--- Decrement ---");
  a--;
  b--;
  print("a-- = $a");
  print("b-- = $b");
}

void greaterThan(int a, int b){
  print("");
  print("--- Greater Than ---");
  print("Is b > a ?");
  if (b > a){
    print("Yes, $b > $a ");
  } else{
    print("No, $b < $a ");
  }
}

void lowerThan(int a, int b){
  print("");
  print("--- Lower Than ---");
  print("Is a < b ?");
  if (a < b){
    print("Yes, $a < $b ");
  } else{
    print("No, $a > $b ");
  }
}

void nullAssignement(){
  print("");
  print("--- Null Assignement ---");
  // ignore: prefer_typing_uninitialized_variables
  var a; 
  var b = 12; 
  print("Values are : a = $a & b = $b");
  print("res = a ?? b");
  var res = a ?? b;
  print("res = $res");
}

void otherAssignmentOperators(){
  print("");
  print("--- Other Assignement ---");
  var a = 12; 
  var b = 3; 
    
  a+=b; 
  print("a+=b : $a"); 
    
  a = 12;
  b = 13; 
  a-=b; 
  print("a-=b : $a"); 
    
  a = 12;
  b = 13; 
  a*=b; 
  print("a*=b' : $a"); 
    
  double c = 12;
  double d = 13; 
  c/=d;
  print("a/=b : $a"); 
    
  a = 12;
  b = 13; 
  a%=b; 
  print("a%=b : $a");
}

void equalityAndRelationalOperators(){
  print("");
  print("--- Equality And Relational ---");
  var num1 = 5; 
   var num2 = 9; 
   var res = num1>num2; 
   print('num1 greater than num2 ::  $res'); 
   
   res = num1<num2; 
   print('num1 lesser than  num2 ::  $res'); 
   
   res = num1 >= num2; 
   print('num1 greater than or equal to num2 ::  $res'); 
   
   res = num1 <= num2; 
   print('num1 lesser than or equal to num2  ::  $res'); 
   
   res = num1 != num2; 
   print('num1 not equal to num2 ::  $res'); 
   
   res = num1 == num2; 
   print('num1 equal to num2 ::  $res'); 
}

void typeTestOperator(){
  print("");
  print("--- Type Test ---");
  double  n = 2.20; 
  var num = n is! int; 
  print('Is $n not an int ? $num');
  var num2 = n is String; 
  print('Is $n a string ? $num2');
  // ignore: unnecessary_type_check
  var num3 = n is double; 
  print('Is $n a double ? $num3');
}

void biteWiseOperator(){
  print("");
  print("--- Bite Wise ---");
  var a = 2;  // Bit presentation 10 
  var b = 3;  // Bit presentation 11 
  
  var result = (a & b); 
  print("(a & b) => $result");    
  result = (a | b); 
  print("(a | b) => $result");
  result = (a ^ b); 
  print("(a ^ b) => $result"); 
  
  result = (~b); 
  print("(~b) => $result");  
  
  //result = (a < b) as int; 
  //print("(a < b) => $result"); 
  
  //result = (a > b); 
  //print("(a > b) => $result");
}

void logicalOperators(){
  print("");
  print("--- Logical Operators ---");
  var a = 10; 
  var b = 12; 
  var res = (a<b)&&(b>10); 
  print(res);
  var c = 10; 
  var d = 12; 
  var res2 = (c>d)||(d<10); 
  
  print(res2);  
  var res3 =!(c==d); 
  print(res2);
}