Row(
  children: <Widget>[
    Expanded(
      child: Container(
        decoration: const BoxDecoration(color: Colors.red),
      ),
      flex: 3,
    ),
    Expanded(
      child: Container(
        decoration: const BoxDecoration(color: Colors.green),
      ),
      flex: 2,
    ),
    Expanded(
      child: Container(
        decoration: const BoxDecoration(color: Colors.blue),
      ),
      flex: 1,
    ),
  ],
),