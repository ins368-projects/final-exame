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
            int result = Powlib.Pow(3, 2);

            Assert.True(result == 9, "3 to the power pof 2 should be 9");
        }
    }
}
