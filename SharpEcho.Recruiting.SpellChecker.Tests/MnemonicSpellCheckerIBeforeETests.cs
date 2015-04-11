using NUnit.Framework;

using SharpEcho.Recruiting.SpellChecker.Contracts;
using SharpEcho.Recruiting.SpellChecker.Core;

namespace SharpEcho.Recruiting.SpellChecker.Tests
{
    [TestFixture]
    class MnemonicSpellCheckerIBeforeETests
    {
        private ISpellChecker SpellChecker;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            SpellChecker = new MnemonicSpellCheckerIBeforeE();
        }

        [Test]
        public void Check_Word_That_Contains_I_Before_E_Is_Spelled_Correctly()
        {
            // implement this test

            // Arrange
            bool result;
            bool expectedResult = true;

            // Act
            result = SpellChecker.Check("receive");

            // Assert
            Assert.AreEqual(expectedResult, result, "Spell check did not execute correctly");
        }

        [Test]
        public void Check_Word_That_Contains_I_Before_E_Is_Spelled_Incorrectly()
        {
            // implement this test

            // Arrange
            string word = "science";
            bool result;
            bool expectedResult = false;

            // Act
            result = SpellChecker.Check(word);

            // Assert
            Assert.AreEqual(expectedResult, result, "Spell check did not execute correctly");
        }      
    }
}
