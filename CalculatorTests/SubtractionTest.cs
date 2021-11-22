using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    internal class SubtractionTest
    {
        [Test]
        public void Subtraction()
        {
            var calculator = new Project_16_7.Calculator();
            Assert.That(calculator.Subtraction(10, 5), Is.EqualTo(5));
        }
    }
}
