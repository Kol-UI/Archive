
import Foundation


func iteratingSet() -> String {
    let favoriteGenres: Set<String> = ["Rock", "Classical", "Hip hop"]
    for genre in favoriteGenres {
        print("\(genre)")
    }
    // Classical
    // Jazz
    // Hip hop

    for genre in favoriteGenres.sorted() {
        print("\(genre)")
    }
    // Classical
    // Hip hop
    // Jazz
    
    return "Iteration Done"
}
