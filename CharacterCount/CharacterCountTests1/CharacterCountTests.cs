using NUnit.Framework;
using CharacterCount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCount.Tests
{
    [TestFixture()]
    public class CharacterCountTests
    {
        [Test()]
        public void CharacterCountAlgTest()
        {
            //Arrange
            var sut = new CharacterCount();
            var myString = "Bat";
            var expected = "B = 1\na = 1\nt = 1\n";

            //Act
            var result = sut.CharacterCountAlg(myString);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}