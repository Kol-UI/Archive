

import Foundation

func Fight(){
    trashMob.checkIfAlive()
    print("You hit it -1 HP.")
    trashMob.life -= 1
}

func SpawnMobMain(){
    let ennemy = Ennemy(name: "mob", force: 5, life: 30)
    print("A \(ennemy.name) is attacking you !")
    ennemy.attack()
    
}


func SpawnLittleDemon(){
    let trashMob = Ennemy(name: "test2", force: 3, life: 4)
    print("A \(trashMob.name) is attacking you !")
    Fight()
    Fight()
    Fight()
    Fight()
    Fight()
    Fight()
    Fight()
}
