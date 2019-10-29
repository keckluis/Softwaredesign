using System;

namespace A03_OXO
{
    class OXO
    {
        static int[,] board = new int[3, 3];
        static int player;

        static void Main(string[] args)
        {
            drawBoard();
            player = 1;
            readPlayerInput(player);
        }

        static void drawBoard()
        {
            string[] one = new string[3];

            for (int i = 0; i < one.Length; i++)
            {
                if (board[0, i] == 0)
                {
                    one[i] = " ";
                }
                else if (board[0, i] == 1)
                {
                    one[i] = "X";
                }
                else if (board[0, i] == 2)
                {
                    one[i] = "O";
                }
            }

            string[] two = new string[3];

            for (int i = 0; i < two.Length; i++)
            {
                if (board[1, i] == 0)
                {
                    two[i] = " ";
                }
                else if (board[1, i] == 1)
                {
                    two[i] = "X";
                }
                else if (board[1, i] == 2)
                {
                    two[i] = "O";
                }
            }

            string[] three = new string[3];

            for (int i = 0; i < one.Length; i++)
            {
                if (board[2, i] == 0)
                {
                    three[i] = " ";

                }
                else if (board[2, i] == 1)
                {
                    three[i] = "X";

                }
                else if (board[2, i] == 2)
                {
                    three[i] = "O";
                }
            }

            Console.WriteLine("  - - -  ");
            Console.WriteLine("| " + one[0] + " " + one[1] + " " + one[2] + " |");
            Console.WriteLine("| " + two[0] + " " + two[1] + " " + two[2] + " |");
            Console.WriteLine("| " + three[0] + " " + three[1] + " " + three[2] + " |");
            Console.WriteLine("  - - -  ");
        }

        static void readPlayerInput(int player)
        {
            Console.Write("Spieler " + player + " - Bitte Zug eingeben(<Reihe>.<Spalte>: ");
            
            string input = Console.ReadLine();

            if(input.Length != 3)
            {
                invalidInput();
            }

            string[] s = input.Split(".");

            int row = Convert.ToInt32(s[0]);
            int column = Convert.ToInt32(s[1]);

            if(row > 3 || row < 1) 
            {
                invalidInput();
            }
            if(column > 3 || column < 1) 
            {
                invalidInput();
            }

            board[row,column] = player;
            drawBoard();
        }

        static void invalidInput()
        {
            Console.WriteLine("Ungültige Eingabe. Bitte versuche es erneut.");
            readPlayerInput(player);
        }
    }
}
