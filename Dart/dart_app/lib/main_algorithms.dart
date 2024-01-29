import 'dart:io';

import 'package:dart_app/algorithms/fizz_buzz.dart';

import 'algorithms/decimal_to_binary.dart';
import 'algorithms/sorted_squared_array.dart';
import 'algorithms/n_queen.dart';
import 'algorithms/roman_to_int.dart';
import 'algorithms/int_to_roman.dart';
import 'algorithms/validate_subsequence.dart';

void algoMain(){

  print("--- Algorithms Menu ---");
  print("1) Sorted Squared Array  2) N-Queen  3) Decimal to Binary  4) Roman to Int  5) Int to Roman  6) FizzBuzz  7) Validate Subsequence");
  int? menu = int.parse(stdin.readLineSync()!);
  switch(menu){
    case 1: {
      algorithmSortedSquaredArray();
    }
    break;
    case 2: {
      nQueen();
    }
    break;
    case 3: {
      algorithmDecimalToBinary();
    }
    break;
    case 4: {
      algorithmRomanToInt();
    }
    break;
    case 5: {
      algorithmIntToRoman();
    }
    break;
    case 6: {
      fizzBuzz();
    }
    break;
    case 7: {
      algorithmValidateSubsequence();
    }
    break;
    default: { 
      print("Invalid choice"); 
   }
   break; 
  }
}

void algorithmSortedSquaredArray(){
  print("");
  print("-- Sorted Squared Array --");
  var a = [1, 2, 3, 4, 5, 6, 7];
  var b = [1, 4, 9, 16, 25, 36, 49];
  var c = [10, 104, 39, 3216, 1225, 326, 419];
  var d = [0];
  var e = [-7, -6, -5, -4, -3, -2, -1];
  var f = [-1, -1, 2, 3, 3, 3, 4, 1, 1, 0, 4, 9, 9, 9, 16];
  var g = [0, for (var i in a) i, for (var j in b) j, for (var k in c) k, for (var l in d) l, for (var m in e) m, for (var n in f) n];

  print("");
  print("Classic Arrays");
  print("Original Array: $a");
  sortedSquaredArray(a);

  print("");
  print("Original Array: $b");
  sortedSquaredArray(b);

  print("");
  print("With Higher Numbers");
  print("Original Array: $c");
  sortedSquaredArray(c);

  print("");
  print("With Zero");
  print("Original Array: $d");
  sortedSquaredArray(d);

  print("");
  print("With Negative");
  print("Original Array: $e");
  sortedSquaredArray(e);

  print("");
  print("With a Bit of Everything"); 
  print("Original Array: $f");
  sortedSquaredArray(f);

  print("");
  print("With All at Once"); 
  print("Original Array: $g");
  sortedSquaredArray(g);
}


void nQueen(){
  print("");
  print("-- N-Queen --");
  print("");
  print("Case 1:");
  resetBoard(1);
  solveNQueen(0, 1);

  print("");
  print("Case 2:");
  resetBoard(2);
  solveNQueen(0, 2);

  print("");
  print("Case 3:");
  resetBoard(3);
  solveNQueen(0, 3);

  print("");
  print("Case 4:");
  resetBoard(4);
  solveNQueen(0, 4);

  print("");
  print("Case 5:");
  resetBoard(5);
  solveNQueen(0, 5);

  print("");
  print("Case 6:");
  resetBoard(6);
  solveNQueen(0, 6);

  print("");
  print("Case 7:");
  resetBoard(7);
  solveNQueen(0, 7);

  print("");
  print("Case 8:");
  resetBoard(8);
  solveNQueen(0, 8);

  print("");
  print("Case 9:");
  resetBoard(9);
  solveNQueen(0, 9);

  print("");
  print("Case 10:");
  resetBoard(10);
  solveNQueen(0, 10);
}

void algorithmDecimalToBinary() {
  print("");
  print("-- Decimal to Binary --");
  stdout.write("Give a Decimal to convert: ");
  int? userInt = int.parse(stdin.readLineSync()!);
  bitwiseConversion(userInt);
}

