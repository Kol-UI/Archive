Scaffold(
  appBar: AppBar(title: Text('image: DecorationImage')),
  body: Center(
    child: Container(
      height: 200,
      width: 200,
      decoration: BoxDecoration(
        color: Colors.yellow,
        image: DecorationImage(
          fit: BoxFit.fitWidth,
          image: NetworkImage(
            'https://flutter.io/images/catalog-widget-placeholder.png',
          ),
        ),
      ),
    ),
  ),
);