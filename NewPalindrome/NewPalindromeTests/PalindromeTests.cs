using NewPalindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewPalindrome.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPalindrome.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            //Assign
            var palindrome = new Palindrome();
            var expected = "True";

            //Act
            var actual = palindrome.IsPalindrome("Madam");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
