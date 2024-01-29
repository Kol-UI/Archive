

import Foundation

func greetAgain(person: String) -> String {
    return "Hello again, " + person + "!"
}

func greet(person: String) -> String {
    let greeting = "Hello, " + person + "!"
    return greeting
}

func greet(person: String, alreadyGreeted: Bool) -> String {
    if alreadyGreeted {
        return greetAgain(person: person)
    } else {
        return greet(person: person)
    }
}
// print(greet(person: "Tim", alreadyGreeted: true))
// Prints "Hello again, Tim!"
