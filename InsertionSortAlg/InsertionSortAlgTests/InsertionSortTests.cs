using NUnit.Framework;
using InsertionSortAlg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlg.Tests
{
    [TestFixture()]
    public class InsertionSortTests
    {
        [Test()]
        public void InsertionSortIntergersTest()
        {
            //Arrange
            var sut = new InsertionSort();
            int[] integersArray = { 5, 4, 2, 3, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            //Act
            var result = sut.InsertionSortIntergers(integersArray);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test()]
        public void InsertionSortFloatsTest()
        {
            //Arrange
            var sut = new InsertionSort();
            float[] floatArray = { 5.21f, 4.21f, 2.21f, 3.21f, 1.21f };
            float[] expected = { 1.21f, 2.21f, 3.21f, 4.21f, 5.21f };

            //Act
            var result = sut.InsertionSortFloats(floatArray);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}