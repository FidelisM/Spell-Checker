using NUnit.Framework;

using SharpEcho.Recruiting.SpellChecker.Contracts;
using SharpEcho.Recruiting.SpellChecker.Core;

namespace SharpEcho.Recruiting.SpellChecker.Tests
{
    [TestFixture]
    class DictionaryDotComSpellCheckerTests
    {
        private ISpellChecker SpellChecker;

        [TestFixtureSetUp]
        public void TestFixureSetUp()
        {
            SpellChecker = new DictionaryDotComSpellChecker();
        }

        [Test]
        public void Check_That_SharpEcho_Is_Misspelled()
        {
            // implement this test
            
            // Arrange
            string input = "SharpEcho";
            bool result;
            bool expectedResult = false;

            // Act
            result = SpellChecker.Check(input);
            
            // Assert
            Assert.AreEqual(expectedResult, result, "Spell check did not execute correctly");            
        }

        [Test]
        public void Check_That_South_Is_Not_Misspelled()
        {
            // implement this test

            // Arrange
            string input = "South";
            bool result;
            bool expectedResult = true;

            // Act
            result = SpellChecker.Check(input);

            // Assert
            Assert.AreEqual(expectedResult, result, "Spell check did not execute correctly");     
        }
    }
}
