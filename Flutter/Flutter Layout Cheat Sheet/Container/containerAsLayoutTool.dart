// Child Size

Widget build(BuildContext context) {
  return Scaffold(
    appBar: AppBar(title: Text('Container as a layout')),
    body: Container(
      color: Colors.yellowAccent,
      child: Text("Hi"),
    ),
  );
}


// Infinity

Widget build(BuildContext context) {
  return Scaffold(
    appBar: AppBar(title: Text('Container as a layout')),
    body: Container(
      height: double.infinity,
      width: double.infinity,
      color: Colors.yellowAccent,
      child: Text("Hi"),
    ),
  );
}