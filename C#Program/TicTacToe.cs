using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace C_Program
{
    class TicTacToe
    {
        //2D array of spaces
            string[,] spaces = {{" ", " ", " "},{" ", " ", " "},{" ", " ", " "}};

        static public void TicTacToeGame()
        {

            TicTacToe ticAr = new TicTacToe();

            //Instructions
            Console.WriteLine("\nInstructions:\nDetermine who will be player X and who will be player O. When it is your turn, enter coordinate spaces with 0,0 being\nthe top left and 2,2 being the bottom right. Make sure you enter your coordinates in the correct format.\n");

            //Who will go first
                Random rnd = new Random();
                int turn = rnd.Next(1,3);
                switch (turn) {
                    case 1:
                        turn = 1;
                        break;
                    case 2:
                        turn = 2;
                        break;
                }

            while (true) {
                //Draw the board
                Console.WriteLine("  " + ticAr.spaces[0,0] + " | " + ticAr.spaces[0,1] + " | " + ticAr.spaces[0,2]);
                Console.WriteLine(" -----------");
                Console.WriteLine("  " + ticAr.spaces[1,0] + " | " + ticAr.spaces[1,1] + " | " + ticAr.spaces[1,2]);
                Console.WriteLine(" -----------");
                Console.WriteLine("  " + ticAr.spaces[2,0] + " | " + ticAr.spaces[2,1] + " | " + ticAr.spaces[2,2]);

                //Input
                while (true) {
                    if (turn == 1) {
                        Console.Write("Player X: ");
                        string input = Console.ReadLine();
                        string[] pos = input.Split(',');
                        int posX = Convert.ToInt32(pos[0]);
                        int posY = Convert.ToInt32(pos[1]);

                        //Check if spot is available for X
                        if (ticAr.spaces[posY,posX] == " ") {
                            ticAr.spaces[posY,posX] = "X";
                            turn = 2;
                            break;
                        } else {
                            Console.WriteLine("That space is taken, choose another space.\n");
                        }
                    } else {
                        Console.Write("Player O: ");
                        string input = Console.ReadLine();
                        string[] pos = input.Split(',');
                        int posX = Convert.ToInt32(pos[0]);
                        int posY = Convert.ToInt32(pos[1]);

                        //Check if spot is available for O
                        if (ticAr.spaces[posY,posX] == " ") {
                            ticAr.spaces[posY,posX] = "O";
                            turn = 1;
                            break;
                        } else {
                            Console.WriteLine("That space is taken, choose another space.\n");
                        }
                    }
                }

                //Check if win
                if (Row("X") == true) {
                    Win("X");
                } else if (Row("O") == true) {
                    Win("O");
                } else if (Column("X") == true) {
                    Win("X");
                } else if (Column("O") == true) {
                    Win("O");
                } else if (Diagonals("X") == true) {
                    Win("X");
                } else if (Diagonals("O") == true) {
                    Win("O");
                } else {
                    break;
                }
            }
        }

        //If win
        static public void Win(string _winner)
        {
            Console.WriteLine("\nPlayer" + _winner + " is the winner!");
            Console.ReadKey();
            Console.Clear();
            MainMenu.Main(null);
        }


        //Check rows for win
        static public bool Row(string xo)
        {
            bool win = false;
            TicTacToe ticAr = new TicTacToe();

            for (int i = 0; i < 3; i++) {
                if (ticAr.spaces[i,0] == xo && ticAr.spaces[i,1] == xo && ticAr.spaces[i,2] == xo) {
                    win = true;
                    return win;
                } else {
                    win = false;
                    return win;
                }
            }
            return win;
        }

        //Check columns for win
        static public bool Column(string xo)
        {
            bool win = false;
            TicTacToe ticAr = new TicTacToe();

            for (int i = 0; i < 2; i++) {
                if (ticAr.spaces[0,i] == xo && ticAr.spaces[1,i] == xo && ticAr.spaces[2,i] == xo) {
                    win = true;
                    return win;
                } else {
                    win = false;
                    return win;
                }
            }
            return win;
        }

        static public bool Diagonals(string xo)
        {
            bool win;
            TicTacToe ticAr = new TicTacToe();

            if ((ticAr.spaces[0,0] == xo && ticAr.spaces[1,1] == xo && ticAr.spaces[2,2] == xo) || (ticAr.spaces[2,0] == xo && ticAr.spaces[1,1] == xo && ticAr.spaces[0,2] == xo)) {
                win = true;
                return win;
            } else {
                win = false;
                return win;
            }
        }
    }
}