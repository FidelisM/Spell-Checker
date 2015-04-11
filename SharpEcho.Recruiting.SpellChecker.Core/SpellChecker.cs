using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpEcho.Recruiting.SpellChecker.Contracts;

namespace SharpEcho.Recruiting.SpellChecker.Core
{
    /// <summary>
    /// This is a top level spell checker that is used by clients, it internally manages
    /// several spell checkers that it uses to evaluate whether a word is spelled correctly
    /// or not
    /// </summary>
    public class SpellChecker : ISpellChecker
    {
        private ISpellChecker[] SpellCheckers;

        public SpellChecker(ISpellChecker[] spellCheckers)
        {
            SpellCheckers = spellCheckers;
        }

        /// <summary>
        /// Iterates through all the internal spell checkers and returns false if
        /// any one of them finds a word to be misspelled
        /// </summary>
        /// <param name="word">Word to check</param>
        /// <returns>True if all spell checkers agree that a word is spelled correctly, false otherwise</returns>
        public bool Check(string word)
        {
            foreach (var spellChecker in SpellCheckers)
            {
                if (!spellChecker.Check(word))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
