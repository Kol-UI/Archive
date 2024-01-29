import Foundation

print("Hello, World!")

// Functions Start
print(sayHelloWorld())
print(greet(person: "Tim", alreadyGreeted: true))
greetNoReturn(person: "Dave")
let resultPrintAndCount = printAndCount(string: "hello, world")
printWithoutCounting(string: "hello, world")

let bounds = minMax(array: [8, -6, 2, 109, 3, 71])
print("min is \(bounds.min) and max is \(bounds.max)")

if let bounds = minMaxOptionalTupleReturn(array: [8, -6, 2, 109, 3, 71]) {
    print("min is \(bounds.min) and max is \(bounds.max)")
}

print(greetingImplicitReturn(for: "Dave"))
print(anotherGreetingImplicitReturn(for: "Dave"))

someFunction(firstParameterName: 1, secondParameterName: 2)

print(greetSpecify(person: "Bill", from: "Cupertino"))

someFunctionOmittingArgument(1, secondParameterName: 2)

someFunctionDefaultParameter(parameterWithoutDefault: 3, parameterWithDefault: 6)
someFunctionDefaultParameter(parameterWithoutDefault: 4)

print(arithmeticMean(1, 2, 3, 4, 5))
print(arithmeticMean(3, 8.25, 18.75))

var someInt = 3
var anotherInt = 107
swapTwoInts(&someInt, &anotherInt)
print("someInt is now \(someInt), and anotherInt is now \(anotherInt)")

print("Result: \(mathFunction(2, 3))")
mathFunction = multiplyTwoInts
print("Result: \(mathFunction(2, 3))")

printMathResultTypeParameter(addTwoInts, 3, 5)

print("Counting to zero:")
while currentValue != 0 {
    print("\(currentValue)... ")
    currentValue = moveNearerToZero(currentValue)
}
print("zero!")

while currentValueForNestedFunction != 0 {
    print("\(currentValueForNestedFunction)... ")
    currentValueForNestedFunction = moveNearerToZeroForNestedFunction(currentValueForNestedFunction)
}
print("zero!")
// Functions End


// Collection Types Start
// Arrays
someInts.append(3)
print("someInts is of type [Int] with \(someInts.count) items.")
someInts = []
print("someInts is of type [Int] with \(someInts.count) items.")

print(accessingArray())

print(iteratingOverArray())

// Sets
print(creatingSets())
print(creatingLiteralArray())

print(AccessinASet())

print(iteratingSet())

// Dictionaries
print(createEmptyDictionary())
print(accessingDictionary())
print(iteratingDictionary())
// Collection Types End
