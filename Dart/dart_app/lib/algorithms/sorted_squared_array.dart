
List<int> sortedSquaredArray(List<int> array) {
  int start = 0;
  int end = array.length - 1;
  int sortedIndex = array.length - 1;
  List<int> answer = List.filled(array.length, 0);

  while (end >= start) {
    if (array[start].abs() > array[end].abs()) {
      answer[sortedIndex] = array[start] * array[start];
      start += 1;
    } else {
      answer[sortedIndex] = array[end] * array[end];
      end -= 1;
    }
    sortedIndex -= 1;
  }
  print(answer);

  return answer;
}