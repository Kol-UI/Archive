Widget build(BuildContext context) {
  return Scaffold(
    appBar: AppBar(title: Text('IntrinsicWidth')),
    body: Center(
      child: Column(
        children: <Widget>[
          RaisedButton(
            onPressed: () {},
            child: Text('Short'),
          ),
          RaisedButton(
            onPressed: () {},
            child: Text('A bit Longer'),
          ),
          RaisedButton(
            onPressed: () {},
            child: Text('The Longest text button'),
          ),
        ],
      ),
    ),
  );
}


// As wide as the widest

Widget build(BuildContext context) {
  return Scaffold(
    appBar: AppBar(title: Text('IntrinsicWidth')),
    body: Center(
      child: IntrinsicWidth(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: <Widget>[
            RaisedButton(
              onPressed: () {},
              child: Text('Short'),
            ),
            RaisedButton(
              onPressed: () {},
              child: Text('A bit Longer'),
            ),
            RaisedButton(
              onPressed: () {},
              child: Text('The Longest text button'),
            ),
          ],
        ),
      ),
    ),
  );
}