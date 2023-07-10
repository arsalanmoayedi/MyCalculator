using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator1
{
    class Calculator : ICalcurator
    {
        public float divine(float number1, float number2)
        {
            return number1 / number2;
        }

        public double Minus(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiple(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
