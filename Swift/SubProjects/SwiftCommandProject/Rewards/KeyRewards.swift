

import Foundation

func generateLootKey(){
    let randomInt = Int.random(in: 1...5)
    switch randomInt{
    case 1:
        findRedKey()
    case 2:
        findBlueKey()
    case 3:
        findGreenKey()
    case 4:
        findYellowKey()
    case 5:
        findOrangeKey()
    default:
        print("Incorrect value.")
    }
}

func findRedKey(){
    print("You find a Red Key !")
    user.boolRedKey = true
    user.RedKeyNumber += 1
}

func findBlueKey(){
    print("You find a Blue Key !")
    user.boolBlueKey = true
    user.BlueKeyNumber += 1
}

func findGreenKey(){
    print("You find a Green Key !")
    user.boolGreenKey = true
    user.GreenKeyNumber += 1
}

func findYellowKey(){
    print("You find a Yellow Key !")
    user.boolYellowKey = true
    user.YellowKeyNumber += 1
}

func findOrangeKey(){
    print("You find a Orange Key !")
    user.boolOrangeKey = true
    user.OrangeKeyNumber += 1
}
