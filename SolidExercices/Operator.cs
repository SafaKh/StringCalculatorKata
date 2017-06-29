using System;
using System.Collections.Generic;

namespace SolidExercices
{
    class Operator
    {
        //Gestion des opérations par un dictionnaire

       public Dictionary<string, Func<double, double, double>> Dictionary = new Dictionary<string, Func<double, double, double>>
        {
            {"+", (a, b) => a + b},
            {"/", (a, b) => a / b},
            {"x", (a, b) => a * b},
            {"-", (a, b) => a - b}

        };
    }
}
