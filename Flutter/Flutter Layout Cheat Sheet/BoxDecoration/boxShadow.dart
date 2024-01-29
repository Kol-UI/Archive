Scaffold(
  appBar: AppBar(title: Text('boxShadow: List<BoxShadow>')),
  body: Center(
    child: Container(
      height: 200,
      width: 200,
      decoration: BoxDecoration(
        color: Colors.yellow,
        boxShadow: const [
          BoxShadow(blurRadius: 10),
        ],
      ),
    ),
  ),
);