using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace C_Program
{
    class AllPrograms
    {

        static public void TicTacToe()
        {
            //2D array of spaces
            string[,] spaces = {
                {" ", " ", " "},
                {" ", " ", " "},
                {" ", " ", " "}
            };

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
                Console.WriteLine("  " + spaces[0,0] + " | " + spaces[0,1] + " | " + spaces[0,2]);
                Console.WriteLine(" -----------");
                Console.WriteLine("  " + spaces[1,0] + " | " + spaces[1,1] + " | " + spaces[1,2]);
                Console.WriteLine(" -----------");
                Console.WriteLine("  " + spaces[2,0] + " | " + spaces[2,1] + " | " + spaces[2,2]);

                //Input
                while (true) {
                    if (turn == 1) {
                        Console.Write("Player X: ");
                        string input = Console.ReadLine();
                        string[] pos = input.Split(',');
                        int posX = Convert.ToInt32(pos[0]);
                        int posY = Convert.ToInt32(pos[1]);

                        //Check if spot is available for X
                        if (spaces[posY,posX] == " ") {
                            spaces[posY,posX] = "X";
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
                        if (spaces[posY,posX] == " ") {
                            spaces[posY,posX] = "O";
                            turn = 1;
                            break;
                        } else {
                            Console.WriteLine("That space is taken, choose another space.\n");
                        }
                    }
                }

                //Check if win
                //Row
                for (int i = -1; i < 2; i++) {
                    if (spaces[i,0] != " " && spaces[i,1] != " " && spaces[i,2] != " ") {

                    }
                }
            }
        }

        static public void PhallicMeasurement()
        {
            double length = 0;

            //Input
            while (true){
                Console.Write("What is the size of your penis (in): ");
                length = Convert.ToDouble(Console.ReadLine());

                //Percent calc
                double percent = 5.4 - length;
                percent = percent / 5.4;
                percent = percent * 100;
                percent = Math.Round(percent, 2);
                percent = Math.Abs(percent);
                //End calc

                if (length > 5.4) {
                    Console.Write("\nYour lying. ");
                } else if (length < 5.4) {
                    Console.WriteLine("\nThank you for your honesty. Your penis size is now saved in the database.\n\nFun fact: your penis is " + percent +"% below the average.");
                    break;
                } else {
                    Console.WriteLine("\nThank you for your honesty. Your penis size is now saved in the database.\n\nFun fact: your penis is exactly average.");
                    break;
                }
            }
        }

        static public void VenturaHighway()
        {
            Random rnd = new Random();
            int vid = rnd.Next(1,11);
            if (vid <= 2) {
                //rick
                System.Diagnostics.Process.Start("cmd","/c start https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            } else {
                //ventura
                System.Diagnostics.Process.Start("cmd","/c start https://www.youtube.com/watch?v=tnV7dTXlXxs");
            }
        }

        static public void IsPrimeNumber()
        {
            bool ans = false;
            int input;

            //Input
            Console.Write("\nEnter an integer: ");
            input = Convert.ToInt32(Console.ReadLine());

            //Exceptions to the rule
            switch(input) {
                case 1:
                    ans = false;
                    break;
                case 2:
                    ans = true;
                    break;
                case 3:
                    ans = true;
                    break;
                case 5:
                    ans = true;
                    break;
                default:
                    break;
            }

            //test if prime number
            for (int i = input - 1; i > 1; i--) {  
                if (input % i == 0) {
                    ans = false;
                    break;
                } else {
                    ans = true;
                }
            }

            //Output
            if (ans == false) {
                Console.WriteLine("\n" + input + " is not a prime number.");
            } else {
                Console.WriteLine("\n" + input + " is a prime number.");
            }
        }
    }
}