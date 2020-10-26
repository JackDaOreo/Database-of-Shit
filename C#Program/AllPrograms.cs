using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace C_Program
{
    class AllPrograms
    {

        static public void JackMom()
        {
            Console.WriteLine("Welcome to JacksMom, an interactive experience.");
            Console.Write("Input something: ");
            string x = Console.ReadLine();
            Console.WriteLine(x);
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