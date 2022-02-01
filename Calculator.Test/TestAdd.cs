using Calculator.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class TestAdd
    {
        [TestMethod]
        public void Add_5_10_15()
        {
            var x = 5;
            var y = 10;

            var actual = Calc.Add(x, y);
            var expected = 15;
            
            Assert.AreEqual(expected, actual);
        }
    }
}