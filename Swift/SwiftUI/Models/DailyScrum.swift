
import Foundation

struct DailyScrum: Identifiable, Codable {
    let id: UUID
    var title: String
    var attendees: [Attendee]
    var lengthInMinutes: Int
    var theme: Theme
    var history: [History] = []
    
    init(id: UUID = UUID(), title: String, attendees: [String], lengthInMinutes: Int, theme: Theme) {
        self.id = id
        self.title = title
        self.attendees = attendees.map { Attendee(name: $0) }
        self.lengthInMinutes = lengthInMinutes
        self.theme = theme
    }
    
    init(data: Data) {
        id = UUID()
        title = data.title
        attendees = data.attendees
        lengthInMinutes = Int(data.lengthInMinutes)
        theme = data.theme
    }
}

extension DailyScrum {
    struct Attendee: Identifiable, Codable {
        let id: UUID
        var name: String
        
        init(id: UUID = UUID(), name: String) {
            self.id = id
            self.name = name
        }
        
        
    }
    
    mutating func update(from data: Data) {
            title = data.title
            attendees = data.attendees
            lengthInMinutes = Int(data.lengthInMinutes)
            theme = data.theme
        }
    
    struct Data {
        var title: String = ""
        var attendees: [Attendee] = []
        var lengthInMinutes: Double = 5
        var theme: Theme = .seafoam
        }
        
        var data: Data {
        Data(title: title, attendees: attendees, lengthInMinutes: Double(lengthInMinutes), theme: theme)
        }
    
}



extension DailyScrum {
    static let sampleData: [DailyScrum] =
    [
        DailyScrum(title: "Design", attendees: ["Cathy", "Daisy", "Simon", "Jonathan"], lengthInMinutes: 10, theme: .yellow),
        DailyScrum(title: "App Dev", attendees: ["Katie", "Gray", "Euna", "Luis", "Darla"], lengthInMinutes: 25, theme: .orange),
        DailyScrum(title: "Web Dev", attendees: ["Chella", "Chris", "Christina", "Eden", "Karla", "Lindsey", "Aga", "Chad", "Jenn", "Sarah"], lengthInMinutes: 35, theme: .poppy),
        DailyScrum(title: "Marketing", attendees: ["Jean", "O'Brian", "Arthur", "Donald", "Kate"], lengthInMinutes: 15, theme: .lavender),
        DailyScrum(title: "Management", attendees: ["Ramesh", "Marc", "Bill", "John", "Clara", "Alice", "Castro"], lengthInMinutes: 17, theme: .sky),
        DailyScrum(title: "Sales", attendees: ["Soniya", "Romane", "Chris", "Manon", "Cassandra", "Louis", "Tony", "Ronald", "Richard", "Frank", "Ives", "Anil", "Roger"], lengthInMinutes: 13, theme: .seafoam),
        DailyScrum(title: "Human Ressources", attendees: ["Paul", "Michel", "Joseph", "Cruz", "Lopez"], lengthInMinutes: 9, theme: .oxblood),
        DailyScrum(title: "Team Product A", attendees: ["Peter", "Miguel", "Jean", "Caroline", "Lodivik"], lengthInMinutes: 15, theme: .bubblegum),
        DailyScrum(title: "Team Product B", attendees: ["Sergius", "Jeffe", "Woody", "Lambert", "Simone"], lengthInMinutes: 15, theme: .buttercup),
        DailyScrum(title: "Team Product C", attendees: ["Desiree", "Fanie", "Emile", "Helfried", "Samantha"], lengthInMinutes: 15, theme: .periwinkle)
    ]
}
