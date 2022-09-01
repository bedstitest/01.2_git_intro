using E01.Classes;

namespace E01.Test.Unit
{
    public class CalculatorUnitTest
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new();
        }

        [TestCase(1, 1, 2)]
        [TestCase(-100, -111, -211)]
        [TestCase(0, 0, 0)]
        [TestCase(1, -1, 0)]
        public void Add_Add_ResultIsCorrect(double param1, double param2, double expected)
        {
            Assert.That(uut.Add(param1, param2), Is.EqualTo(expected));
        }

        [Test]
        public void Add_Add_ResultIsCorrect()
        {
            Assert.That(uut.Add(2,3.5), Is.EqualTo(5.5));
        }
        [Test]
        public void Subtract_Subtract_ResultIsCorrect()
        {
            Assert.That(uut.Subtract(2, -3.5), Is.EqualTo(5.5));
        }
        [Test]
        public void Multiply_Multiply_ResultIsCorrect()
        {
            Assert.That(uut.Multiply(2, 2.2), Is.EqualTo(4.4));
        }
        [Test]
        public void Power_Power_ResultIsCorrect()
        {
            Assert.That(uut.Power(2, 3), Is.EqualTo(8));
        }
    }
}