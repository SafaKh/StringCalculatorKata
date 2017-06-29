using System;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        readonly OperationGenerator _operation;

        public CalculatorTrainer(OperationGenerator operation)
        {
            _operation = operation;
        }


        public void Run()
        {
            var calculator = new Calculator();
            foreach (var operation in _operation.GetOperation())
            {
                try
                {
                    var result = calculator.Calculate(operation);
                    Console.WriteLine(operation + " = " + result);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
            Console.ReadKey();
        }
      
    }
}
