using System.Data;
using System.Data.SqlClient;

namespace PM_Search_DataAccess
{
    public class DataBaseConnection
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public DataBaseConnection(string connectionString = null)
        {
            connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=PatientDetails;Integrated Security=True");
        }
        public void DisposeConnection()
        {
            connection.Dispose();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
        public SqlConnection OpenConnection()
        {
            if(connection.State==ConnectionState.Closed || connection.State==ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public DataTable ExecuteSelectQuery(string query, SqlParameter[] sqlParameter)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand myCommand = new SqlCommand(query, OpenConnection());
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddRange(sqlParameter);
                adapter = new SqlDataAdapter(myCommand);
                adapter.Fill(dataTable);
            }
            catch (SqlException e)
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }

        public bool ExecuteUpdateQuery(string query, SqlParameter[] sqlParameter)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, OpenConnection());
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return true;
        }

        public bool ExecuteInsertQuery(string query, SqlParameter[] sqlParameter)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, OpenConnection());
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return true;
        }
    }
}
