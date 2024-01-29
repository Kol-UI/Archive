

import Foundation

func accessingDictionary() -> String {
    var airports = ["YYZ": "Toronto Pearson", "DUB": "Dublin"]
    print("The airports dictionary contains \(airports.count) items.")
    // Prints "The airports dictionary contains 2 items."
    
    if airports.isEmpty {
        print("The airports dictionary is empty.")
    } else {
        print("The airports dictionary isn't empty.")
    }
    // Prints "The airports dictionary isn't empty."
    
    airports["LHR"] = "London"
    // the airports dictionary now contains 3 items
    
    airports["LHR"] = "London Heathrow"
    // the value for "LHR" has been changed to "London Heathrow"
    
    if let oldValue = airports.updateValue("Dublin Airport", forKey: "DUB") {
        print("The old value for DUB was \(oldValue).")
    }
    // Prints "The old value for DUB was Dublin."
    
    if let airportName = airports["DUB"] {
        print("The name of the airport is \(airportName).")
    } else {
        print("That airport isn't in the airports dictionary.")
    }
    // Prints "The name of the airport is Dublin Airport."
    
    airports["APL"] = "Apple International"
    // "Apple International" isn't the real airport for APL, so delete it
    airports["APL"] = nil
    // APL has now been removed from the dictionary
    
    if let removedValue = airports.removeValue(forKey: "DUB") {
        print("The removed airport's name is \(removedValue).")
    } else {
        print("The airports dictionary doesn't contain a value for DUB.")
    }
    // Prints "The removed airport's name is Dublin Airport."
    
    return "accessingDictionary done"
}
