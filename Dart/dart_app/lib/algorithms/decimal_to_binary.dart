import "dart:math" show pow;

void bitwiseConversion(var n) {
  int b = 0, c = 0, d;
  print("Bitwise conversion...");
  while (n != 0) {
    d = (n & 1);
    b += d * (pow(10, c++).toInt());
    n >>= 1;
  }
  print("Binary number: $b");
}