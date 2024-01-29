Widget build(BuildContext context) {
  return Material(
    color: Colors.blue,
    child: SafeArea(
      child: SizedBox.expand(
        child: Card(color: Colors.yellowAccent),
      ),
    ),
  );
}