/*
Author: Dank Mitchell
Date: 8 Oct 2024
Assignment: PA2
*/

using System;

namespace Module2
{
    internal class Program
    {
        static void Main()
        {
            // Task2 Part 1
            #region Task2 Part 1
            // Declare int variable set to max value
            int maxValue = int.MaxValue;

            // Print Value as normal int and Hex format
            Console.WriteLine($"Fixed sized ints");
            Console.WriteLine($"\tmyInt Max Value: \t{maxValue} \t{maxValue:X}");

            // Increment variable by one
            maxValue++;
            Console.WriteLine($"\tmyInt after increment: \t{maxValue} \t{maxValue:X}");

            // Set Variable to zero
            maxValue = 0;
            Console.WriteLine($"\tmyInt zero: \t\t{maxValue} \t\t{maxValue:X}");

            // Decrement variable by one
            maxValue--;
            Console.WriteLine($"\tmyInt -1: \t\t{maxValue} \t\t{maxValue:X}");
            #endregion

            // Casting Section
            #region Casting
            // Declare int variable set to max value
            int intValue = int.MaxValue;

            // Using casting declare a short variable and initialize its value to the int variable
            short shortValue = (short)intValue;

            // Print Value as normal int and Hex format
            Console.WriteLine($"Casting");
            Console.WriteLine($"\tmyInt max value: \t{intValue} \t{intValue:X}");

            // Print short variable in normal in and Hex format
            Console.WriteLine($"\tmyShort: \t\t{shortValue} \t\t{shortValue:X}");
            #endregion

            // Loops Section
            #region Loops
            //Declare array of ints of size 5
            int[] myInts = new int[5];

            // Use loop to initialize the values in range 1-5
            for (int i = 0; i < myInts.Length; i++)
            {
                myInts[i] = i + 1;
            }

            // Use foreach loop to print array values on single line
            Console.WriteLine($"Loops");
            Console.Write("\t");
            foreach (int number in myInts) 
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
            #endregion

            // Loops Bonus Section
            #region Loops Bonus
            // Create and Print a multiplication table
            Console.WriteLine($"\tMultiplication table");
            Console.WriteLine($"\t\t1\t2\t3\t4\t5");
            Console.WriteLine($"\t---------------------------------------------");

            // Use for loop to iterate 1-5 by 1-5 into a table
            // Set five rows
            for(int i = 1; i <= 5; i++)
            {
                Console.Write($"\t{i} |\t");
                // Set five columns
                for (int j = 1; j <= 5; j++)
                {
                    // Evaluate to single value and output
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            // Printer Troubleshooter
            #region Printer troubleshooter
            // Declare String variable to hold condition information
            string condition = string.Empty;
            Console.WriteLine($"Printer Diagnostics");

            // Ask 3 status questions and update condition variable with Y or N
            Console.Write($"\tDoes the printer print (Y/N)? ");
            condition = Console.ReadLine();

            Console.Write($"\tIs the printer recongnized by the computer (Y/N)? ");
            condition = condition + Console.ReadLine();

            Console.Write($"\tIs the red light flashing (Y/N)? ");
            condition = condition + Console.ReadLine();
            Console.WriteLine();

            // Console.WriteLine(condition);

            // Create switch statement of 8 possiblites and default condition
            string action1 = "\tCheck the power cable\n";
            string action2 = "\tCheck the print-computer cable\n";
            string action3 = "\tEnsure printer software is installed\n";
            string action4 = "\tCheck/replace ink\n";
            string action5 = "\tCheck for paper jam\n";

            switch (condition)
            {
                case "NYN":
                    Console.WriteLine(action2 + action3 + action4);
                    break;
                case "NYY":
                    Console.WriteLine(action4 + action5);
                    break;
                case "NNN":
                    Console.WriteLine(action1 + action2 + action3);
                    break;
                case "NNY":
                    Console.WriteLine(action5);
                    break;
                case "YYN":
                    Console.WriteLine(action3);
                    break;
                case "YYY":
                    Console.WriteLine(action4);
                    break;
                case "YNN":
                    Console.WriteLine(action3);
                    break;
                case "YNY":
                    Console.WriteLine("\tFind nearest window\n\tOpen window\n\tThrow printer out window");
                    break;
                default:
                    Console.WriteLine("\tUser input does not match requested response options");
                    break;
            }
            Console.WriteLine();
            #endregion

        }
    }
}
