namespace Tic_Tac_Toe2;

public static class WinChecker
{
    public static bool CheckWinner(string[,] board, string symbol)
    {
        // Check if there are 3 symbols in any row
        for (var row = 0; row < 3; row++)
        {
            var symbolOccurrencesInARow = 0;
            for (var column = 0; column < 3; column++)
            {
                var squareValue = board[row, column];
                if (squareValue == symbol)
                {
                    symbolOccurrencesInARow++;
                }
            }

            if (symbolOccurrencesInARow == 3)
            {
                return true;
            }
        }
        
        // Check if there are 3 symbols in any row
        for (var column = 0; column < 3; column++)
        {
            var symbolOccurrencesInAColumn = 0;
            for (var row = 0; row < 3; row++)
            {
                var squareValue = board[row, column];
                if (squareValue == symbol)
                {
                    symbolOccurrencesInAColumn++;
                }
            }

            if (symbolOccurrencesInAColumn == 3)
            {
                return true;
            }
        }
        
        // Check first diagonal
        if (board[0, 0] == symbol 
           && board[1, 1] == symbol
           && board[2, 2] == symbol)
        {
            return true;
        }
        
        // Check second diagonal
        if (board[0, 2] == symbol
            && board[1, 1] == symbol
            && board[0, 0] == symbol)
        {
            return true;
        }

        return false;
    }
}