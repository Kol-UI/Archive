
import Foundation

func printMathResultTypeParameter(_ mathFunction: (Int, Int) -> Int, _ a: Int, _ b: Int) {
    print("Result: \(mathFunction(a, b))")
}

// printMathResultTypeParameter(addTwoInts, 3, 5)
// Prints "Result: 8"
