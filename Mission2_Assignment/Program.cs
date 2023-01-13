using System;

namespace Mission2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This changes taht title of the 
            Console.Title = "Mission #2 Assignment";

            //Variables

            int rollNum;
            int die1;
            int die2;
            int dieTotal;
            int[] counts = new int[11] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            //Start of the programe
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolse would you like to simulate? ");

            //number of roles 
            rollNum = Convert.ToInt32(Console.ReadLine());


            //Start of the for loop
            Random rnd = new Random();
            for (int i = 0; i < rollNum; i++)
            {
                //Generate Random Numbers for both die
                die1 = rnd.Next(1, 7);
                die2 = rnd.Next(1, 7);

                dieTotal = die1 + die2;


                //Add 1 to the correct total number
                counts[dieTotal - 2] = counts[dieTotal - 2] + 1;
            }

            //Results Message
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rollNum);


            for (int i = 0; i < counts.Length; i++)
            {
                //Get the Number of Stars
                int starCountNum = (int)((counts[i] / (float)rollNum) * 100);

                //Make a string of stars equal to the percent
                string starCountStr = new String('*', starCountNum);

                //Print out the line
                Console.WriteLine((i+2) + ": " + starCountStr);
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
