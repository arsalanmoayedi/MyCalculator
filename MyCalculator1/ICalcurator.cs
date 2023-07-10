using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator1
{
    interface ICalcurator
    {
        double Sum(double number1, double number2);
        double Multiple(double number1, double number2);
        double Minus(double number1, double number2);
        float divine(float number1, float number2);

    }
}
