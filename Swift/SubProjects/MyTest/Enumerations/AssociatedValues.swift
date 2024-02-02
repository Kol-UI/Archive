
import Foundation

func associatedValuesEnums(){
    var productBarcode = Barcode.upc(8, 85909, 51226, 3)
    print(productBarcode)
    productBarcode = .qrCode("ABCDEFGHIJKLMNOP")
    print(productBarcode)
    
    switch productBarcode {
    case .upc(let numberSystem, let manufacturer, let product, let check):
        print("UPC: \(numberSystem), \(manufacturer), \(product), \(check).")
    case .qrCode(let productCode):
        print("QR code: \(productCode).")
    }
    // Prints "QR code: ABCDEFGHIJKLMNOP."
    
    // let
    switch productBarcode {
    case let .upc(numberSystem, manufacturer, product, check):
        print("UPC : \(numberSystem), \(manufacturer), \(product), \(check).")
    case let .qrCode(productCode):
        print("QR code: \(productCode).")
    }
    // Prints "QR code: ABCDEFGHIJKLMNOP."
}
