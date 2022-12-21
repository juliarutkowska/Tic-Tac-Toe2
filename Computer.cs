namespace Tic_Tac_Toe2;

public static class Computer
{
    private static readonly Random Random = new ();

    public static void Move(Symbol[,] board, Symbol symbol)
    {
        var emptyPositions = new List<Position>();

        for (var row = 0; row < 3; row++)
        {
            for (var column = 0; column < 3; column++)
            {
                if (board[row, column] == Symbol.None)
                {
                    emptyPositions.Add(new Position(row, column));
                }
            }
        }

        var index = Random.Next(emptyPositions.Count);
        var chosenEmptyPosition = emptyPositions[index];

        board[chosenEmptyPosition.Row, chosenEmptyPosition.Column] = symbol;

        BoardPrinter.PrintBoard(board);
    }
}