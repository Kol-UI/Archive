
import SwiftUI

struct InventoryView: View {
    var body: some View {
        VStack {
            Text("Inventory")
                .font(.title)
            HStack {
                Label("Paperclips", systemImage: "paperclip.circle.fill")
                Text("3")
            }
            
        }
        .padding()
    }
}

struct InventoryView_Previews: PreviewProvider {
    static var previews: some View {
        InventoryView()
    }
}
