using NUnit.Framework;
using ConsoleApp12;
namespace TestCalculation
{[TestFixture]
    public class Tests
    {
       
        [SetUp]
        public void Setup()
        {
         
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(Caculation.Addition(2, 5), 7);
        }
        [Test]
        public void TestMultipication()
        {
            Assert.AreEqual(Caculation.Multipication(2, 4), 8);
        }
    }
}