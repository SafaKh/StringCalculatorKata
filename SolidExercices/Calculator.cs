using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace SolidExercices
{
    public class Calculator
    {
        
        Operator _operatorCalcule= new Operator();

        public double Calculate(string operation)
        {

            double result = 0;
            string[] substrings = operation.Split('+', '-', '/', 'x');
             

            //Gestions des exceptions 
            if (substrings.Length==1)
            {
                throw new ArgumentException(String.Format("{0} n'est pas une opération", operation));
            }



            foreach (var @operator in _operatorCalcule.Dictionary)
            {
                if (operation.Contains(@operator.Key))
                {
                    if (@operator.Key == "/" && substrings.Contains("0"))
                    {
                        if (substrings[0] != "0")
                        {
                            throw new ArgumentException(String.Format("{0} est une division par 0", operation));
                        }
                    }

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
                                throw new ArgumentException(String.Format("{0} n'est pas une chiffre", operateur));
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