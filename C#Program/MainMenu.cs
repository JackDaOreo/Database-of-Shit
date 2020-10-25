using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading; 

namespace C_Program
{
    class MainMenu
    {
        static void Main(string[] args)
        {
            //Directory code
            while (true) {
                int directory = 0;
                Console.WriteLine("(0) Exit\n(1) Phallic Measurement\n(2) Tic-Tac-Toe\n(3) Play Ventura Highway\n(4) Prime Number Detector\n(5) Privateeyeri");
                Console.Write("Type the number of the program to execute: ");
                try
                {
                    directory = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("\nError: " + ex.Message);
                }
                switch (directory) {
                    //Exit
                    case 0:
                        System.Environment.Exit(1);
                        break;
                    //Phallic Measurement
                    case 1:
                        try
                        {
                            AllPrograms.PhallicMeasurement();
                        }
                        catch (System.Exception ex)
                        {
                            Console.WriteLine("\nError: " + ex.Message);
                        }
                        break;
                    //Tic-Tac-Toe
                    case 2:
                        Console.WriteLine("\nTicTacToe is still a work in progress, please choose another option.");
                        //try
                        //{
                        //   AllPrograms.TicTacToe(); 
                        //}
                        //catch (System.Exception ex)
                        //{
                        //    Console.WriteLine("\nError: " + ex.Message);
                        //}
                        break;
                    //Ventura Highway
                    case 3:
                        AllPrograms.VenturaHighway();
                        break;
                    //Prime Number Detector
                    case 4:
                        try
                        {
                            AllPrograms.IsPrimeNumber();
                        }
                        catch (System.Exception ex)
                        {
                            Console.WriteLine("\nError: " + ex.Message);
                        }
                        break;
                    //Privateeyeri
                    case 5:
                        System.Diagnostics.Process.Start("cmd","/c start https://privateeyeri.com/index.html#");
                        break;
                    default:
                        Console.Write("\nEnter a valid number.");
                        break;
                }

                //Wait to see result
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}