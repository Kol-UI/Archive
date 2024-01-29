//
//  main.swift
//  SwiftCommandProject
//
//  Learning purpose.
//

import Foundation


let value1 = 4
var var1 = 0
var x = 0.0, y = 1.0, z = 0.0
var welcomeMessage: String
welcomeMessage = "Hello"
var red, green, blue: Double
let π = 3.14159
let 🐶 = "dog"
let 🐮 = "cow"
let cow = "🐮"
let decimalDouble = 12.1875
let exponentDouble = 1.21875e1
let hexadecimalDouble = 0xC.3p0
let paddedDouble = 000123.456
let oneMillion = 1_000_000
let justOverOneMillion = 1_000_000.000_000_1
let falseBool = false
let trueBool = true
let bool3 = true
let http404Error = (404, "Not Found")
var friendlyWelcome = "Hello!" // can be changed
let meaningOfLife = 42
friendlyWelcome = "Bonjour!"
let languageName = "Swift" // can't be changed
let minValue = UInt8.min
let maxValue = UInt8.max


print(greet(person: "User"))
var globalHP = 100
var golds = 10
var numberOfPotions = 0
var boolRedKey = false
var RedKeyNumber = 0
var boolBlueKey = false
var BlueKeyNumber = 0
var boolGreenKey = false
var GreenKeyNumber = 0
var boolYellowKey = false
var YellowKeyNumber = 0
var boolOrangeKey = false
var OrangeKeyNumber = 0

// START Main Section
let user = Player(name: "Player", globalHP: 100, golds: 10, numberOfPotions: 1, boolRedKey: false, RedKeyNumber: 0, boolBlueKey: false, BlueKeyNumber: 0, boolGreenKey: false, GreenKeyNumber: 0, boolYellowKey: false, YellowKeyNumber: 0, boolOrangeKey: false, OrangeKeyNumber: 0)


SpawnMobMain()


while (user.globalHP > 0){
    generateEvent()
    Thread.sleep(forTimeInterval: 1.5)
    looting() // Free looting (to delete)
    SpawnMobMain() // Class (to delete)
    
}
if (user.globalHP >= 0){
    print("----- GAME OVER -----")
}

// END Main Section




func generateEvent(){
    let randomInt = Int.random(in: 1...2)
    print("--- Event \(randomInt) ---")
    switch randomInt{
    case 1:
        findMarchant()
    case 2:
        stepOnBee()
    default:
        print("Incorrect value.")
    }
}





func greet(person: String) -> String {
    let greeting = "Hello, " + person + "!"
    return greeting
}


func printGolds(){
    print("You have \(user.golds) Golds now.")
}

func printStats(){
    print("You have \(user.globalHP) Life Points and \(user.golds) Golds.")
}

func printNumberOfPotions(){
    print("You have \(user.numberOfPotions) potions in you inventory.")
}

func printKeys(){
    if user.boolRedKey == true{
        print("You have \(user.RedKeyNumber) Red Key(s).")
    }
    if user.boolBlueKey == true{
        print("You have \(user.BlueKeyNumber) Blue Key(s).")
    }
    if user.boolGreenKey == true{
        print("You have \(user.GreenKeyNumber) Green Key(s).")
    }
    if user.boolYellowKey == true{
        print("You have \(user.YellowKeyNumber) Yellow Key(s).")
    }
    if user.boolOrangeKey == true{
        print("You have \(user.OrangeKeyNumber) Orange Key(s).")
    }
    if (user.RedKeyNumber == 0 && user.BlueKeyNumber == 0 && user.GreenKeyNumber == 0 && user.YellowKeyNumber == 0 && user.OrangeKeyNumber == 0){
        print("You dont have any key...")
        user.boolRedKey = false
        user.boolBlueKey = false
        user.boolGreenKey = false
        user.boolYellowKey = false
        user.boolOrangeKey = false
    }
    
}




func findMarchant(){
    print("You find a Marchant !")
    Shop()
}

func Shop(){
    print ("What are you doing in the shop ?")
    printStats()
    print("1) Leave 2) Buy a potion (-15G/+10HP) 3) Sell a Key (+30G)")
    let price = 15
    var potionsTotalPrice : Int
    var potionsNb : Int
    var number : Int
    number = Int(readLine()!)!
    switch number {
        case 1:
        print("You are leaving the Marchant...")
        case 2:
        if (user.golds < price){
            print("You can't even buy one potion...")
        }
        else{
            print("How many potions do you buy ?")
            var potionsInput : Int
            potionsInput = Int(readLine()!)!
            potionsNb = potionsInput
            potionsTotalPrice = price * potionsInput
            if (potionsTotalPrice > user.golds){
                print("You can't buy it...")
            }
            else {
                print("Are you sure about buying \(potionsNb) potions ?")
                print("The price will be \(potionsTotalPrice) Golds.")
                var buyingPotionsBool : Int
                print("1) Sure ! 2) Nevermind...")
                buyingPotionsBool = Int(readLine()!)!
                if (buyingPotionsBool == 1){
                    print("Buying \(potionsNb) potions for \(potionsTotalPrice) Golds...")
                    user.numberOfPotions += potionsNb
                    user.golds -= potionsTotalPrice
                    printGolds()
                    printNumberOfPotions()
                }
                else {
                    
                }
            }
        }
        Shop()
        case 3:
        print("--- In your inventory ---")
        printKeys()
        if (user.RedKeyNumber == 0 && user.BlueKeyNumber == 0 && user.GreenKeyNumber == 0 && user.YellowKeyNumber == 0 && user.OrangeKeyNumber == 0){
            user.boolRedKey = false
            user.boolBlueKey = false
            user.boolGreenKey = false
            user.boolYellowKey = false
            user.boolOrangeKey = false
        }
        else{
            print("Which key are you selling ?")
            sellKey()
        }
        Shop()
        default:
        print("Incorrect value.")
        Shop()
    }

}

