import SwiftUI

struct SoundToggle: View {
    @State var isSound = true
    var body: some View {
            
            VStack{
                Spacer()
                Toggle(isOn: $isSound){
                    Text("Sound")
                        .font(.largeTitle)
                        .foregroundColor(.red)
                }
                .padding()
                Image(systemName: isSound ? "speaker.1.fill":"speaker.slash.fill")
                    .font(.system(size: 80))
                    .foregroundColor(isSound ? .blue : .red)
                .padding()
                
                Spacer()
            }.padding()
        }
    }


struct SoundToggle_Previews: PreviewProvider {
    static var previews: some View {
        SoundToggle()
    }
}
