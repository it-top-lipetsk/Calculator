using System;
using Calculator.Lib;

namespace Calculator.ConsoleTestApp
{
    class Program
    {
        static void Main()
        {
            var x = 5;
            var y = 10;
            var y_error = 0;

            var add = Calc.Add(x, y);
            Console.WriteLine($"{x} + {y} = {add}");

            var div = Calc.Div(x, y);
            Console.WriteLine($"{x} / {y} = {div}");

            try
            {
                var div_error = Calc.Div(x, y_error);
                Console.WriteLine($"{x} / {y_error} = {div}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Делить на ноль нельзя!");
            }
        }
    }
}