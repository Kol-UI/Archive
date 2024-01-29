import 'dart:math';

class Point {
  final double x;
  final double y;
  double distanceFromOrigin;

  Point(double x, double y)
      : x = x,
        y = y,
        distanceFromOrigin = sqrt(x * x + y * y);
}