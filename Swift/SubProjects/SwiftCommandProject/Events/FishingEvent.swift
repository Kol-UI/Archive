

import Foundation


func fishingMain(){
    print("You find a little lac. Do you want to try fishing ? 1) Yes 2) No")
    var boolFish = false
    var number: Int
    number = Int(readLine()!)!
    switch number {
    case 1:
        boolFish = true
    case 2:
        boolFish = false
    default:
        print("Wrong Value")
        fishingMain()
    }
    
    if boolFish == true{
        print("You start fishing...")
        let randomInt = Int.random(in: 1...10)
        switch randomInt{
        case 1:
            generateLootPotions()
        case 2:
            chargingWhileFishing()
        case 3:
            generateLootKey()
        case 4:
            chargingWhileFishing()
        case 5:
            print("You fished a package, let's see what's inside...")
            generateLootGolds();
        case 6:
            chargingWhileFishing()
        case 7...10:
            print("You find nothing...")
        default:
            chargingWhileFishing()
        }
    }
}

func chargingWhileFishing(){
    print("An ennemy is charging you while you are fishing !")
    SpawnMobMain()
}
