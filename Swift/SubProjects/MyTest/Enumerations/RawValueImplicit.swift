
import Foundation

enum NewPlanet: Int {
    case mercury = 1, venus, earth, mars, jupiter, saturn, uranus, neptune
}

enum NewCompassPoint: String {
    case north, south, east, west
}

func implicitRawValuesSample(){
    let earthsOrder = NewPlanet.earth.rawValue
    // earthsOrder is 3


    let sunsetDirection = NewCompassPoint.west.rawValue
    // sunsetDirection is "west"
    
    let possiblePlanet = NewPlanet(rawValue: 7)
    // possiblePlanet is of type Planet? and equals Planet.uranus
    
    let positionToFind = 11
    if let somePlanet = NewPlanet(rawValue: positionToFind) {
        switch somePlanet {
        case .earth:
            print("Mostly harmless")
        default:
            print("Not a safe place for humans")
        }
    } else {
        print("There isn't a planet at position \(positionToFind)")
    }
    // Prints "There isn't a planet at position 11"
}
