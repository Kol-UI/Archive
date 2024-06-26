

import Foundation

func greetNoReturn(person: String) {
    print("Hello, \(person)!")
}
// greet(person: "Dave")
// Prints "Hello, Dave!"

func printAndCount(string: String) -> Int {
    print(string)
    return string.count
}
func printWithoutCounting(string: String) {
    let _ = printAndCount(string: string)
}

// printAndCount(string: "hello, world")
// prints "hello, world" and returns a value of 12
// printWithoutCounting(string: "hello, world")
// prints "hello, world" but doesn't return a value
