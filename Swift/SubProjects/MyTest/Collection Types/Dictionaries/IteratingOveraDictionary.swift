
import Foundation

func iteratingDictionary() -> String {
    let airports = ["YYZ": "Toronto Pearson", "DUB": "Dublin"]
    
    var airportCodes = [String](airports.keys)
    // airportCodes is ["LHR", "YYZ"]

    var airportNames = [String](airports.values)
    // airportNames is ["London Heathrow", "Toronto Pearson"]
    
    for (airportCode, airportName) in airports {
        print("\(airportCode): \(airportName)")
    }
    // LHR: London Heathrow
    // YYZ: Toronto Pearson
    
    for (values1) in airportNames {
        print("\(values1)")
    }
    
    for (values2) in airportCodes{
        print("\(values2)")
    }
    
    for airportCode in airports.keys {
        print("Airport code: \(airportCode)")
    }
    // Airport code: LHR
    // Airport code: YYZ

    for airportName in airports.values {
        print("Airport name: \(airportName)")
    }
    // Airport name: London Heathrow
    // Airport name: Toronto Pearson
    
    return "iteratingDictionary Done"
}
