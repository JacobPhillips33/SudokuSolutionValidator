using SudokuSolutionValidator;

int[][] board = new int[9][];
board[0] = new int[9];

Console.WriteLine("Enter each row of numbers separated by a \",\"");
Console.WriteLine();

Console.Write("First row:   ");
board[0] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();

Console.Write("Second row:  ");
board[1] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();

Console.Write("Third row:   ");
board[2] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();

Console.Write("Fourth row:  ");
board[3] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();

Console.Write("Fifth row:   ");
board[4] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();

Console.Write("Sixth row:   ");
board[5] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();

Console.Write("Seventh row: ");
board[6] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();

Console.Write("Eigth row:   ");
board[7] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();

Console.Write("Ninth row:   ");
board[8] = Console.ReadLine().Split(",").Select(x => Int32.Parse(x)).ToArray();
Console.WriteLine();

Console.Write("Valid Sudoku Solution: ");
Console.WriteLine(Methods.ValidateSolution(board));