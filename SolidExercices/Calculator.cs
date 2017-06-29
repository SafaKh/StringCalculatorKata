using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

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
            if (substrings.Length==1)
            {
                throw new ArgumentException(String.Format("{0} n'est pas une opération", operation));
            }

            //Gestion des opérations
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
                    int i = 1;
                    foreach (string operateur in substrings)
                    {

                        if (i == 1)
                        {
                            try
                            {
                                result = Convert.ToDouble(operateur);
                            }
                            catch
                            {
                                throw new ArgumentException(String.Format("{0} n'est pas une opération", operation));
                            }
                        }
                        else
                        {
                            result = @operator.Value(result, Convert.ToDouble(operateur));
                        }
                        i++;
                    }

                }
            }

                return result;

        }

    }
}