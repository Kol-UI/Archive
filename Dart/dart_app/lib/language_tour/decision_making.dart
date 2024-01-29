void decision(){
  print("");
  print("--- Decision Making ---");

  ifStatement();
  ifElseStatement();
  ifElseLadderStatement();
}

void ifStatement(){
  print("");
  print("--- If Statement ---");
  var num=5; 
  if (num>0) { 
    print("number is positive"); 
  } 
}

void ifElseStatement(){
  print("");
  print("--- If Else Statement ---");
  var num = 12; 
  if (num % 2==0) { 
    print("Even"); 
  } else { 
    print("Odd"); 
  } 
}

void ifElseLadderStatement(){
  print("");
  print("--- If Else Ladder Statement ---");
  int firstnumber = 4;
  int secondnumber = 0;
  int thirdnumber = -8;
  int fourthnumber = 100;
  ladderStatement(firstnumber);
  ladderStatement(secondnumber);
  ladderStatement(thirdnumber);
  ladderStatement(fourthnumber);
}

void ladderStatement(int number){
  if(number > 0) { 
    print("$number is positive"); 
  } 
  else if(number < 0) { 
    print("$number is negative"); 
  } else { 
    print("$number is neither positive nor negative"); 
  } 
}

