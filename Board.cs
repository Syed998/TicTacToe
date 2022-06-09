using System;

class Board
{
    static int DIMENSION = 3;

    private int[,] board;

    public int winner;

    public Board()
    {
        board = new int[DIMENSION, DIMENSION];

        for (int i = 0; i < DIMENSION; i++)
        {
            for (int j = 0; j < DIMENSION; j++)
            {
                board[i, j] = 0;
            }
        }
        winner = 0;
    }

    public Boolean addMove(int player, int board_position)
    {
        Boolean result = false;
        switch (board_position)
        {
            case 1:
                if (board[0, 0] == 0)
                {
                    board[0, 0] = player;
                    result = true;
                }
                return true;
            case 2:
                if (board[0, 1] == 0)
                {
                    board[0, 1] = player;
                    result = true;
                }
                break;
            case 3:
                if (board[0, 2] == 0)
                {
                    board[0, 2] = player;
                    result = true;
                }
                break;
            case 4:
                if (board[1, 0] == 0)
                {
                    board[1, 0] = player;
                    result = true;
                }
                break;
            case 5:
                if (board[1, 1] == 0)
                {
                    board[1, 1] = player;
                    result = true;
                }
                break;
            case 6:
                if (board[1, 2] == 0)
                {
                    board[1, 2] = player;
                    result = true;
                }
                break;
            case 7:
                if (board[2, 0] == 0)
                {
                    board[2, 0] = player;
                    result = true;
                }
                break;
            case 8:
                if (board[2, 1] == 0)
                {
                    board[2, 1] = player;
                    result = true;
                }
                break;
            case 9:
                if (board[2, 2] == 0)
                {
                    board[2, 2] = player;
                    result = true;
                }
                break;
        }
        return result;
    }

    public Boolean check_for_full()
    {
        Boolean result = false;
        int count = 0;

        for (int i = 0; i < DIMENSION && count < 9; i++)
        {
            for (int j = 0; j < DIMENSION; j++)
            {
                if (board[i, j] != 0)
                {
                    count++;
                }
            }
        }
        if (count == 8)
        {
            result = true;
        }

        return result;
    }

    public void toString()
    {
        for (int i = 0; i < DIMENSION; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < DIMENSION; j++)
            {
                if (board[i, j] == 0)
                {
                    Console.Write('.');
                }
                if (board[i, j] == 1)
                {
                    Console.Write('X');
                }
                if (board[i, j] == 2)
                {
                    Console.Write('O');
                }
                Console.Write(" | ");
            }
            Console.WriteLine();
        }
    }

    public Boolean win_result()
    {
        // ROWS
        if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != 0) { winner = board[0, 0]; return true; }
        if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != 0) { winner = board[1, 0]; return true; }
        if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != 0) { winner = board[2, 0]; return true; }

        //COLS
        if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != 0) { winner = board[0, 0]; return true; }
        if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] != 0) { winner = board[0, 1]; return true; }
        if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != 0) { winner = board[0, 2]; return true; }

        //DIAGONALS
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0) { winner = board[0, 0]; return true; }
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[1, 1] != 0) { winner = board[1, 1]; return true; }

        return false;
    }
}