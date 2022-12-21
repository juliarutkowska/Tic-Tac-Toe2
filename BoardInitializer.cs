namespace Tic_Tac_Toe2;

public static class BoardInitializer
{
    public static Symbol[,] InitializeToBoard()
    {
        var board = new Symbol[3,3];

        for (var row = 0; row < 3; row++)
        {
            for (var column = 0; column < 3; column++)
            {
                board[row, column] = Symbol.None;
            }
        }

        return board;
    }
}