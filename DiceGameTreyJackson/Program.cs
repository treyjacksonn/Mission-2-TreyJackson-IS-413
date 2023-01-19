// Trey Jackson
// IS 413
// Section 1, Group 12

using System;

namespace DiceGameTreyJackson
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random(); // import Random function for dice rolls

            Console.WriteLine("Welcome to my dice rolling simulator!\n");  

            Console.WriteLine("How many roles do you want to do?"); // Determines how many rolls the user wants to do 
            int rolls = Convert.ToInt32(Console.ReadLine()); // assigns value to variable rolls

            int[] newArray = new int [11]; // array to hold the combination of the dice


            // for loop to roll the dice equal to the rolls variable
            for (int i = 0; i < rolls; i++)
            {
                // rolling to two dice
                int roll = r.Next(6); 
                int rollTwo = r.Next(6);

                // finding the combination rolled
                int combo = roll + rollTwo;

                // adding the combination to the newArray array in the corresponding position
                newArray[combo]++;
            }


            // for loop to convert the combinations amount to the corresponding amount of asterisks
            for (int i = 0; i < 11; i++)
            {
                // if the position has a value enter this loop to find how many asterisks it neecds
                if (newArray[i] > 0)
                {

                    // determine the percentage of the total rolls made up by each combination
                    double percent = ((Convert.ToDouble(newArray[i]) / Convert.ToDouble(rolls)) * 100.0);

                    // assign the corresponding amount of astericks per combination to the variable asterisk
                    int asterisk = Convert.ToInt32(Math.Round(percent));

                    // print the current position in the array
                    Console.Write("\n" + (i + 2) + ": ");

                    // nested for loop used to print out the amount of asterisks that correspond to the calcualted amount in the loop above
                    for (int j = 0; j < asterisk; j++)
                    {
                        Console.Write("*");
                    }
                }

                // else statements progresses the array to the next position if there is a value of zero for that particular position in the array
                else
                {
                    Console.Write("\n" + (i + 2) + ": ");
                }
            }

            // ending line
            Console.WriteLine("\n\nThank you for using the dice throwing simulator. Goodbye!");

        }

    }
}
