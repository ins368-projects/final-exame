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

        [Fact]
        public void NumberIsNotInDoubleRange()
        {
            double maxValue = double.MaxValue; 
            
            try
            {
                double result = Powlib.Pow(maxValue, 3);
            }
            catch(Exception e)
            {
                Assert.False(e.Message == "Número está fuera de rango positivo");
            }
        }
    }
}
