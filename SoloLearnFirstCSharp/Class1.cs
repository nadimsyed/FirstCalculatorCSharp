using System;
using System.Collections.Generic;
using System.Text;

namespace SoloLearnFirstCSharp
{
    class Calculator
    {
        public static void checkInput(string number)
        {
            var isNumeric = double.TryParse(number, out double n);
            if (!isNumeric)
            {
                Console.WriteLine("This is not a number or decimal");
                System.Environment.Exit(1);
            }

        }

       
        public static void calculate()
        {
            
            Console.Write("First number = ");
            string first_Number = Console.ReadLine();
            checkInput(first_Number);
            double firstNumber = Convert.ToDouble(first_Number);

            Console.Write("Enter operator: ");
            string arth  = Console.ReadLine();

            Console.Write("Second number = ");
            string second_Number = Console.ReadLine();
            checkInput(second_Number);
            double secondNumber = Convert.ToDouble(second_Number);

            double result = 0; 
            if  (arth == "+")
            {
                result = firstNumber + secondNumber;              
            } else if (arth == "-") {
                result = firstNumber - secondNumber;               
            } else if (arth == "*") {
                result = firstNumber * secondNumber;
            } else if (arth == "/") {
                result = firstNumber / secondNumber;               
            } else if  (arth == "%") {
                result = firstNumber % secondNumber;
            } else {
                Console.WriteLine("Error 101: This is not an operator!!");
                System.Environment.Exit(1);
            }
            Console.WriteLine("Answer is {0}", result);
        }

        

    }
}
