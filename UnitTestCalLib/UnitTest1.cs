using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalLib;

namespace UnitTestCalLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSummation()
        {
            TestData[] testDatas = new TestData[]
            {
                new TestData(1,1,2),
                new TestData(1.1,1.2,2.3),
                new TestData(9,8.1,17.1),
                new TestData(12,3,15),
                new TestData(9,30,39)
            };
            Operators op = new Operators();
            foreach(var item in testDatas)
            {
                var res = op.Summation(item.a, item.b);
                Assert.AreEqual(item.result, res);
            }
        }

        [TestMethod]
        public void TestSubtraction()
        {
            TestData[] testDatas = new TestData[]
            {
                new TestData(1,1,0),
                new TestData(3,2,1),
                new TestData(9,8,1)
            };
            Operators op = new Operators();
            foreach (var item in testDatas)
            {
                var res = op.Subtraction(item.a, item.b);
                Assert.AreEqual(item.result, res);
            }
        }

        [TestMethod]
        public void TestMultipication()
        {
            TestData[] testDatas = new TestData[]
            {
                new TestData(1,1,1),
                new TestData(1.1,1.2,1.32),
                new TestData(9,8,72),
                new TestData(-11,3,-33),
                new TestData(9,30,270)
            };
            Operators op = new Operators();
            foreach (var item in testDatas)
            {
                var res = op.Multipication(item.a, item.b);
                Assert.AreEqual(item.result, res);
            }
        }

        [TestMethod]
        public void TestDivision()
        {
            TestData[] testDatas = new TestData[]
            {
                new TestData(1,1,1),
                new TestData(9.6,1.2,8),
                new TestData(9,8,1.125),
                new TestData(-10,2,-5),
                new TestData(20,4,5)
            };
            Operators op = new Operators();
            foreach (var item in testDatas)
            {
                var res = op.Division(item.a, item.b);
                Assert.AreEqual(item.result, res);
            }
        }



    }
}
