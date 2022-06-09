using System;

class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        Console.WriteLine("****************** TIC-TAC-TOE ********************\n");

        //This will alternate every turn to indicate which player is playing.
        int current_player = 1;

        while (!board.check_for_full() && !board.win_result())
        {

            Console.Write("Player-> " + current_player + ", Enter a number between 1 and 9: ");
            int current_move = Convert.ToInt16(Console.ReadLine());
            if (board.addMove(current_player, current_move))
            {
                if (current_player == 1)
                {
                    current_player = 2;
                }
                else
                {
                    current_player = 1;
                }
            }
            board.toString();

        }
        switch (board.winner)
        {
            case 0:
                Console.WriteLine("\nDRAW...No one wins!");
                break;
            case 1:
                Console.WriteLine("\nPlayer-> 1 WINS!!!");
                break;
            case 2:
                Console.WriteLine("\nPlayer-> 2 WINS!!!");
                break;
        }
        Console.WriteLine("\n****************** GAME OVER **********************");
        Console.Write("\nPress ANY button to EXIT.");
        Console.ReadKey();

    }
}
