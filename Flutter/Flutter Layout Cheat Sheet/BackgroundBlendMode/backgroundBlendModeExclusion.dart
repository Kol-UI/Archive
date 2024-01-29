Scaffold(
  appBar: AppBar(title: Text('backgroundBlendMode')),
  body: Center(
    child: Container(
      height: 200,
      width: 200,
      foregroundDecoration: BoxDecoration(
        backgroundBlendMode: BlendMode.exclusion,
        gradient: LinearGradient(
          colors: const [
            Colors.red,
            Colors.blue,
          ],
        ),
      ),
      child: Image.network(
        'https://flutter.io/images/catalog-widget-placeholder.png',
      ),
    ),
  ),
);