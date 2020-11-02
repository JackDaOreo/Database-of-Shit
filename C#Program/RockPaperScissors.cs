using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace C_Program
{
    class RockPaperScissors
    {
        static public void play()
        {   
            int poneScore = 0;
            int ptwoScore = 0;
            Random freeWill = new Random();
            int poneChoice;
            int ptwoChoice;

            System.Console.WriteLine("Two complex AI's will now play rock paper scissors against each other");

            while(poneScore <= 1 && ptwoScore <= 1)
            {

                // Complex AI's decide on their next move
                poneChoice = freeWill.Next(0, 3);
                ptwoChoice = freeWill.Next(0, 3);

                // They compete in an epic duel
                //0 = rock
                //1 = paper
                //2 = scissors

                // tie
                if(poneChoice == ptwoChoice){}

                // player one chooses rock
                else if(poneChoice == 0){
                    if(ptwoChoice == 1){
                        ptwoScore += 1;
                    }else{
                        poneScore += 1;
                    }
                }
                // player one chooses paper
                else if(poneChoice == 1){
                    if(ptwoChoice == 2){
                        ptwoScore += 1;
                    }else{
                        poneScore += 1;
                    }
                }
                // player one chooses scissors
                else{
                    if(ptwoChoice == 0){
                        ptwoScore += 1;
                    }else{
                        poneScore += 1;
                    }
                }
            }
            if(poneScore > ptwoScore){
                System.Console.WriteLine("Player One Wins");
            }else{
                System.Console.WriteLine("Player Two Wins");
            }


        }

    }
}