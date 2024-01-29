

import Foundation

func someFunctionDefaultParameter(parameterWithoutDefault: Int, parameterWithDefault: Int = 12) {
    // If you omit the second argument when calling this function, then
    // the value of parameterWithDefault is 12 inside the function body.
}

//someFunctionDefaultParameter(parameterWithoutDefault: 3, parameterWithDefault: 6) // parameterWithDefault is 6
//someFunctionDefaultParameter(parameterWithoutDefault: 4) // parameterWithDefault is 12
