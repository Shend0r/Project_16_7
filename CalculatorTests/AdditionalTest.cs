using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    internal class AdditionalTest
    {
        [Test]
        public void Additional()
        {
            var calculator = new Project_16_7.Calculator();
            Assert.That(calculator.Additional(5, 5), Is.EqualTo(10));
        }
    }
}
