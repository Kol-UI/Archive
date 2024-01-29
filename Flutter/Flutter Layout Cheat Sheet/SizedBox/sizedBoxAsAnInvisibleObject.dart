Widget build(BuildContext context) {
  bool isVisible = ...
  return Scaffold(
    appBar: AppBar(
      title: Text('isVisible = $isVisible'),
    ),
    body: isVisible 
      ? Icon(Icons.star, size: 150) 
      : const SizedBox(),
  );
}