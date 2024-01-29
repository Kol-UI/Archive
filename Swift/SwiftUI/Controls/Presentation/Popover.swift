import SwiftUI

struct Popover : View {
  @State var showingPopover = false

  var body: some View {
    Button(action: {
      self.showingPopover = true
    }) {
      Text("Show new view")
    }.popover(isPresented: $showingPopover){
      HStack {
        Text("New Popover")
      }.frame(width: 500, height: 500)
        .background(Color.red)
    }
  }
}

struct Popover_Previews: PreviewProvider {
    static var previews: some View {
        Popover()
    }
}
