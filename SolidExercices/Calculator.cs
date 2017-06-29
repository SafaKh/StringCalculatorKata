using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {


            double result = 0; 
            string[] substrings = operation.Split('+','-','/','x');
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
 
            throw new NotImplementedException();
        }
    }
}