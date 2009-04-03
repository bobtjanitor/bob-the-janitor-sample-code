using System.Data;
using MySql.Data.MySqlClient;

namespace SampleDataLayer
{
    /// <summary>
    /// Class Libaray used for requesting data from a mysql database
    /// </summary>
    public class MySQLRequests : IMySQLRequests
    {
        /// <summary>
        /// Gets a data table from the specifed MySqlCommand.
        /// </summary>
        /// <param name="RequestCommand">The request command.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        public DataTable GetDataTable(MySqlCommand RequestCommand, string connectionString)
        {
            DataTable requestTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                RequestCommand.Connection = conn;
                conn.Open();                
                MySqlDataAdapter myAdaptor = new MySqlDataAdapter(RequestCommand);
                myAdaptor.Fill(requestTable);                
                conn.Close();
                conn.Dispose();
            }
            return requestTable;
        }
    }
}
