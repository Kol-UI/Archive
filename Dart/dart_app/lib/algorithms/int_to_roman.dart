import 'dart:io';

import 'package:dart_app/algorithms/roman_to_int.dart';

List<int> arabianRomanNumbers = [
  1000,
  900,
  500,
  400,
  100,
  90,
  50,
  40,
  10,
  9,
  5,
  4,
  1
];

List<String> romanNumbers = [
  "M",
  "CM",
  "D",
  "CD",
  "C",
  "XC",
  "L",
  "XL",
  "X",
  "IX",
  "V",
  "IV",
  "I"
];

List<String>? integerToRoman(int num) {
  if (num < 0) {
    return null;
  }
  print("");
  print("The Int Value :");
  print(num);
  print("The Roman Value :");

  List<String> result = [];
  for (int i = 0; i < arabianRomanNumbers.length; i++) {
    int times = num ~/ arabianRomanNumbers[i];
    for (int j = 0; j < times; j++) {
      stdout.write(romanNumbers[i]);
    }
    num -= times * arabianRomanNumbers[i];
  }

  
  return result;
}