using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture()]
    public class SimpleCalculatorTests
    {
        [Test()]
        public void AddTest()
        {
            //Assign
            var sut = new SimpleCalculator();

            //Act
            var result = sut.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test()]
        public void MultiplyTest()
        {
            var sut = new SimpleCalculator();

            var result = sut.Multiply(2, 10);

            Assert.That(result, Is.EqualTo(20));
        }
    }
}