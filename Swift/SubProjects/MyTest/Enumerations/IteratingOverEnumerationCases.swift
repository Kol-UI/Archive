
import Foundation


func iteratingOverEnum(){
    let numberOfChoices = Beverage.allCases.count
    print("\(numberOfChoices) beverages available")
    // Prints "3 beverages available"
    
    for beverage in Beverage.allCases {
        print(beverage)
    }
    // coffee
    // tea
    // juice
}

