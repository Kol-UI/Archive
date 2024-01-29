Scaffold(
  appBar: AppBar(title: Text('SliverFillRemaining')),
  body: CustomScrollView(
    slivers: [
      SliverList(
        delegate: SliverChildListDelegate(const [
          ListTile(title: Text('First item')),
          ListTile(title: Text('Second item')),
          ListTile(title: Text('Third item')),
          ListTile(title: Text('Fourth item')),
        ]),
      ),
      SliverFillRemaining(
        hasScrollBody: false,
        child: Container(
          color: Colors.yellowAccent,
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
      ),
    ],
  ),
);