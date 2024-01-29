ConstrainedBox( 
  constraints: BoxConstraints.expand(),
  child: const Card(
    child: const Text('Hello World!'), 
    color: Colors.yellow,
  ), 
),


// .expand

ConstrainedBox(
  constraints: BoxConstraints.expand(height: 300),
  child: const Card(
    child: const Text('Hello World!'), 
    color: Colors.yellow,
  ),
),


// Same as

ConstrainedBox(
  constraints: BoxConstraints(
    minWidth: double.infinity,
    maxWidth: double.infinity,
    minHeight: 300,
    maxHeight: 300,
  ),
  child: const Card(
    child: const Text('Hello World!'), 
    color: Colors.yellow,
  ),
),