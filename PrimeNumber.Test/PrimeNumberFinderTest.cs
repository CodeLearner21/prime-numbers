using System;
using Xunit;
using PrimeNumber.BL;

namespace PrimeNumber.Test
{
    public class PrimeNumberFinderTest
    {
        // Test name convention
        // ActionName_StateUnderTest_ExpectedBehavior

        [Fact]
        public void IsPrimeNumber_IfProvideValueIs1_ReturnFalse()
        {
            PrimeNumberFinder pf = new PrimeNumberFinder();
            var actual = pf.IsPrimeNumber(1);
            Assert.False(actual);
        }

        [Fact]
        public void IsPrimeNumber_IfProvideValueIs6_ReturnFalse()
        {
            PrimeNumberFinder pf = new PrimeNumberFinder();
            var actual = pf.IsPrimeNumber(6);
            Assert.False(actual);
        }

        [Fact]
        public void IsPrimeNumber_IfProvideValueIs11_ReturnTrue()
        {
            PrimeNumberFinder pf = new PrimeNumberFinder();
            var actual = pf.IsPrimeNumber(11);
            Assert.True(actual);
        }

        [Fact]
        public void IsPrimeNumber_IfProvideValueGreaterThan100_ThrowException()
        {
            PrimeNumberFinder pf = new PrimeNumberFinder();
            Action action = () => pf.IsPrimeNumber(101);
            Assert.Throws<Exception>(action);            
        }
    }
}
