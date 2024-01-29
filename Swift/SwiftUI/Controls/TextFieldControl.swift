import SwiftUI

struct TextFieldControl : View {
  @State private var username: String = ""
  var body: some View {
    Form {
      Section {
        TextField("Username", text: $username)
      }
    }
  }
}

struct TextFieldControl_Previews: PreviewProvider {
    static var previews: some View {
        TextFieldControl()
    }
}
