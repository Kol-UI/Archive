
import Foundation

func greetingImplicitReturn(for person: String) -> String {
    "Hello, " + person + "!"
}
// print(greetingImplicitReturn(for: "Dave"))
// Prints "Hello, Dave!"


func anotherGreetingImplicitReturn(for person: String) -> String {
    return "Hello, " + person + "!"
}
// print(anotherGreetingImplicitReturn(for: "Dave"))
// Prints "Hello, Dave!"
