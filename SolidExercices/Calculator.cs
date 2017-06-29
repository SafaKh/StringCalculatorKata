using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {

             double result = 0;
             string[] substrings = operation.Split('+', '-', '/', 'x');
             

             if(substrings.Length > 2)
             {
                throw new ArgumentException(String.Format("{0} n'est pas une opération à deux opérateur", operation));
             }

             //Convertion des opérateurs 
             double oper1 = Convert.ToDouble(substrings.GetValue(0));
             double oper2 = Convert.ToDouble(substrings.GetValue(1));

            Func<double, double, double> addition = (a, b) => a + b;
            Func<double, double, double> divide = (a, b) => a / b;
            Func<double, double, double> multiply = (a, b) => a * b;
            Func<double, double, double> substract = (a, b) => a - b;
            Dictionary<string, Func<double, double, double>> dictionary = new Dictionary<string, Func<double, double, double>>();
            dictionary.Add("+", addition);
            dictionary.Add("/", divide);
            dictionary.Add("x", multiply);
            dictionary.Add("-", substract);

            foreach (var @operator in dictionary)
            {
                if (operation.Contains(@operator.Key))
                {
                   result= @operator.Value(oper1, oper2);
                }
            }

                return result;

        }

    }
}