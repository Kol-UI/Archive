//private func doneButtonAccessibilityAction(for reminder: Reminder) -> UIAccessibilityCustomAction {
//    let name = NSLocalizedString("Toggle completion", comment: "Reminder done button accessibility label")
//    let action = UIAccessibilityCustomAction(name: name) { [weak self] action in
//        self?.completeReminder(with: reminder.id)
//        return true
//    }
//    return action
//}
//
//func cellRegistrationHandler(cell: UICollectionViewListCell, indexPath: IndexPath, id: Reminder.ID) {
//    // ...
//    cell.accessibilityCustomActions = [ doneButtonAccessibilityAction(for: reminder) ]
//    cell.accessibilityValue = reminder.isComplete ? reminderCompletedValue : reminderNotCompletedValue
//    // ...
//}
