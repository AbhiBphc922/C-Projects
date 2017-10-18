using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Search_DataAccess
{
    public class UserDAO
    {
        private DataBaseConnection conn;

        public UserDAO()
        {
            conn = new DataBaseConnection();
        }  
        
        public DataTable GetUserData(string userName, string password)
        {
            string query = "sp_user_data";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = userName;
            sqlParameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            sqlParameters[1].Value = password;
            return conn.ExecuteSelectQuery(query, sqlParameters);
        }   
    }
}
