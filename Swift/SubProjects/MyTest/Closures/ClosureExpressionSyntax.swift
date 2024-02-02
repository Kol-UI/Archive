
import Foundation

/*
{ (parameters) -> <#return type#> in
   <#statements#>
}
*/


func expressionSyntax() {
    reversedNames = names.sorted(by: { (s1: String, s2: String) -> Bool in
        return s1 > s2
    })

    reversedNames = names.sorted(by: { (s1: String, s2: String) -> Bool in return s1 > s2 } )
}
