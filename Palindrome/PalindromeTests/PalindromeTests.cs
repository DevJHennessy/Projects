using NUnit.Framework;
using Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Tests
{
    [TestFixture()]
    public class PalindromeTests
    {
        [Test()]
        public void IsPalindromeTest()
        {
            //Arrange
            var sut = new Palindrome();
            var myString = "Madam";
            var expected = true;

            //Act
            var result = sut.IsPalindrome(myString);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}