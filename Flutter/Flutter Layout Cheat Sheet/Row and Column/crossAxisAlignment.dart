Row(
  crossAxisAlignment: CrossAxisAlignment.baseline,
  textBaseline: TextBaseline.alphabetic,
  children: <Widget>[
    Text(
      'Baseline',
      style: Theme.of(context).textTheme.display3,
    ),
    Text(
      'Baseline',
      style: Theme.of(context).textTheme.body1,
    ),
  ],
),


// Start

Row /*or Column*/( 
  crossAxisAlignment: CrossAxisAlignment.start,
  children: <Widget>[
    Icon(Icons.star, size: 50),
    Icon(Icons.star, size: 200),
    Icon(Icons.star, size: 50),
  ],
),


// Center

Row /*or Column*/( 
  crossAxisAlignment: CrossAxisAlignment.center,
  children: <Widget>[
    Icon(Icons.star, size: 50),
    Icon(Icons.star, size: 200),
    Icon(Icons.star, size: 50),
  ],
),


// End

Row /*or Column*/( 
  crossAxisAlignment: CrossAxisAlignment.end,
  children: <Widget>[
    Icon(Icons.star, size: 50),
    Icon(Icons.star, size: 200),
    Icon(Icons.star, size: 50),
  ],
),


// Stretch

Row /*or Column*/( 
  crossAxisAlignment: CrossAxisAlignment.stretch,
  children: <Widget>[
    Icon(Icons.star, size: 50),
    Icon(Icons.star, size: 200),
    Icon(Icons.star, size: 50),
  ],
),

