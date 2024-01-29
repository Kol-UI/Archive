import SwiftUI

struct ToggleControl : View {
    @State private var isPushEnable = false
    
    var body: some View {
        Form {
            Section {
                Toggle(isOn: $isPushEnable) {
                    Text("Push Notification")
                }
                
                if isPushEnable {
                    Text("Schedule Notification")
                }
            }
        }
    }
}

struct ToggleControl_Previews: PreviewProvider {
    static var previews: some View {
        ToggleControl()
    }
}

