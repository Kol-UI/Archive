
import Foundation



func accessingArray() -> String {
    print("The shopping list contains \(shoppingList.count) items.")
    // Prints "The shopping list contains 2 items."

    if shoppingList.isEmpty {
        print("The shopping list is empty.")
    } else {
        print("The shopping list isn't empty.")
    }
    // Prints "The shopping list isn't empty."

    shoppingList.append("Flour")
    // shoppingList now contains 3 items, and someone is making pancakes

    shoppingList += ["Baking Powder"]
    // shoppingList now contains 4 items
    shoppingList += ["Chocolate Spread", "Cheese", "Butter"]
    // shoppingList now contains 7 items

    var firstItem = shoppingList[0]
    print(firstItem)
    // firstItem is equal to "Eggs"

    shoppingList[0] = "Six eggs"
    // the first item in the list is now equal to "Six eggs" rather than "Eggs"

    shoppingList[4...6] = ["Bananas", "Apples"]
    // shoppingList now contains 6 items

    shoppingList.insert("Maple Syrup", at: 0)
    // shoppingList now contains 7 items
    // "Maple Syrup" is now the first item in the list

    let mapleSyrup = shoppingList.remove(at: 0)
    // the item that was at index 0 has just been removed
    // shoppingList now contains 6 items, and no Maple Syrup
    // the mapleSyrup constant is now equal to the removed "Maple Syrup" string

    firstItem = shoppingList[0]
    // firstItem is now equal to "Six eggs"

    let apples = shoppingList.removeLast()
    // the last item in the array has just been removed
    // shoppingList now contains 5 items, and no apples
    // the apples constant is now equal to the removed "Apples" string

    print(mapleSyrup)
    print(apples)
    return "Accessing & Modifying Done"
}
