using System;

namespace A03_OXO
{
    class OXO
    {
        static string[,] board = new string[3, 3];
        static int player;
        static bool gameEnd = false;

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

        static void keyInput()
        {

            ConsoleKey choice;

            do{
                choice = Console.ReadKey(true).Key;
            } while(choice != ConsoleKey.D1 && choice != ConsoleKey.D2 && choice != ConsoleKey.D3 && choice != ConsoleKey.D4 && choice != ConsoleKey.D5 && choice != ConsoleKey.D6 && choice != ConsoleKey.D7 && choice != ConsoleKey.D8 && choice != ConsoleKey.D9);
        }

        static void readPlayerInput(int player)
        {
            if(!gameEnd)
            {
                Console.Write("Spieler " + player + " - Bitte Zug eingeben(<Reihe>.<Spalte>): ");

                string input = Console.ReadLine();

                if (input.Length != 3)
                {
                    invalidInput();
                    readPlayerInput(player);
                }

                string[] s = input.Split(".");

                int row = Convert.ToInt32(s[0]);
                int column = Convert.ToInt32(s[1]);

                if (row > 2 || column > 2)
                {
                    invalidInput();
                    readPlayerInput(player);
                }

                if (board[row, column] == "-")
                {
                    if (player == 1)
                    {
                        board[row, column] = "X";
                    }
                    else if (player == 2)
                    {
                        board[row, column] = "O";
                    }

                    drawBoard();
                    if(checkWinConditions(row, column))
                    {
                        displayWinMessage(player);
                        gameEnd = true;
                        return;
                    }

                    if(checkIfBoardIsFull()) {
                        displayDrawMessage();
                        gameEnd = true;
                        return;
                    }
                }
                else
                {
                    invalidInput();
                    readPlayerInput(player);
                }

                if(player == 1)
                {
                    player = 2;
                }
                else
                {
                    player = 1;
                }

                readPlayerInput(player);
            }
            else
            {
                return;
            }
        }

        static void invalidInput()
        {
            Console.WriteLine("Ungültige Eingabe. Bitte versuche es erneut.");
        }

        static bool checkWinConditions(int row, int column)
        {
            string p;
            if(player == 1)
            {
                p = "X";
            }
            else
            {
                p = "O";
            }

            if(board[row, 0] == p && board[row, 1] == p && board[row, 2] == p) 
            {
                return true;
            }
            else if(board[0, column] == p && board[1, column] == p && board[2, 1] == p)
            {
                return true;
            }
            else if(board[0, 0] == p && board[1, 1] == p && board[2, 2] == p)
            {
                return true;
            }
            else if(board[0, 2] == p && board[1,1] == p && board[2,0] == p)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool checkIfBoardIsFull() {

            int counter = 0;

            foreach(string s in board)
            {
                if(s == "-")
                    counter += 1;
            }

            if(counter > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void displayWinMessage(int player)
        {
            Console.WriteLine("Spieler " + player + " hat gewonnen!");
        }

        static void displayDrawMessage()
        {
            Console.WriteLine("Unentschieden.");
        }
    }
}