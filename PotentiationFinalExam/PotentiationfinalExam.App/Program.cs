using System;
using static System.Console;
using PotentiationFinalExam.Pow;

namespace PotentiationfinalExam.App
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Powlib app (calcula potencias de números)\n---\n");

            Write("Digite primer número: ");
            var number1 = Double.Parse(ReadLine());

            Write("Digite segundo número: ");
            var number2 = Double.Parse(ReadLine());

            try
            {
                double result = Powlib.Pow(number1, number2);
                WriteLine($"\nResultado: {result}");
            }
            catch(Exception e)
            {
                WriteLine($"\n{e.Message}");
            }
        }
    }
}
