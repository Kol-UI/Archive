Widget build(BuildContext context) {
  return Scaffold(
    appBar: AppBar(title: Text('Container.decoration')),
    body: Container(
      height: double.infinity,
      width: double.infinity,
      decoration: BoxDecoration(color: Colors.yellowAccent),
      child: Text("Hi"),
    ),
  );
}


// Foreground Decoration

Widget build(BuildContext context) {
  return Scaffold(
    appBar: AppBar(title: Text('Container.foregroundDecoration')),
    body: Container(
      height: double.infinity,
      width: double.infinity,
      decoration: BoxDecoration(color: Colors.yellowAccent),
      foregroundDecoration: BoxDecoration(
        color: Colors.red.withOpacity(0.5),
      ),
      child: Text("Hi"),
    ),
  );
}