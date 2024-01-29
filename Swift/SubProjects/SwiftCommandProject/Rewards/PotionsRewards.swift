

import Foundation


func generateLootPotions(){
    let randomInt = Int.random(in: 1...3)
    switch randomInt{
    case 1:
        print("You find a potion !")
        user.numberOfPotions += 1
    case 2:
        print("You find 2 potion !")
        user.numberOfPotions += 2
    case 3:
        print("You find 3 potion !")
        user.numberOfPotions += 3
    default:
        print("Incorrect value.")
    }
}
