import SwiftUI

struct WheelPickerControl: View {
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
              .pickerStyle(.wheel)
            }
          }.navigationBarTitle(Text("Select your Fruit"))
        }
      }
    }

struct WheelPickerControl_Previews: PreviewProvider {
    static var previews: some View {
        WheelPickerControl()
    }
}