void algorithmRomanToInt(){
  print("");
  print("-- Roman to Int --");
  print("Here are some examples :");
  var listRoman = ['I', 'II', 'V', 'X', 'L', 'C', 'D', 'M', 'XV', 'XI', 'XII', 'LII', 'VI', 'DLVII', 'IV', 'CLXV', 'IC',
  'MDIC', 'LII', 'LVI'];
  for (var r = 0; r < listRoman.length; r++){
    print("Roman to convert: ${listRoman[r]}");
    romanToInteger(listRoman[r]);
    print("");
  }
  stdout.write("Give a Roman Number to convert: ");
  String? userRoman = stdin.readLineSync();
  romanToInteger(userRoman);
}

void algorithmIntToRoman(){
  print("");
  print("-- Int To Roman --");
  integerToRoman(2);
  integerToRoman(4);
  integerToRoman(1000);
  integerToRoman(900);
  integerToRoman(500);
  integerToRoman(400);
  integerToRoman(100);
  integerToRoman(90);
  integerToRoman(50);
  integerToRoman(40);
  integerToRoman(10);
  integerToRoman(9);
  integerToRoman(5);
  integerToRoman(74);
  integerToRoman(1998);
  integerToRoman(23);
  integerToRoman(3);

  print("");
  stdout.write("Give a Int Number to convert: ");
  String? s = stdin.readLineSync();
  if (s != null){
    int n = int.parse(s);
    integerToRoman(n); 
  }
  
}


void algorithmValidateSubsequence() {
  List<int> array;
  List<int> sequence;
  print("");
  print("-- Validate Subsequence --");

  print("");
  print('- Test 1 -');
  array = [5, 1, 22, 25, 6, -1, 8, 10];
  stdout.write('Array :');
  for (var values in array) { 
    stdout.write(' $values'); 
  }
  sequence = [1, 6, -1, 10];
  stdout.write('Sequence :');
  for (var values in sequence) { 
    stdout.write(' $values'); 
  }
  checkIsSubSequence(array, sequence);
  print("");

  print("");
  print('- Test 2 -');
  array = [5, 1, 22, 25, 6, -1, 8, 10];
  stdout.write('Array :');
  for (var values in array) { 
    stdout.write(' $values'); 
  }
  sequence = [5, -1, 8, 10];
  stdout.write('Sequence :');
  for (var values in sequence) { 
    stdout.write(' $values'); 
  }
  checkIsSubSequence(array, sequence);
  print("");

  print("");
  print('- Test 3 -');
  array = [1, 1, 1, 1, 1];
  stdout.write('Array :');
  for (var values in array) { 
    stdout.write(' $values'); 
  }
  sequence = [0, 0, 0, 0];
  stdout.write('Sequence :');
  for (var values in sequence) { 
    stdout.write(' $values'); 
  }
  checkIsSubSequence(array, sequence);
  print("");

  print("");
  print('- Test 4 -');
  array = [1, 6, -1, 10];
  stdout.write('Array :');
  for (var values in array) { 
    stdout.write(' $values'); 
  }
  sequence = [1, 6, -1, 10];
  stdout.write('Sequence :');
  for (var values in sequence) { 
    stdout.write(' $values'); 
  }
  checkIsSubSequence(array, sequence);
  print("");

  print("");
  print('- Test 5 -');
  array = [1, 1, 6, 1];
  stdout.write('Array :');
  for (var values in array) { 
    stdout.write(' $values'); 
  }
  sequence = [0];
  stdout.write('Sequence :');
  for (var values in sequence) { 
    stdout.write(' $values'); 
  }
  checkIsSubSequence(array, sequence);
  print("");

  print("");
  print('- Test 6 -');
  array = [];
  stdout.write('Array :');
  for (var values in array) { 
    stdout.write(' $values'); 
  }
  sequence = [0];
  stdout.write('Sequence :');
  for (var values in sequence) { 
    stdout.write(' $values'); 
  }
  checkIsSubSequence(array, sequence);
  print("");

  print("");
  print('- Test 7 -');
  array = [1, 1, 6, 1];
  stdout.write('Array :');
  for (var values in array) { 
    stdout.write(' $values'); 
  }
  sequence = [];
  stdout.write('Sequence :');
  for (var values in sequence) { 
    stdout.write(' $values'); 
  }
  checkIsSubSequence(array, sequence);
  print("");

  }

