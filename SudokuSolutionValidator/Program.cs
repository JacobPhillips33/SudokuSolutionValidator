using SudokuSolutionValidator;

// Valid Solution:
//int[][] valid = new int[][]
//{
//  new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
//  new int[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
//  new int[] { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
//  new int[] { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
//  new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
//  new int[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
//  new int[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
//  new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
//  new int[] { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
//};

//Console.WriteLine(Methods.ValidateSolution(valid));

int[][] board = new int[9][];
board[0] = new int[9];

Console.WriteLine("Enter each row of numbers separated by a \",\"");
Console.WriteLine("First row: ");
board[0] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();
Console.WriteLine("Second row: ");
board[1] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();
Console.WriteLine("Third row: ");
board[2] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();
Console.WriteLine("Forth row: ");
board[3] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();
Console.WriteLine("Fifth row: ");
board[4] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();
Console.WriteLine("Sixth row: ");
board[5] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();
Console.WriteLine("Seventh row: ");
board[6] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();
Console.WriteLine("Eigth row: ");
board[7] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();
Console.WriteLine("Ninth row: ");
board[8] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();

Console.WriteLine(Methods.ValidateSolution(board));