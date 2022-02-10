using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Joshua Farrell
// ID: M153428
// Date: 10 February 2022
// Program descrption:
// This program reads an input and tests if it is
// greater than or less than a constant value (e.g., 10)

namespace IOCA2Act2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int inputValue;
            bool inputOK;
            const int constantValue = 10;

            // Read an input from the user and test if it is an integer
            Console.Write("Enter a number: ");
            inputOK = int.TryParse(Console.ReadLine(), out inputValue);

            // Test if the input value is an integer
            if (inputOK)
            {
                // Test if the input value is greater or less than the constant value
                if (inputValue > constantValue)
                {
                    Console.WriteLine("Your number {0} is greater than the constant {1}", inputValue, constantValue);
                }// IF inputValue > constantValue
                else if (inputValue < constantValue)
                {
                    Console.WriteLine("Your number {0} is lesser than the constant {1}", inputValue, constantValue);
                }// ELSE IF inputValue < constantValue
                else
                {
                    Console.WriteLine("Your number {0} is equal to the constant {1}", inputValue, constantValue);
                }// ELSE inputValue
            }// IF inputOK
            else // If inputOK is false (inputValue is NOT an integer) then display an error
            {
                Console.WriteLine("ERROR: Please enter an integer number.");
            }// ELSE inputOK
        }
    }
}
