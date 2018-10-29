using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeWithUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeWithUnitTest.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            //Arrange
            var palindrome = new Palindrome(); 
            var expected = true;

            //Act
            var actual = palindrome.IsPalindrome("Madam");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}