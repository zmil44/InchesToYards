/*Zachary Miller
 * 11/26/2017
 * assignment 4.3
 * The purpose of this program is to take user inputted length in inches and display the same length in yards, feet, and inches
 * InchesToYards.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._3
{
    class InchesToYards
    {
        static void Main(string[] args)
        {
            int input = getInput();
            int yards = 0;
            yards = calculateYards(input);
            int feet = calculateFeet(input);
            int inches = calculateInches(input);
            displayOutput(input, yards, feet, inches);
            Console.Read();
        }

        private static int getInput()
        {
            int inches = 0;
            Boolean correctInput;

            do
            {
                Console.Write("Please enter a length in inches: ");
                string input = Console.ReadLine();
                try
                {
                    inches = int.Parse(input);
                    correctInput = true;
                }
                catch (FormatException)
                {
                    correctInput = false;
                    Console.WriteLine("\n I'm sorry but the number you entered is invalid. Please enter a valid number greater than 0 in number format. EX: 250. \n");
                }
                catch (OverflowException)
                {
                    correctInput = false;
                    Console.WriteLine("\n I'm sorry but the number you entered is invalid. Please enter a valid number greater than 0 in number format. EX:");
                }
            } while (correctInput == false && inches > 0);
            return inches;
        }

        private static int calculateFeet(int input)
        {
            int feet = input / 12;
            while (feet >= 3)
            {
                feet -= 3;
            }
            return feet;
        }

        private static int calculateInches(int input)
        {
            int inches = input % 12;
            return inches;
        }

        private static int calculateYards(int input)
        {
            int yards = input/36;
            return yards;
        }

        private static void displayOutput(int input, int yards, int feet, int inches)
        {
            Console.Write("{0} inches is equivalent to {1} yard(s), {2} ", input, yards, feet);
            if (feet <= 1)
                Console.Write("foot, {0} inch(es).", inches);
            else
                Console.Write("feet, {0} inch(es)", inches);
        }
    }
}
