
import Foundation

enum SomeEnumeration {
    // enumeration definition goes here
    // See CompassPoint, Planet
}

func useEnums(){
    var directionToHead = CompassPoint.west
    directionToHead = .east
    print (directionToHead)
}
