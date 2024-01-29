import SwiftUI

struct ColorInfo: Identifiable {
      var id = UUID()
      var color: Color
      var name: String
}

    struct ItemList : View {
      var colors = [ColorInfo(color: .red, name: "Red"),
                    ColorInfo(color: .blue, name: "Blue"),
                    ColorInfo(color: .yellow, name: "Yellow")]

      var body: some View {
        NavigationView {
          List (colors) { colorInfo in
            Text(colorInfo.name)
              .foregroundColor(colorInfo.color)
          }.navigationBarTitle(Text("List of Colors"))
        }
      }
    }

struct ItemList_Previews: PreviewProvider {
    static var previews: some View {
        ItemList()
    }
}
