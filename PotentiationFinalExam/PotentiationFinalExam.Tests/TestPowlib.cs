using System;
using Xunit;
using PotentiationFinalExam.Pow;

namespace PotentiationFinalExam.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(-100, 2, 10000)]
        [InlineData(-4, -5, -0.0009765625)]
        [InlineData(10, -2, 0.01)]
        public void NumberInDoubleRange_PowIsCorrect(double a, double b, double expectedResult)
        {
            double result = Powlib.Pow(a, b);
            Assert.True(result == expectedResult, $"Number {a} to the power of {b} is quals to {expectedResult} is true");
        }

        [Theory]
        [InlineData(double.MaxValue, 100, "Número está fuera de rango positivo")]
        [InlineData(double.MaxValue, 3, "Número está fuera de rango positivo")]

        public void NumberIsNotInDoubleRange(double a, double b, string expectedResult)
        {
            double maxValue = double.MaxValue; 
            
            try
            {
                double result = Powlib.Pow(a, b);
            }
            catch(Exception e)
            {
                Assert.False(e.Message == expectedResult);
            }
        }
    }
}
