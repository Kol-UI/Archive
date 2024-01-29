//static func load(completion: @escaping (Result<[DailyScrum], Error>)->Void) {
//  DispatchQueue.global(qos: .background).async {
//      do {
//          // Decode scrums
//          DispatchQueue.main.async {
//              completion(.success(dailyScrums))
//          }
//      } catch {
//          DispatchQueue.main.async {
//              completion(.failure(error))
//          }
//      }
//  }
//}
