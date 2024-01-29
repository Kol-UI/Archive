void loops(){
  print("");
  print("--- Loops ---");
  simpleLoop1();
  forInLoop();
  whileLoop();
  doWhileLoop();
  breakStatement();
  continueStatement();
  labelWithBreak();
  labelWithContinue();
}

void simpleLoop1(){
  print("");
  var num = 5; 
   var factorial = 1; 
   
   for( var i = num ; i >= 1; i-- ) { 
      factorial *= i ; 
   } 
   print(factorial);
}

void forInLoop(){
  print("");
  var obj = [12,13,14,16,18]; 
   
   for (var prop in obj) { 
      print(prop); 
   } 
}

void whileLoop(){
  print("");
  print("--- While Loop ---");
  var num = 5; 
  var factorial = 1; 
  
  while(num >=1) { 
    factorial = factorial * num; 
    num--; 
  } 
  print("The factorial  is $factorial"); 
}

void doWhileLoop(){
  print("");
  print("--- Do While Loop ---");
  var n = 10; 
  do { 
    print(n); 
    n--; 
  }
  while(n>=0);
}

void breakStatement(){
  print("");
  print("--- Break Statement ---");
  var i = 1; 
  while(i<=10) { 
    if (i % 5 == 0) { 
        print("The first multiple of 5  between 1 and 10 is : $i"); 
        break ;    
    } 
    i++; 
  }
}

void continueStatement(){
  print("");
  print("--- Continue Statement ---");
  var num = 0; 
  var count = 0; 
  
  for(num = 0;num<=20;num++) { 
    if (num % 2==0) { 
        continue; 
    } 
    count++; 
  } 
  print(" The count of odd values between 0 and 20 is: $count");
}

void labelWithBreak(){
  print("");
  print("--- Label With Break ---");
  outerloop:
   
  for (var i = 0; i < 5; i++) { 
    print("Innerloop: $i"); 
    innerloop: 
    
    for (var j = 0; j < 5; j++) { 
        if (j > 3 ) break ; 
        
        if (i == 2) break innerloop; 
        
        if (i == 4) break outerloop; 
        
        print("Innerloop: $j"); 
    } 
  } 
}

void labelWithContinue(){
  print("");
  print("--- Label With Continue ---");
  outerloop: 
   
  for (var i = 0; i < 3; i++) { 
    print("Outerloop:$i"); 
    
    for (var j = 0; j < 5; j++) { 
        if (j == 3){ 
          continue outerloop; 
        } 
        print("Innerloop:$j"); 
    } 
  } 
}