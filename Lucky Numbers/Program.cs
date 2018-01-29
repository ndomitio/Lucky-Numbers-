using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)

        {
            string playerAnswer = " ";
            do
            {
                int startNum;
                int endNum = 0;
                int correctGuess = 0;
                int prizeMoney = 50000;
                Random r = new Random();
                int[] lottoNumArray = new int[6];
                int[] userChoiceArray = new int[6];
                // int[] userSelectArray = new int[6]; was experimenting with the posssibilty of setting up a third array either to better satisfy a user requirement (see below), or to solve the stretch provisions for the assignment.

                Console.WriteLine("Welcome to Lucky Numbers!");
                Console.WriteLine("\nPlease enter a starting number");
                startNum = int.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease enter an ending number");

                endNum = int.Parse(Console.ReadLine());
                if (endNum < startNum)

                {
                    Console.WriteLine("\nPlease enter an ending number greater than the first number");
                    endNum = int.Parse(Console.ReadLine());
                }



                for (int i = 0; i < lottoNumArray.Length; i++)
                {
                    lottoNumArray[i] = r.Next(startNum, endNum);

                }


                Console.WriteLine("\nPlease select your lucky 6 numbers!");
                for (int i = 0; (i < userChoiceArray.Length); i++)
                {
                    userChoiceArray[i] = int.Parse(Console.ReadLine());
                    for (int j = 0; j < userChoiceArray.Length; j++)
                    {
                        if ((userChoiceArray[i] < startNum) || (userChoiceArray[i] > endNum))// played around with this for a long time, but I was not able to find a solution to 
                                                                                             //isolate each number that was out of range and just replace that one.  If, in the process of entering the 6 numbers, any number entered is outside of range,
                                                                                             //the second Console.WriteLine is activated and the user is prompted to repopulate the entire array from index 0.  Would love to find better solution down the road!
                        {
                            Console.WriteLine("Please enter 6 numbers between " + startNum + " and " + endNum);
                            userChoiceArray[i] = int.Parse(Console.ReadLine());
                        }




                    }

                }



                Console.WriteLine("\nMatch all 6 Lucky Numbers correctly and you could win a JACKPOT of $" + (prizeMoney * lottoNumArray.Length));

                for (int i = 0; i < lottoNumArray.Length; i++)
                {

                    Console.WriteLine("Lucky Number " + (i + 1) + ":  " + lottoNumArray[i]);

                }


                for (int i = 0; i < userChoiceArray.Length; i++)
                {
                    for (int k = 0; k < lottoNumArray.Length; k++)
                    {
                        if (userChoiceArray[i] == lottoNumArray[k])
                        { correctGuess++; }






                    }





                }
                Console.WriteLine("\nYou have matched " + correctGuess + " numbers and won $" + (prizeMoney * correctGuess));
                Console.WriteLine("\nWould you like to try your luck again?");
                playerAnswer = Console.ReadLine();

            } while (playerAnswer != "no");
            Console.WriteLine("\nThanks for playing!");








        }













    }









}

