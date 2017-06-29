using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {


            
            
                double result = 0;
                string[] substrings = operation.Split('+', '-', '/', 'x');
                if (substrings.Length == 2)
                {
                    Console.WriteLine("{0} n'est pas une opération à deux opérateur", operation);
                }
                if (operation.Contains("+"))
                {
                    result = Convert.ToDouble(substrings.GetValue(0)) + Convert.ToDouble(substrings.GetValue(1));
                }
                else if (operation.Contains("/"))
                {
                    result = Convert.ToDouble(substrings.GetValue(0)) / Convert.ToDouble(substrings.GetValue(1));
                }
                else if (operation.Contains("x"))
                {
                    result = Convert.ToDouble(substrings.GetValue(0)) * Convert.ToDouble(substrings.GetValue(1));
                }
                else if (operation.Contains("/"))
                {
                    result = Convert.ToDouble(substrings.GetValue(0)) / Convert.ToDouble(substrings.GetValue(1));
                }
                return result;



        }
    }
}