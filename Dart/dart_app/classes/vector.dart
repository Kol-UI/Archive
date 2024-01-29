class Vector2d {
  final double x;
  final double y;

  Vector2d(this.x, this.y);
  Vector2d.named({required this.x, required this.y});
}

class Vector3d extends Vector2d {
  final double z;
  Vector3d(super.x, super.y, this.z);
  Vector3d.yzPlane({required super.y, required this.z}) : super.named(x: 0);
}