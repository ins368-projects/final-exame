using System;

namespace PotentiationFinalExam.Pow
{
    public class Powlib
    {
        public static double Pow(double a, double b)
        {
            double maxValue = double.MaxValue;
            double result = Math.Pow(a, b);

            if(Double.IsInfinity(result))
                throw new System.InvalidOperationException("Número está fuera de rango positivo");
            
            return result;
        }
    }
}
