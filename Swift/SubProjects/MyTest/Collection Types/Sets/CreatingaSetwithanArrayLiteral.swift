

import Foundation


func creatingLiteralArray() -> String {
    let favoriteGenres: Set<String> = ["Rock", "Classical", "Hip hop"]
    // favoriteGenres has been initialized with three initial items
    // var favoriteGenres: Set<String> = ["Rock", "Classical", "Hip hop"]
    // var favoriteGenres2: Set = ["Rock", "Classical", "Hip hop"]
    let favoriteGenres2: Set = ["Rock", "Classical", "Hip hop"]
        
    for item in favoriteGenres {
        print(item)
    }
    
    for item in favoriteGenres2 {
        print(item)
    }
    
    return "Literal Done"
}
