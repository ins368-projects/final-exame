using System;
using Xunit;
using PotentiationFinalExam.Pow;

namespace PotentiationFinalExam.Tests
{
    public class UnitTest1
    {
        readonly Powlib _powlib;

        [Fact]
        public void TwoTothePowerOfTwo_ReturnFour()
        {
            var result = _powLib.Pow(2, 2);
        }
    }
}
