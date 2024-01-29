
import SwiftUI

struct PickerControl: View {
      var fruits = ["Apple", "Apricot", "Banana", "Pear"]
      @State var selectedFruit = 0
        
      var body: some View {
        NavigationView {
          Form {
            Section {
              Picker(selection: $selectedFruit, label: Text("Fruit")) {
                ForEach(0 ..< fruits.count) {
                  Text(self.fruits[$0]).tag($0)
                }
              }
            }
          }.navigationBarTitle(Text("Select your Fruit"))
        }
      }
    }

struct PickerControl_Previews: PreviewProvider {
    static var previews: some View {
        PickerControl()
    }
}
