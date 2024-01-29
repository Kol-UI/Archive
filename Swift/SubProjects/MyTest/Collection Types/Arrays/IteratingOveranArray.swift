
import Foundation



func iteratingOverArray() -> String {
    var newShoppingList = ["Eggs", "Milk"]
    newShoppingList.append("Flour")
    newShoppingList += ["Baking Powder"]
    newShoppingList += ["Chocolate Spread", "Cheese", "Butter"]
    newShoppingList[4...6] = ["Bananas", "Apples"]
    newShoppingList[0] = "Six eggs"

    for item in newShoppingList {
        print(item)
    }
    // Six eggs
    // Milk
    // Flour
    // Baking Powder
    // Bananas

    for (index, value) in newShoppingList.enumerated() {
        print("Item \(index + 1): \(value)")
    }
    // Item 1: Six eggs
    // Item 2: Milk
    // Item 3: Flour
    // Item 4: Baking Powder
    // Item 5: Bananas
    
    return "Iterating done"
}
