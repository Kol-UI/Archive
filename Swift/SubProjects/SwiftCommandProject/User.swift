
import Foundation

class Player {
    var name: String
    var globalHP: Int
    // Inventory
    var golds: Int
    var numberOfPotions: Int
    // Red Key
    var boolRedKey: Bool
    var RedKeyNumber: Int
    // Blue Key
    var boolBlueKey: Bool
    var BlueKeyNumber: Int
    // Green Key
    var boolGreenKey: Bool
    var GreenKeyNumber: Int
    // Yellow Key
    var boolYellowKey: Bool
    var YellowKeyNumber: Int
    // Orange Key
    var boolOrangeKey: Bool
    var OrangeKeyNumber: Int

    init(name: String, globalHP: Int, golds: Int, numberOfPotions: Int, boolRedKey: Bool, RedKeyNumber: Int, boolBlueKey: Bool, BlueKeyNumber: Int, boolGreenKey: Bool, GreenKeyNumber: Int, boolYellowKey: Bool, YellowKeyNumber: Int, boolOrangeKey: Bool, OrangeKeyNumber: Int)  {
        self.name = name
        self.globalHP = globalHP
        self.golds = golds
        self.numberOfPotions = numberOfPotions
        
        self.boolRedKey = boolRedKey
        self.RedKeyNumber = RedKeyNumber
        
        self.boolBlueKey = boolBlueKey
        self.BlueKeyNumber = BlueKeyNumber
        
        self.boolGreenKey = boolGreenKey
        self.GreenKeyNumber = GreenKeyNumber
        
        self.boolYellowKey = boolYellowKey
        self.YellowKeyNumber = YellowKeyNumber
        
        self.boolOrangeKey = boolOrangeKey
        self.OrangeKeyNumber = OrangeKeyNumber
        
    }
    
    func attack() {
        print("You are attacking !")
    }
}




