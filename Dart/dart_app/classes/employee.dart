class Person {
  String? firstName;

  Person.fromJson(Map data) {
    print('in Person');
  }
}

class Employee extends Person {
  Employee.fromJson(super.data) : super.fromJson() {
    print('in Employee');
  }
}