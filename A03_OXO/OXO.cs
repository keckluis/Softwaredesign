using System;

namespace A03_OXO
{
    class OXO
    {
        enum Player
        {
            one,
            two
        }

        static string[,] board = new string[3, 3];
        static Player player;
        static bool gameEnd = false;
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Eingabe über Numpad/ Zahlentasten (1-9).");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = "-";
                }
            }
            drawBoard();
            player = Player.one;

            while(!gameEnd)
            {
                keyInput();
            }
        }

        static void drawBoard()
        {
            Console.WriteLine(board[0, 0] + " " + board[0, 1] + " " + board[0, 2]);
            Console.WriteLine(board[1, 0] + " " + board[1, 1] + " " + board[1, 2]);
            Console.WriteLine(board[2, 0] + " " + board[2, 1] + " " + board[2, 2]);
        }

        static void keyInput()
        {
            ConsoleKey choice;
            int x = 0;
            int y = 0;

            do
            {
                choice = Console.ReadKey(true).Key;
            } while (choice != ConsoleKey.D1 && choice != ConsoleKey.D2 && choice != ConsoleKey.D3 && choice != ConsoleKey.D4 && choice != ConsoleKey.D5 && choice != ConsoleKey.D6 && choice != ConsoleKey.D7 && choice != ConsoleKey.D8 && choice != ConsoleKey.D9);

            switch (choice)
            {
                case ConsoleKey.D1:
                    x = 2;
                    y = 0;
                    break;
                case ConsoleKey.D2:
                    x = 2;
                    y = 1;
                    break;
                case ConsoleKey.D3:
                    x = 2;
                    y = 2;
                    break;
                case ConsoleKey.D4:
                    x = 1;
                    y = 0;
                    break;
                case ConsoleKey.D5:
                    x = 1;
                    y = 1;
                    break;
                case ConsoleKey.D6:
                    x = 1;
                    y = 2;
                    break;
                case ConsoleKey.D7:
                    x = 0;
                    y = 0;
                    break;
                case ConsoleKey.D8:
                    x = 0;
                    y = 1;
                    break;
                case ConsoleKey.D9:
                    x = 0;
                    y = 2;
                    break;
            }

            setValue(x, y);
        }

        static void setValue(int x, int y)
        {
            if (board[x, y] == "-")
            {
                Console.Clear();
                if (player == Player.one)
                {
                    board[x, y] = "X";
                }
                else
                {
                    board[x, y] = "O";
                }

                drawBoard();
                if (checkWinConditions(x, y))
                {
                    displayWinMessage(player);
                    gameEnd = true;
                    return;
                }
                else if (checkIfBoardIsFull())
                {
                    displayDrawMessage();
                    gameEnd = true;
                    return;
                }

                if (player == Player.one)
                {
                    player = Player.two;
                }
                else
                {
                    player = Player.one;
                }
            }
        }

        static bool checkWinConditions(int x, int y)
        {
            string value;
            if (player == Player.one)
            {
                value = "X";
            }
            else
            {
                value = "O";
            }

            if (board[x, 0] == value && board[x, 1] == value && board[x, 2] == value)
            {
                return true;
            }
            else if (board[0, y] == value && board[1, y] == value && board[2, y] == value)
            {
                return true;
            }
            else if (board[0, 0] == value && board[1, 1] == value && board[2, 2] == value)
            {
                return true;
            }
            else if (board[0, 2] == value && board[1, 1] == value && board[2, 0] == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool checkIfBoardIsFull()
        {
            int counter = 0;

            foreach (string s in board)
            {
                if (s == "-")
                    counter += 1;
            }

            if (counter > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void displayWinMessage(Player player)
        {
            int p;

            if (player == Player.one)
            {
                p = 1;
            }
            else
            {
                p = 2;
            }
            Console.WriteLine("Spieler " + p + " hat gewonnen!");
        }

        static void displayDrawMessage()
        {
            Console.WriteLine("Unentschieden.");
        }
    }
}