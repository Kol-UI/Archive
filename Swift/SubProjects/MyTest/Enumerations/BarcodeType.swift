
import Foundation


enum Barcode {
    case upc(Int, Int, Int, Int)
    case qrCode(String)
}
