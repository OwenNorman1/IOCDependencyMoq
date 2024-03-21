using CalculatorAPI;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void AddTest()
        {
            SimpleCalculator c = new SimpleCalculator();
            int num1 = 8;
            int num2 = 2;
            int expectednum = 10;
            Assert.That(expectednum, Is.EqualTo(c.Add(num1,num2)));
        }

        [Test]
        public void SubtractTest()
        {
            SimpleCalculator c = new SimpleCalculator();
            int num1 = 8;
            int num2 = 2;
            int expectednum = 6;
            Assert.That(expectednum, Is.EqualTo(c.Subtract(num1, num2)));
        }

        [Test]
        public void MultiplyTest() 
        {
            SimpleCalculator c = new SimpleCalculator();
            int num1 = 8;
            int num2 = 2;
            int expectednum = 16;
            Assert.That(expectednum, Is.EqualTo(c.Multiply(num1, num2)));
        }

        [Test]
        public void DivideTest()
        {
            Mock<IDiagnostics> mockDiagnose = new Mock<IDiagnostics>();
            SimpleCalculator c = new SimpleCalculator(mockDiagnose.Object);
            int num1 = 8;
            int num2 = 2;
            int expectednum = 4;
            Assert.That(expectednum, Is.EqualTo(c.Divide(num1, num2)));
            mockDiagnose.Verify(m => m.logString(It.IsAny<string>()), Times.Never);
        }

        [Test]
        public void DivideByZeroTest()
        {
            Mock<IDiagnostics> mockDiagnose = new Mock<IDiagnostics>();
            SimpleCalculator c = new SimpleCalculator(mockDiagnose.Object);
            int num1 = 8;
            int num2 = 0;
            Assert.That(0, Is.EqualTo(c.Divide(num1, num2)));
            mockDiagnose.Verify(m => m.logString(It.IsAny<string>()), Times.Once);
        }
    }
}
