using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANsSpellChecker
{
    class Controller
    {
        /*
        internal void FindWordInDatabase(string input)
        {
            WordDatabase wordDatabase = new WordDatabase();

            bool wordFound = wordDatabase.FindWord(input);
        }
        */
        
        internal string SpellCheckWord(string input)
        {
            WordDatabase wordDatabase = new WordDatabase();
            SpellCheck spellCheck = new SpellCheck();

            bool wordFound = wordDatabase.FindCorrectWord(input);

            if (!wordFound)
            {
                spellCheck.Word(input);
            }

            return "Test";
        }
    }
}
