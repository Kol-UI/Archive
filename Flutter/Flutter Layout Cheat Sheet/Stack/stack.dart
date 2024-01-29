@override
Widget build(BuildContext context) {
  Widget main = Scaffold(
    appBar: AppBar(title: Text('Stack')),
  );

  return Stack(
    fit: StackFit.expand,
    children: <Widget>[
      main,
      Banner(
        message: "Top Start",
        location: BannerLocation.topStart,
      ),
      Banner(
        message: "Top End",
        location: BannerLocation.topEnd,
      ),
      Banner(
        message: "Bottom Start",
        location: BannerLocation.bottomStart,
      ),
      Banner(
        message: "Bottom End",
        location: BannerLocation.bottomEnd,
      ),
    ],
  );
}


// Positioned

Widget build(BuildContext context) {
  return Scaffold(
    appBar: AppBar(title: Text('Stack')),
    body: Stack(
      fit: StackFit.expand,
      children: <Widget>[
        Material(color: Colors.yellowAccent),
        Positioned(
          top: 0,
          left: 0,
          child: Icon(Icons.star, size: 50),
        ),
        Positioned(
          top: 340,
          left: 250,
          child: Icon(Icons.call, size: 50),
        ),
      ],
    ),
  );
}