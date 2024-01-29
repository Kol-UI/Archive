Widget build(BuildContext context) {
  return Scaffold(
    appBar: AppBar(title: Text('Align: without Align')),
    body: Column(
      crossAxisAlignment: CrossAxisAlignment.stretch,
      children: <Widget>[
        Align(
          child: RaisedButton(
            onPressed: () {},
            child: const Text('Button'),
          ),
        ),
      ],
    ),
  );
}