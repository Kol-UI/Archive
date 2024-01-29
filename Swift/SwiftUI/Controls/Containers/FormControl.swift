import SwiftUI

struct FormControl: View {
      var colors = ["Red", "Green", "Blue"]
      @State var enableNotifications = false
      @State var username: String = ""
      @State var selectedColor = 0

      var body: some View {
        NavigationView {
          Form {
            Section {
              TextField("Username", text: $username)
            }
            Section {
              Toggle(isOn: $enableNotifications) {
                Text("Enable Notifications")
              }
              
            }
            Section {
              Button(action: {}) {
                Text("Save")
              }
            }
          }.navigationBarTitle(Text("Settings"))
        }
      }
    }

struct FormControl_Previews: PreviewProvider {
    static var previews: some View {
        FormControl()
    }
}
