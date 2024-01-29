class Car {
  late bool isRunning;

  Car(this.name, this.id, this.isElectric, this.distanceDone);  
  final String name;
  final bool isElectric;
  final int id;
  late int distanceDone;

  void start() {  
    isRunning = true;  
  }  
  void shutDown() { 
    isRunning = false;   
  }
  
}