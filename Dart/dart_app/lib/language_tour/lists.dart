void listsMain(){
  var mainList = [];
  String hello = "Hello World";
  int stringLength = hello.length;
  int toAdd = 0;
  for(var i = 0; i < stringLength; i++){
    toAdd = (hello.codeUnitAt(i));
    mainList.add(toAdd); 
  }

  mainList.add(12); 
  mainList.add(13); 
  print(mainList);

  print("The first element of the list is: ${mainList.first}");
  print("The last element of the list is: ${mainList.last}");
  print("Is the list empty? ${mainList.isEmpty}");
  print("Is the list not empty? ${mainList.isNotEmpty}");
  print("The length of the list is egal to ${mainList.length}");
  print("The list values in reverse order: ${mainList.reversed}"); 

  var lst = []; 
  lst.add(12);
  print("The list has only one element: ${lst.single}");

  mainList.addAll([209, 23]);
  print(mainList);

  mainList.insert(0,4);
  print("Inserting '4' at position zero.");
  print(mainList);

  var numbersList = [1, 1000, 5000, 12, 4, 0, -8, 100, 10, -10, -12, 17, 19, 20, 22, -2, 75, -35];
  var numbersList2 = [1.3, 7.4, 9.9, 4.2, 2.123];

  mainList.insertAll(0, numbersList);
  print("Inserting int list at position zero.");
  print(mainList);
  mainList.insertAll(mainList.length, numbersList2);
  print("Inserting double list at the end.");
  print(mainList);

  List l = [1, 2, 3, 4, 5, 6, 7, 8, 9];
  print('The value of list before replacing $l');
  l.replaceRange(0,3,[11,23,24]);
  print('The value of list after replacing the items between the range [0-3] is $l');

  var things = [2, null, 3];
  var more = [1, ...things, 4]; // [1, 2, null, 3, 4]
  var also = [1, ...things, 4]; // [1, 2, null, 3, 4]
  var before = [1, ...more, 3];
  print(more);
  print(also);
  print(before);
  
  bool promoActive1 = false;
  bool promoActive2 = true;
  // ignore: dead_code
  var nav = ['Home', 'Furniture', 'Plants', if (promoActive1) 'Outlet', if (promoActive2) 'Food'];
  print(nav);

  var listOfInts = [1, 2, 3];
  var listOfStrings = ['#0', for (var i in listOfInts) '#$i'];
  assert(listOfStrings[1] == '#1');
  print(listOfInts);
  print(listOfStrings);

  print("Create an empty list of strings");
  var grains = <String>[];
  assert(grains.isEmpty);
  print(grains);

  print("Create a list using a list literal.");
  var fruits = ['apples', 'oranges'];
  print(fruits);

  print("Add to a list.");
  fruits.add('kiwis');
  print(fruits);

  print("Add multiple items to a list.");
  fruits.addAll(['grapes', 'bananas']);
  print(fruits);

  print("Get the list length.");
  assert(fruits.length == 5);
  print(fruits.length);

  print("Remove a single item.");
  print(fruits);
  var appleIndex = fruits.indexOf('apples');
  fruits.removeAt(appleIndex);
  assert(fruits.length == 4);
  print(fruits);

  print("Remove all elements from a list.");
  fruits.clear();
  assert(fruits.isEmpty);
  print(fruits);

  print("Create a List using one of the constructors.");
  var vegetables = List.filled(10, 'broccoli');
  assert(vegetables.every((v) => v == 'broccoli'));
  print(vegetables);
}