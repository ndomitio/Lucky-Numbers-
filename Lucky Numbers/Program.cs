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
            string playerAnswer = " ";//
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

                Console.WriteLine("\nPlease enter an ending number");//set up variables at the beginning, and added line breaks this week to the project for a cleaner look.  

                endNum = int.Parse(Console.ReadLine());
                
                
                for (int i = 0; i < lottoNumArray.Length; i++) // I was thinking the solution to the stretch might have involved the test expression.  I also tried nested for loop and and if statement 
                    //within the for loop.  
                {
                    lottoNumArray[i] = r.Next(startNum, endNum);

                }


                Console.WriteLine("\nPlease select your lucky 6 numbers!");
                for (int i = 0; (i < userChoiceArray.Length); i++)
                {
                    userChoiceArray[i] = int.Parse(Console.ReadLine());
                }
                while ((userChoiceArray[0] < startNum) || (userChoiceArray[0] > endNum) || (userChoiceArray[1] < startNum) || (userChoiceArray[1] > endNum) || 
                    (userChoiceArray[2] < startNum) || (userChoiceArray[2] > endNum) || (userChoiceArray[3] < startNum) || (userChoiceArray[3] > endNum) || 
                    (userChoiceArray[4] < startNum) || (userChoiceArray[4] > endNum) || (userChoiceArray[5] < startNum) || (userChoiceArray[5] > endNum)) 
                    {
                    Console.WriteLine("Please enter 6 numbers between " + startNum + " and " + endNum);
                    for (int j = 0; j < userChoiceArray.Length; j++)
                    {


                        userChoiceArray[j] = int.Parse(Console.ReadLine());
                    }
                }//is there a better way to do this? had to take the while statement outside of the previous for statement because the code kept on crashing.  The 12 or statements
               //seemed like overkill, but it worked.    














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

