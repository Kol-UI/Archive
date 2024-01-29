//struct ReminderContentConfiguration: UIContentConfiguration {
//    var reminder: Reminder // a copy of the model
//
//    func makeContentView() -> UIView & UIContentView {
//        return PriorityContentView(self)
//    }
//    func updated(for state: UIConfigurationState) -> ReminderContentConfiguration {
//        return self
//    }
//    mutating func updatePriority(to newPriority: Int) {
//        reminder.currentPriority = newPriority
//    }
//}
