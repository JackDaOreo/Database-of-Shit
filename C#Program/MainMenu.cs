﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading; 

namespace C_Program
{
    class MainMenu
    {
        public static void Main(string[] args)
        {
            //Directory code
            while (true) {
                int directory = 0;
                Console.WriteLine("(0) Exit\n(1) Phallic Measurement\n(2) Tic-Tac-Toe\n(3) Play Ventura Highway\n(4) Prime Number Detector\n(5) www.Privateeyeri.com\n(6) Jacks Mom\n(7) Real Half Birthday Calculator\n(8) Rock Paper Scissors\n(9) Advance Rock Paper Scissors");
                Console.Write("Type the number of the program to execute: ");
                try
                {
                    directory = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("\nError: Please input an integer");
                    Console.ReadKey();
                    Console.Clear();
                    Main(null);
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
                        try
                        {
                           TicTacToe.TicTacToeGame(); 
                        }
                        catch (System.Exception ex)
                        {
                            Console.WriteLine("\nError: " + ex.Message);
                        }
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
                    //Jacks Mom
                    case 6:
                        try
                        {
                            AllPrograms.JackMom();
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("\nError: Shake it like a polaroid picture");
                        }
                        break;
                    //Real Half Birthday Calculator
                    case 7:
                        try
                        {
                            AllPrograms.RealHalfBirthday();
                        }
                        catch (System.Exception ex)
                        {
                            Console.WriteLine("\nError: " + ex.Message);
                        }
                        break;
                    //Rock Paper Scissors
                    case 8:
                        try
                        {
                            RockPaperScissors.play();
                        }
                        catch (System.Exception ex)
                        {
                            Console.WriteLine("\nError: " + ex.Message);
                        }
                        break;
                    //Advanced Rock Paper Scissors
                    case 9:
                        try
                        {
                            AllPrograms.BetterRPS();
                        }
                        catch (System.Exception ex)
                        {
                            Console.WriteLine("\nError: " + ex.Message);
                        }
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