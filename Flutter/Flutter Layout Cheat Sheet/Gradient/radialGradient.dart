Scaffold(
  appBar: AppBar(title: Text('gradient: RadialGradient')),
  body: Center(
    child: Container(
      height: 200,
      width: 200,
      decoration: BoxDecoration(
        gradient: RadialGradient(
          colors: const [Colors.yellow, Colors.blue],
          stops: const [0.4, 1.0],
        ),
      ),
    ),
  ),
);