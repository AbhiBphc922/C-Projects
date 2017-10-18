using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voice_PM_Search;

namespace VoiceSearchTest
{
    public class MyDBConnection : IfrmVoiceSearch
    {
        private frmVoiceSearch _testFrmVoiceSearch;
        public bool testCheckDBConnection(SqlConnection connection)
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
