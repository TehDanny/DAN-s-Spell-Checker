using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DANsSpellChecker
{
    public class WordDatabase
    {
        public SqlConnection conn;
        
        public WordDatabase()
        {
            string server = "ealdb1.eal.local";
            string database = "EJL19_DB";
            string username = "ejl19_usr";
            string password = "Baz1nga19";
            string multipleActiveResult = "true";

            conn = new SqlConnection("server=" + server + ";Database=" + database + ";user=" + username + ";password=" + password + ";MultipleActiveResultSets=" + multipleActiveResult);
        }
        public bool FindWord(string writtenWord)
        {
            return true;
        }
    }
}
