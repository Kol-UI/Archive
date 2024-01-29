Widget build(BuildContext context) {
  const iconSize = 50;
  return Scaffold(
    appBar: AppBar(title: Text('Stack with LayoutBuilder')),
    body: LayoutBuilder(
      builder: (context, constraints) =>
        Stack(
          fit: StackFit.expand,
          children: <Widget>[
            Material(color: Colors.yellowAccent),
            Positioned(
              top: 0,
              child: Icon(Icons.star, size: iconSize),
            ),
            Positioned(
              top: constraints.maxHeight - iconSize,
              left: constraints.maxWidth - iconSize,
              child: Icon(Icons.call, size: iconSize),
            ),
          ],
        ),
    ),
  );
}
