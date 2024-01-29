import SwiftUI

struct ScrollView: View {
    var body: some View {
        VStack{
        ScrollView() {
            VStack(spacing: 20) {
                ForEach(0..<10) {
                    Text("Item \($0)")
                        .foregroundColor(.white)
                        .font(.largeTitle)
                        .frame(width: 200, height: 200)
                        .background(.red)
                }
            }
        }
        .frame(height: 350)
        }
    }
}
