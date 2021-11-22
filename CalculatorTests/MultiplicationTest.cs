using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    internal class MultiplicationTest
    {
        [Test]
        public void Multiplication()
        {
            var calculator = new Project_16_7.Calculator();
            Assert.That(calculator.Multiplication(5, 2), Is.EqualTo(10));
        }
    }
}
