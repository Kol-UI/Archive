

import Foundation

class Ennemy {
    var name: String
    var force: Int
    var life: Int
    

    init(name: String, force: Int, life: Int) {
        self.name = name
        self.force = force
        self.life = life
    }
    
    func checkIfAlive(){
        if self.life == 0{
            print("The \(self.name) is dead.")
            looting()
        }
    }
    
    func attack() {
        print("attacking")
    }
}
