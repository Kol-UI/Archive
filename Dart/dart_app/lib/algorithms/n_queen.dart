
List<List<int>> board = [];

bool isSafe(int size, int row, int col) {
  for (int k = 0; k < row; k++) {
    if (board[k][col] == 1) {
      return false;
    }
  }
  int i = row;
  int j = col;


  while (i >= 0 && j >= 0) {
    if (board[i][j] == 1) {
      return false;
    }
    j--;
    i--;
  }
  
  i = row;
  j = col;
  while (i >= 0 && j < size) {
    if (board[i][j] == 1) {
      return false;
    }
    j++;
    i--;
  }
  return true;
}

int solveNQueen(int row, int size) {
  if (size == row) {
    return 1;
  }
  int ways = 0;
  for (int col = 0; col < size; col++) {
    if (isSafe(size, row, col)) {
      board[row][col] = 1;
      ways += solveNQueen(row + 1, size);

      board[row][col] = 0;
    }
  }
  print(board);
  return ways;
}

void resetBoard(int boardSize) {
  board = List.generate(boardSize, (i) => List.generate(boardSize, (j) => 0));
}