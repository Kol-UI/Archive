//class PriorityContentView : UIView, UIContentView {
//
//    // define the user interface elements
//    let priorityLabel = UILabel()
//    let prioritySlider = UISlider()
//    var priorityStack = UIStackView()
//
//    init() {
//        // apply style to the user interface
//        priorityStack = UIStackView(arrangedSubviews: [priorityLabel, prioritySlider])
//        priorityStack.axis = .vertical
//        self.addSubview(priorityStack)
//
//        priorityLabel.textAlignment = .center
//        priorityLabel.textColor = .white
//
//        prioritySlider.maximumValue = 10.0
//        prioritySlider.minimumValue = 0.0
//        prioritySlider.addTarget(self, action: #selector(self.sliderValueDidChange(_:)), for: .valueChanged)
//
//        // layout stack in superview
//        ...
//    }
//}

//var configuration: UIContentConfiguration {
//    didSet {
//        self.configure(configuration: configuration)
//    }
//}
//
//init(_ configuration: UIContentConfiguration) {
//    self.configuration = configuration
//
//    // apply style and lay out the user interface
//    ...
//
//    self.configure(configuration: configuration) // to be added
//}
//
//func configure(configuration: UIContentConfiguration) {
//    guard let configuration = configuration as? ReminderContentConfiguration else { return }
//    self.priorityLabel.text = configuration.reminder.title + " (priority: \(configuration.reminder.currentPriority))"
//    self.prioritySlider.value = Float(configuration.reminder.currentPriority)
//}
//
//@objc func sliderValueDidChange(_ sender: UISlider!) {
//    // snap slider value to integer steps
//    sender.value = round(sender.value)
//    guard var configuration = configuration as? ReminderContentConfiguration else { return }
//    configuration.updatePriority(to: Int(sender.value))
//    self.configure(configuration: configuration)
//}
