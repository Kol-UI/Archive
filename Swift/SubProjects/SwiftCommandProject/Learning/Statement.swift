//
//  Statement.swift
//  SwiftCommandProject
//
//

import Foundation

func StatementsMain(){
    // Switch Statement
    let animal = "horse"
    
    var count = 10

    switch animal {
    case "horse":
        print("eats grass")
        count = 100
    case "wolf":
        print("eats meat")
        count += 20
    default:
        print("no match")
        count = 5
    }

    // Switch Statement with fallthrough
    
    switch count {
       case 100:
          print( "Value of count is 100")
          fallthrough
       case 10:
          print( "Value of count is 10")
          fallthrough
       case 5:
          print( "Value of count is 5")
       default:
          print( "default case")
    }
    
    // Switch without default block
    enum Theme {
        case light
        case dark
    }

    let theme = Theme.light

    switch theme {
        case .light:
             print("light theme apply")
        case .dark:
             print("drak theme apply")
    }
    
    // Switch Statement with Range
    let mark = 12

    switch mark {
    case 0:
        print("Bull Eye")
    case 1..<10:
        print("Almost Bull Eye")
    case 10..<30:
        print("Close")
    default:
        print("Too Far")
    }
    
    // Tuple in Switch Statement
    let aPoint = (1, 1)

    switch aPoint {
    case (0, 0): break
        // only catches an exact match for first and second
    case (_, 0): break
        // any first, exact second
    case (-2...2, -2...2): break
        // range for first and second
    default: break
        // catches anything else
    }
    
    // Compound case in the Switch statement
    let charValue = "e"

    switch charValue {
    case "a", "b", "c":
        print("match found for (a,b,c) value")
    case "d", "e":
        print("match found for (d,e) value")
    default:
        print("No match found")
    }
    
    // Value Bindings with the Switch statement
    let currentPoint = (10, 0)
    switch currentPoint {
    case (let x, 0):
        print("on the x-axis with an x value of \(x)")
    case (0, let y):
        print("on the y-axis with a y value of \(y)")
    case let (x, y):
        print("somewhere else at (\(x), \(y))")
    }
    
    // Where clause in the Switch statement
    var num  = 0

    switch num  {
    case let result where num >= 0:
         print(result)
    case num where num % 5 == 0 && num % 3 == 0:
         print(" Fizz Buzz")
    case num where num % 3 == 0:
         print("Fizz")
    case num where num % 5 == 0:
         print("Buzz")
    default:
        print(num)
    }
    
    
    
}
