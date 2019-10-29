using System;

namespace A03_OXO
{
    class OXO
    {
        static string[,] board = new string[3, 3];
        static int player;

        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = "-";
                }
            }
            drawBoard();
            player = 1;
            readPlayerInput(player);
        }

        static void drawBoard()
        {
            Console.WriteLine(board[0, 0] + " " + board[0, 1] + " " + board[0, 2]);
            Console.WriteLine(board[1, 0] + " " + board[1, 1] + " " + board[1, 2]);
            Console.WriteLine(board[2, 0] + " " + board[2, 1] + " " + board[2, 2]);
        }

        static void readPlayerInput(int player)
        {
            Console.Write("Spieler " + player + " - Bitte Zug eingeben(<Reihe>.<Spalte>: ");

            string input = Console.ReadLine();

            if (input.Length != 3)
                invalidInput();

            string[] s = input.Split(".");

            int row = Convert.ToInt32(s[0]);
            int column = Convert.ToInt32(s[1]);

            if (row > 2 || column > 2)
                invalidInput();

            if (player == 1)
            {
                board[row, column] = "X";
            }
            else if (player == 2)
            {
                board[row, column] = "O";
            }

            drawBoard();
            if (player == 1)
            {
                readPlayerInput(2);
            }
            else if (player == 2)
            {
                readPlayerInput(1);
            }
        }

        static void invalidInput()
        {
            Console.WriteLine("Ungültige Eingabe. Bitte versuche es erneut.");
            readPlayerInput(player);
        }
    }
}
