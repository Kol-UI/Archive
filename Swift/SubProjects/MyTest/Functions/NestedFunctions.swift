
import Foundation

func chooseStepFunctionNested(backward: Bool) -> (Int) -> Int {
    func stepForward(input: Int) -> Int { return input + 1 }
    func stepBackward(input: Int) -> Int { return input - 1 }
    return backward ? stepBackward : stepForward
}

var currentValueForNestedFunction = -4
let moveNearerToZeroForNestedFunction = chooseStepFunction(backward: currentValue > 0)
// moveNearerToZero now refers to the nested stepForward() function

/*
 while currentValueForNestedFunction != 0 {
    print("\(currentValueForNestedFunction)... ")
    currentValueForNestedFunction = moveNearerToZeroForNestedFunction(currentValue)
}
print("zero!")
// -4...
// -3...
// -2...
// -1...
// zero!
*/
