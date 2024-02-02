
import Foundation

struct EnumMap<Enum: CaseIterable & Hashable, Value> {
    private let values: [Enum : Value]

    init(resolver: (Enum) -> Value) {
        var values = [Enum : Value]()

        for key in Enum.allCases {
            values[key] = resolver(key)
        }

        self.values = values
    }

    subscript(key: Enum) -> Value {
        // Here we have to force-unwrap, since there's no way
        // of telling the compiler that a value will always exist
        // for any given key. However, since it's kept private
        // it should be fine - and we can always add tests to
        // make sure things stay safe.
        return values[key]!
    }
}



/*
let fonts = EnumMap<TextType, UIFont> { type in
    switch type {
    case .title:
        return .preferredFont(forTextStyle: .headline)
    case .subtitle:
        return .preferredFont(forTextStyle: .subheadline)
    case .sectionTitle:
        return .preferredFont(forTextStyle: .title2)
    case .body:
        return .preferredFont(forTextStyle: .body)
    case .comment:
        return .preferredFont(forTextStyle: .footnote)
    }
}
*/

/*
 let titleFont = fonts[.title]
 let subtitleFont = fonts[.subtitle]
 */


/*
 extension ProductListViewController {
     enum Section: String, CaseIterable {
         case featured
         case onSale
         case categories
         case saved
     }
 }
 */

/*
 extension ProductListViewController {
     func registerCellClasses() {
         let resolver: (Section) -> UITableViewCell.Type = { section in
             switch section {
             case .featured:
                 return FeaturedProductCell.self
             case .onSale:
                 return ProductCell.self
             case .categories:
                 return CategoryCell.self
             case .saved:
                 return BookmarkCell.self
             }
         }

         for section in Section.allCases {
             tableView.register(resolver(section),
                                forCellReuseIdentifier: section.rawValue)
         }
     }
 }
 */


/*
 extension UITableView {
     func registerCellClasses<T: CaseIterable & RawRepresentable>(
         for sectionType: T.Type,
         using resolver: (T) -> UITableViewCell.Type
     ) where T.RawValue == String {
         for section in sectionType.allCases {
             register(resolver(section), forCellReuseIdentifier: section.rawValue)
         }
     }
 }
 */
