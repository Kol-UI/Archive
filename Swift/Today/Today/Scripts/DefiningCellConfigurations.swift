//func reminderCellRegistration() -> UICollectionView.CellRegistration<UICollectionViewListCell, ReminderItem> {
//        return .init { cell, _, item in
//            guard let reminder = item.reminder else { return }
//            var configuration = cell.defaultContentConfiguration()
//            configuration.text = reminder.title
//            configuration.textProperties.color = .darkGray
//            cell.contentConfiguration = configuration
//
//            var backgroundConfig = UIBackgroundConfiguration.listPlainCell()
//            backgroundConfig.cornerRadius = 8
//            cell.backgroundConfiguration = backgroundConfig
//        }
//    }
