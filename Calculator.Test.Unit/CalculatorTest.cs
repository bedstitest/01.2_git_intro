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
        // ADDITION TESTS
        [TestCase(1, 1, 2)]
        [TestCase(-100, -111, -211)]
        [TestCase(0, 0, 0)]
        [TestCase(1, -1, 0)]
        public void Add_Add_ResultIsCorrect(double param1, double param2, double expected)
        {
            Assert.That(uut.Add(param1, param2), Is.EqualTo(expected));
        }

        [Test]
        public void Add_Negative_Numbers_ResultIsCorrect()
        {
            Assert.That(uut.Add(-3, -4), Is.EqualTo(-7));
        }

        [Test]
        public void Add_Add_ResultIsCorrect()
        {
            Assert.That(uut.Add(2,3.5), Is.EqualTo(5.5));
        }

        // SUBTRACTION TEST
        [TestCase(1, 2, -1)]
        [TestCase(1, -2.1, 3.1)]
        [TestCase(100, 0, 100)]
        public void Subtract_Subtract_ResultIsCorrect(double param1, double param2, double expected)
        {
            Assert.That(uut.Subtract(param1, param2), Is.EqualTo(expected));
        }

        // MULTIPLY TEST
        [TestCase(2.2, 2, 4.4)]
        [TestCase(4, -2.1, -8.4)]
        [TestCase(100, 0, 0)]
        public void Multiply_Multiply_ResultIsCorrect(double param1, double param2, double expected)
        {
            Assert.That(uut.Multiply(param1, param2), Is.EqualTo(expected));
        }
        // POWER TEST
        [TestCase(1, 2, 1)]
        [TestCase(3, 2, 9)]
        [TestCase(4, 0.5, 2)]
        public void Power_Power_ResultIsCorrect(double param1, double param2, double expected)
        {
            Assert.That(uut.Power(param1, param2), Is.EqualTo(expected));
        }
        // DIVISION TEST
        [TestCase(8, 2, 4)]
        [TestCase(2, 8, 0.25)]
        [TestCase(-8, 2, -4)]
        public void Division_ResultIsCorrect(double param1, double param2, double expected)
        {
            Assert.That(uut.Division(param1, param2), Is.EqualTo(expected));
        }

        [Test]
        public void Division_divisionByZero()
        {
            /* note to future us 
             * testing for exections need to be delegated by an lamda. 
            */
            Assert.That(() => uut.Division(3, 0), Throws.Exception.TypeOf<DivideByZeroException>());
        }

        // SQUAREROOT TEST
        [TestCase(9, 3)]
        [TestCase(16, 4)]
        [TestCase(0, 0)]
        public void Squareroot_ResultIsCorrect(double param1, double expected)
        {
            Assert.That(uut.Squareroot(param1), Is.EqualTo(expected));
        }
    }
}