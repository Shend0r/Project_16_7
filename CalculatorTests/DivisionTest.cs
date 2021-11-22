using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    internal class DivisionTest
    {
        [Test]
        public void Division()
        {
            var calculator = new Project_16_7.Calculator();
            Assert.That(calculator.Division(10, 5), Is.EqualTo(2));
        }
    }
}
