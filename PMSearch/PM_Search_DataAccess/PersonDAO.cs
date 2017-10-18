using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Search_DataAccess
{
    public class PersonDAO
    {
        private DataBaseConnection conn;

        public PersonDAO()
        {
            conn = new DataBaseConnection();
        }

        public DataTable GetPersonData(string firstname, string lastname, string sex,
                                        string birthdate,string voterid)
        {
            string query = "sp_person_data";
            string StatementType = "Select";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@firstname", SqlDbType.VarChar);
            sqlParameters[0].Value = firstname;
            sqlParameters[1] = new SqlParameter("@lastname", SqlDbType.VarChar);
            sqlParameters[1].Value = lastname;
            sqlParameters[2] = new SqlParameter("@sex", SqlDbType.VarChar);
            sqlParameters[2].Value = sex;
            sqlParameters[3] = new SqlParameter("@birthdate", SqlDbType.VarChar);
            sqlParameters[3].Value = birthdate;
            sqlParameters[4] = new SqlParameter("@voterid", SqlDbType.VarChar);
            sqlParameters[4].Value = voterid;
            sqlParameters[5] = new SqlParameter("@StatementType", SqlDbType.VarChar);
            sqlParameters[5].Value = StatementType;
            return conn.ExecuteSelectQuery(query, sqlParameters);
        }

        public bool AddPersonData(string firstname, string lastname, string sex,
                                       string birthdate, string voterid)
        {
            string query = "sp_person_data";
            string StatementType = "Insert";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@firstname", SqlDbType.VarChar);
            sqlParameters[0].Value = firstname;
            sqlParameters[1] = new SqlParameter("@lastname", SqlDbType.VarChar);
            sqlParameters[1].Value = lastname;
            sqlParameters[2] = new SqlParameter("@sex", SqlDbType.VarChar);
            sqlParameters[2].Value = sex;
            sqlParameters[3] = new SqlParameter("@birthdate", SqlDbType.VarChar);
            sqlParameters[3].Value = birthdate;
            sqlParameters[4] = new SqlParameter("@voterid", SqlDbType.VarChar);
            sqlParameters[4].Value = voterid;
            sqlParameters[5] = new SqlParameter("@StatementType", SqlDbType.VarChar);
            sqlParameters[5].Value = StatementType;
            return conn.ExecuteInsertQuery(query, sqlParameters);
        }

        public DataTable GetPersonDataUsingPersonId(int personid)
        {
            string query = "sp_person_data";
            string StatementType = "Select using person id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@personid", SqlDbType.Int);
            sqlParameters[0].Value = personid;
            sqlParameters[1] = new SqlParameter("@StatementType", SqlDbType.VarChar);
            sqlParameters[1].Value = StatementType;
            return conn.ExecuteSelectQuery(query, sqlParameters);
        }

        public bool UpdatePersonData(int personid, string firstname, string lastname, string sex,
                                      string birthdate, string voterid)
        {
            string query = "sp_person_data";
            string StatementType = "Update";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@firstname", SqlDbType.VarChar);
            sqlParameters[0].Value = firstname;
            sqlParameters[1] = new SqlParameter("@lastname", SqlDbType.VarChar);
            sqlParameters[1].Value = lastname;
            sqlParameters[2] = new SqlParameter("@sex", SqlDbType.VarChar);
            sqlParameters[2].Value = sex;
            sqlParameters[3] = new SqlParameter("@birthdate", SqlDbType.VarChar);
            sqlParameters[3].Value = birthdate;
            sqlParameters[4] = new SqlParameter("@voterid", SqlDbType.VarChar);
            sqlParameters[4].Value = voterid;
            sqlParameters[5] = new SqlParameter("@StatementType", SqlDbType.VarChar);
            sqlParameters[5].Value = StatementType;
            sqlParameters[6] = new SqlParameter("@personid", SqlDbType.Int);
            sqlParameters[6].Value = personid;
            return conn.ExecuteUpdateQuery(query, sqlParameters);
        }
    }
}
