using System;
using Xunit;
using PotentiationFinalExam.Pow;

namespace PotentiationFinalExam.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void NumberInIntegerRange_PowIsCorrect()
        {
            double result = Powlib.Pow(2, 6);

            Assert.True(result == 64, "3 to the power pof 2 should be 9");
        }
    }
}
