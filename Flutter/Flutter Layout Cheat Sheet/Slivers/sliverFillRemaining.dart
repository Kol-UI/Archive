Scaffold(
  appBar: AppBar(title: Text('SliverFillRemaining')),
  body: CustomScrollView(
    slivers: [
      SliverFillRemaining(
        hasScrollBody: false,
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: const [
            FlutterLogo(size: 200),
            Text(
              'This is some longest text that should be centered'
              'together with the logo',
              textAlign: TextAlign.center,
            ),
          ],
        ),
      ),
    ],
  ),
);