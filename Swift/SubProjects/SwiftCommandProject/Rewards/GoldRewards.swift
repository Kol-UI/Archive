
import Foundation

func generateLootGolds(){
    let randomInt = Int.random(in: 0...53)
    switch randomInt{
    case 0:
        findPiece()
    case 1:
        findPiece()
    case 2:
        someGolds()
    case 3:
        findPiece()
    case 4:
        findPiece()
    case 5:
        someGolds()
    case 6:
        findPiece()
    case 7:
        fiveGolds()
    case 8:
        findPiece()
    case 9:
        findPiece()
    case 10:
        someGolds()
    case 11:
        findPiece()
    case 12:
        fiveGolds()
    case 13:
        findPiece()
    case 14:
        findLittleBagGolds()
    case 15:
        findPiece()
    case 16:
        findPiece()
    case 17:
        someGolds()
    case 18:
        findPiece()
    case 19:
        fiveGolds()
    case 20:
        findPiece()
    case 21:
        findLittleBagGolds()
    case 22:
        findPiece()
    case 23:
        findPiece()
    case 24:
        someGolds()
    case 25:
        findPiece()
    case 26:
        fiveGolds()
    case 27:
        findPiece()
    case 28:
        findLittleBagGolds()
    case 29:
        findPiece()
    case 30:
        findBagGolds()
    case 31:
        findPiece()
    case 32:
        findPiece()
    case 33:
        someGolds()
    case 34:
        findPiece()
    case 35:
        fiveGolds()
    case 36:
        findPiece()
    case 37:
        findLittleBagGolds()
    case 38:
        findPiece()
    case 39:
        findBagGolds()
    case 40:
        findPiece()
    case 41:
        findManyGolds()
    case 41...53:
        findNoPiece()
    default:
        print("Incorrect value.")
    }
}

func findNoPiece(){
    print("You find nothing on the mob body...")
}

func findPiece(){
    print("You earn 1 gold.")
    user.golds += 1
}

func someGolds(){
    print("You earn 3 gold.")
    user.golds += 3
}

func fiveGolds(){
    print("You earn 5 gold.")
    user.golds += 5
}

func findLittleBagGolds(){
    print("You find a little bag of Golds.")
    print("You earn 7 gold.")
    user.golds += 7
}

func findBagGolds(){
    print("You find a bag of Golds.")
    print("You earn 10 gold.")
    user.golds += 10
}

func findManyGolds(){
    print("You find a lot of golds.")
    print("You earn 15 gold.")
    user.golds += 15
}

