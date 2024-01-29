import Foundation

func looting(){
    print("You are looting the mob...")
    let randomInt = Int.random(in: 1...10)
    switch randomInt{
    case 1:
        generateLootKey()
    case 2:
        generateLootPotions()
    case 3:
        generateLootGolds()
    case 4:
        generateLootGolds()
    case 5:
        generateLootGolds()
    case 6:
        generateLootGolds()
    case 7:
        generateLootGolds()
    case 8:
        generateLootGolds()
    case 9:
        generateLootGolds()
    case 10:
        generateLootGolds()
    default:
        print("Incorrect value.")
    }
}
