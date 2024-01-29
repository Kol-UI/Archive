Scaffold(
  appBar: AppBar(title: Text('borderRadius: BorderRadius')),
  body: Center(
    child: Container(
      height: 200,
      width: 200,
      decoration: BoxDecoration(
        color: Colors.yellow,
        border: Border.all(color: Colors.black, width: 3),
        borderRadius: BorderRadius.all(Radius.circular(18)),
      ),
    ),
  ),
);