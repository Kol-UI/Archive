void stringPropertiesMain() { 
  String str = "Hello World"; 
  print("$str Code Units : ${str.codeUnits}"); 
  print("Is $str empty ? ${str.isEmpty}");
  print("The length of $str is: ${str.length}");
  print("$str in lower case : ${str.toLowerCase()}");
  print("$str in upper case : ${str.toUpperCase()}");
  String strWithSpace = " $str ";
  print("'$strWithSpace' trim : '${strWithSpace.trim()}'");
  
  var test = str.compareTo(strWithSpace);
  var test2 = str.compareTo(strWithSpace.trim());
  if (test == 0){
    print("'$str' and '$strWithSpace' are the same."); 
  }
  else {
    print("'$str' and '$strWithSpace' are different."); 
  }
  if (test2 == 0){
    print("'$str' and '${strWithSpace.trim()}' (trim) are the same."); 
  }
  else {
    print("'$str' and '${strWithSpace.trim()}' (trim) are different."); 
  }

  String str2 = str; 
  print("New String: ${str2.replaceAll('World','Everyone')}"); 

  String str3 = "Today, is, Thursday"; 
  print("Split: ${str3.split(',')}");

  String str4 = str; 
  print("Substring 6: ${str4.substring(6)}"); 
  print("Substring 2 - 6: ${str4.substring(2,6)}");

  int stringLength = str.length;
  int total = 0;
  for(var i = 0; i < stringLength; i++){
    total += (str.codeUnitAt(i));
  }
  print("Code Unit of index 0 (H): ${str.codeUnitAt(0)}");
  print("Total Code Unit '$str' : $total");
} 