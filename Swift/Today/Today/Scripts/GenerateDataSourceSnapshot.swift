//func applyInitialSnapshots() {
//        // define snapshot with same <section,item> parameters as the data source
//        var initialSnapshot = NSDiffableDataSourceSnapshot<Int, ReminderItem>()
//        let reminderItems = reminderStore.reminders.map { reminder in
//            return ReminderItem(reminder: reminder)
//        }
//
//        initialSnapshot.appendSections([0]) // only one section in this list
//        initialSnapshot.appendItems(reminderItems, toSection: 0)
//        dataSource.apply(initialSnapshot, animatingDifferences: false)
//    }
