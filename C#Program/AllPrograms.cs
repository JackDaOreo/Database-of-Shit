using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace C_Program
{
    class AllPrograms
    {
        static public void BetterRPS()
        {
            //Setup
            Random rnd = new Random();
            Console.WriteLine("\nYour computer will now expierence an epic duel between two professionally\ntrained rock-paper-scissors AI. Hit any key to begin.");
            Console.ReadKey();
            Console.Write("Processing");
            for (int i = 0; i < 3; i++) {
                Thread.Sleep(2000);
                Console.Write(" .");
            }
            Thread.Sleep(2000);

            //Determine winner
            int winner = rnd.Next(0,2);
            switch (winner) {
                case 0:
                    Console.WriteLine("\nPlayer One has won.");
                    break;
                case 1:
                    Console.WriteLine("\nPlayer Two has won.");
                    break;
            }
        }

        static public void JackMom()
        {
            Console.WriteLine("Welcome to JacksMom, an interactive experience.");
            Console.Write("Input something: ");
            string x = Console.ReadLine();
            Console.WriteLine("Hahaha, Jack's mom");
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
                    Console.Write("\nYou're lying. ");
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

        static public void RealHalfBirthday()
        {
            // Getting input and splitting months from days
            Console.WriteLine("Input your birthday in mm/dd format, for exampple: 01/23 is January 23");
            string bDay = Console.ReadLine();
            
            // Check for leap year
            Console.WriteLine("Is it a leap year? y/n");
            string lYear = Console.ReadLine();
            bool islYear = false;
            if (lYear == "y") {
                islYear = true;
            } else if (lYear == "n") {
                islYear = false;
            } else {
                Console.WriteLine("Fuck you, you had one job.");
            }
            string[] date = bDay.Split('/');

            // Indexing names of months and number of days into the year at the beginning of each month
            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            int[] daysIn = {0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 335};

            // Find number of days into the year that half birthday is
            int bDaysIn = daysIn[Convert.ToInt16(date[0])-1] + Convert.ToInt16(date[1]);
            int hbDayIn = bDaysIn + 182;
            if(hbDayIn > 365) {
                hbDayIn -= 365;
            }

            // Find month and day of half birthday
            string hbMonth = "";
            int hbDay = 0;
            int iters = 0;
            foreach (int x in daysIn) {
                iters += 1;
                if (hbDayIn < x) {
                    // Apply Leap Year
                    if(iters-2 >= 2 && islYear == true){
                        hbDayIn += 1;
                        }
                    hbDay = hbDayIn - daysIn[iters-2];
                    hbMonth = months[iters-2];
                    break;
                }
            }

            // Output
            Console.WriteLine("Your half birthday this year is/was: " + hbMonth + " " + hbDay );
        }
    }
}