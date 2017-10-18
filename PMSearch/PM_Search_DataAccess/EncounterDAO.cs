using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Search_DataAccess
{
    public class EncounterDAO
    {
        private DataBaseConnection conn;

        public EncounterDAO()
        {
            conn = new DataBaseConnection();
        }

        public DataTable GetEncounterDataUsingEncounterId(int encounterid)
        {
            string query = "sp_encounter_data";
            string StatementType = "Select using encounter id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@encounterid", SqlDbType.Int);
            sqlParameters[0].Value = encounterid;
            sqlParameters[1] = new SqlParameter("@StatementType", SqlDbType.NChar);
            sqlParameters[1].Value = StatementType;
            return conn.ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable GetEncounterDataUsingPersonId(int personid)
        {
            string query = "sp_encounter_data";
            string StatementType = "Select using person id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@personid", SqlDbType.Int);
            sqlParameters[0].Value = personid;
            sqlParameters[1] = new SqlParameter("@StatementType", SqlDbType.NChar);
            sqlParameters[1].Value = StatementType;
            return conn.ExecuteSelectQuery(query, sqlParameters);
        }

        public bool AddEncounterData(string physician, string medication, int personid)
        {
            string query = "sp_encounter_data";
            string StatementType = "Insert";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@physician", SqlDbType.VarChar);
            sqlParameters[0].Value = physician;
            sqlParameters[1] = new SqlParameter("@medication", SqlDbType.VarChar);
            sqlParameters[1].Value = medication;
            sqlParameters[2] = new SqlParameter("@personid", SqlDbType.Int);
            sqlParameters[2].Value = personid;
            sqlParameters[3] = new SqlParameter("@StatementType", SqlDbType.NChar);
            sqlParameters[3].Value = StatementType;
            return conn.ExecuteInsertQuery(query, sqlParameters);
        }

        public bool UpdateEncounterData(int encounterid, string physician, string medication, int personid)
        {
            string query = "sp_encounter_data";
            string StatementType = "Update";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@encounterid", SqlDbType.Int);
            sqlParameters[0].Value = encounterid;
            sqlParameters[1] = new SqlParameter("@physician", SqlDbType.VarChar);
            sqlParameters[1].Value = physician;
            sqlParameters[2] = new SqlParameter("@medication", SqlDbType.VarChar);
            sqlParameters[2].Value = medication;
            sqlParameters[3] = new SqlParameter("@personid", SqlDbType.Int);
            sqlParameters[3].Value = personid;
            sqlParameters[4] = new SqlParameter("@StatementType", SqlDbType.NChar);
            sqlParameters[4].Value = StatementType;
            return conn.ExecuteUpdateQuery(query, sqlParameters);
        }
    }
}
