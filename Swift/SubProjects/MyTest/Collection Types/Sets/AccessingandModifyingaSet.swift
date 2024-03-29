

import Foundation

func AccessinASet() -> String {
    var favoriteGenres: Set<String> = ["Rock", "Classical", "Hip hop"]
    
    print("I have \(favoriteGenres.count) favorite music genres.")
    // Prints "I have 3 favorite music genres."
    
    if favoriteGenres.isEmpty {
        print("As far as music goes, I'm not picky.")
    } else {
        print("I have particular music preferences.")
    }
    // Prints "I have particular music preferences."
    
    favoriteGenres.insert("Jazz")
    // favoriteGenres now contains 4 items
    
    if let removedGenre = favoriteGenres.remove("Rock") {
        print("\(removedGenre)? I'm over it.")
    } else {
        print("I never much cared for that.")
    }
    // Prints "Rock? I'm over it."
    
    if favoriteGenres.contains("Funk") {
        print("I get up on the good foot.")
    } else {
        print("It's too funky in here.")
    }
    // Prints "It's too funky in here."
    
    return "Aaccessin Done"
}
