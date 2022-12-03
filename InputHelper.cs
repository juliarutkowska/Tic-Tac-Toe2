namespace Tic_Tac_Toe2;

public static class InputHelper
{
    public static Position GetUsersMove(string symbol)
    {
        while (true)
        {
            Console.WriteLine($"You are {symbol}. To put your {symbol} on the board please write your position (row column).");

            var line = Console.ReadLine();
            if (line is null)
            {
                Console.WriteLine("The line is null. Please, write: row column.");
                continue;
            }

            var values = line.Trim().Split(' ');
            if (values.Length != 2)
            {
                Console.WriteLine($"Write 2 values seperated by space, instead of {values.Length}.");
                continue;
            }
            
            if (int.TryParse(values[0], out var row) && int.TryParse(values[1], out var column) && row is >= 0 and <= 2 && column is <= 2 and >= 0)
            {
                return new Position(row, column);
            }
            Console.WriteLine("You put wrong input. Let's start again.");
        }
    }
}