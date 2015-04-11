namespace SharpEcho.Recruiting.SpellChecker.Contracts
{
    /// <summary>
    /// The base interface which defines how spell checkers work
    /// </summary>
    public interface ISpellChecker
    {
        /// <summary>
        /// All SpellCheckers will need to implement this methed, which returns true
        /// for words that are spelled correctly and false otherwise
        /// </summary>
        /// <param name="word">The word that needs to be checked</param>
        /// <returns>true, if the word is spelled correctly, false otherwise</returns>
        bool Check(string word);
    }
}
