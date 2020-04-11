using System;
using Xunit;
using CalLib;

namespace XUnitTest
{
    public class UnitTest1
    {

        private Operators op = new Operators();

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(-1,2,1)]
        [InlineData(9,8,17)]
        public void TestSummation(int a, int b, int expectResult)
        {
            var res = op.Summation(a, b);
            Assert.True(expectResult == res);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(-1, 2, -3)]
        [InlineData(9, 8, 1)]
        public void TestSubtraction(int a, int b, int expectResult)
        {
            var res = op.Subtraction(a, b);
            Assert.True(expectResult == res);
        }

        [Theory]
        [InlineData(1,1,1)]
        [InlineData(1.1,1.2,1.32)]
        [InlineData(9,8,72)]
        [InlineData(9,30,270)]
        public void TestMultipication(double a, double b, double expectResult)
        {
                var res = op.Multipication(a, b);
                Assert.True(expectResult == res);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(9.6, 1.2, 8)]
        [InlineData(9, 8, 1.125)]
        [InlineData(-10, 2, -5)]
        public void TestDivision(double a, double b, double expectResult)
        {
            var res = op.Division(a, b);
            Assert.True(expectResult == res);
        }

    }
}
