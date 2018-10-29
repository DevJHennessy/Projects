using NUnit.Framework;
using PalindromeWithUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeWithUnitTest.Tests
{
    [TestFixture()]
    public class PalindromeTests
    {
        [Test()]
        public void IsPalindromeTest()
        {
            //Arrange
            var sut = new Palindrome();

            //Act
            var result = sut.IsPalindrome("Madam");

            //Assert
            Assert.That(result, Is.EqualTo(true));
        }
    }
}