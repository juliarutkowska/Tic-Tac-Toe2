namespace Tic_Tac_Toe2;

public static class BoardPrinter
{
    public static void PrintBoard(string[,] board)
    {
        Console.WriteLine();
        for (var row = 0; row < 3; row++)
        {
            Console.WriteLine($"{board[row, 0]}|{board[row, 1]}|{board[row, 2]}");
            if (row != 2)
            {
                Console.WriteLine("-+-+-");
            }
        }
        Console.WriteLine();
    }
}