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
                Console.WriteLine("(0) Exit\n(1) Phallic Measurement\n(2) EMPTY\n(3) Play Ventura Highway\n(4) Prime Number Detector");
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
                        AllPrograms.PhallicMeasurement();
                        break;
                    //EMPTY
                    case 2:
                        break;
                    //Ventura Highway
                    case 3:
                        AllPrograms.VenturaHighway();
                        break;
                    //Prime Number Detector
                    case 4:
                        AllPrograms.IsPrimeNumber();
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