func sellKey(){
    print("1) Red 2) Blue 3) Green 4) Yellow 5) Orange 6) Done!")
    let price = 30
    var number : Int
    var number2 : Int
    number = Int(readLine()!)!
    switch number {
    case 1:
        print("How many Red keys ?")
        number2 = Int(readLine()!)!
        if (number2 > user.RedKeyNumber){
            print("Not enough Red Keys to sell !")
        }
        else{
            print("Selling \(number2) Red Keys")
            user.RedKeyNumber = user.RedKeyNumber - number2
            user.golds += number2 * price
            printGolds()
            if (user.RedKeyNumber == 0){
                user.boolRedKey = false
            }
        }
    case 2:
        print("How many Blue keys ?")
        number2 = Int(readLine()!)!
        if (number2 > user.BlueKeyNumber){
            print("Not enough Blue Keys to sell !")
        }
        else{
            print("Selling \(number2) Blue Keys")
            user.BlueKeyNumber = user.BlueKeyNumber - number2
            user.golds += number2 * price
            printGolds()
            if (user.BlueKeyNumber == 0){
                user.boolBlueKey = false
            }
        }
    case 3:
        print("How many Green keys ?")
        number2 = Int(readLine()!)!
        if (number2 > user.GreenKeyNumber){
            print("Not enough Green Keys to sell !")
        }
        else{
            print("Selling \(number2) Green Keys")
            user.GreenKeyNumber = user.GreenKeyNumber - number2
            user.golds += number2 * price
            printGolds()
            if (user.GreenKeyNumber == 0){
                user.boolGreenKey = false
            }
        }
    case 4:
        print("How many Yellow keys ?")
        number2 = Int(readLine()!)!
        if (number2 > user.YellowKeyNumber){
            print("Not enough Yellow Keys to sell !")
        }
        else{
            print("Selling \(number2) Yellow Keys")
            user.YellowKeyNumber = user.YellowKeyNumber - number2
            user.golds += number2 * price
            printGolds()
            if (user.GreenKeyNumber == 0){
                user.boolGreenKey = false
            }
        }
    case 5:
        print("How many Orange keys ?")
        number2 = Int(readLine()!)!
        if (number2 > user.OrangeKeyNumber){
            print("Not enough Orange Keys to sell !")
        }
        else{
            print("Selling \(number2) Orange Keys")
            user.OrangeKeyNumber = user.OrangeKeyNumber - number2
            user.golds += number2 * price
            printGolds()
            if (user.GreenKeyNumber == 0){
                user.boolGreenKey = false
            }
        }
    default:
        print("Incorrect value.")
    }
}





func needRedKey(){
    print("You need a Red Key to open")
    if user.boolRedKey == true{
        print("You are openning the door")
    }
    else{
        print("You go away...")
    }
}

func needBlueKey(){
    print("You need a Blue Key to open")
    if user.boolBlueKey == true{
        print("You are openning the door")
    }
    else{
        print("You go away...")
    }
}

func needGreenKey(){
    print("You need a Green Key to open")
    if user.boolGreenKey == true{
        print("You are openning the door")
    }
    else{
        print("You go away...")
    }
}

func needYellowKey(){
    print("You need a Yellow Key to open")
    if user.boolYellowKey == true{
        print("You are openning the door")
    }
    else{
        print("You go away...")
    }
}

func needOrangeKey(){
    print("You need a Orange Key to open")
    if user.boolOrangeKey == true{
        print("You are openning the door")
    }
    else{
        print("You go away...")
    }
}



func other(){
    print("Hello, World!")
    print("friendlyWelcome is \(friendlyWelcome)")
    print("friendlyWelcome is now \(friendlyWelcome)")
    print(minValue)
    print(maxValue)
    print("The meaning Of life is \(meaningOfLife)")
    print("User input :")
    if let input = readLine()
    {
        if let int = Int(input)
        {
            print("Entered input is \(int) of the type:\(type(of: int))")
        }
        else{
            print("Entered input is \(input) of the type:\(type(of: input))")
        }
    }

    if falseBool {
        print("Bool1 is true.")
    } else {
        print("Bool1 is false.")
    }
    if trueBool {
        print("Bool2 is true.")
    } else {
        print("Bool2 is false.")
    }
    if bool3 {
        print("Bool3 is true.")
    } else {
        print("Bool3 is false.")
    }

    let (statusCode, statusMessage) = http404Error
    print("The status code is \(statusCode)")
    print("The status message is \(statusMessage)")
}

