using NUnit.Framework;
using NewInsertionSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInsertionSort.Tests
{
    [TestFixture()]
    public class InsertionSortTests
    {
        [Test()]
        public void InsertionSortAlgTest()
        {
            //Arrange
            var sut = new InsertionSort();
            int[] data = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            //Act
            var result = sut.InsertionSortAlg(data);
    

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}