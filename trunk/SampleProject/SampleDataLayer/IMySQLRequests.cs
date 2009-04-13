using System.Data;
using MySql.Data.MySqlClient;

namespace SampleDataLayer
{
    /// <summary>
    /// an interface for dealing with mySQL requests 
    /// </summary>
    public interface IMySQLRequests
    {
        /// <summary>
        /// Gets a data table from the specified <see cref="MySqlCommand"/>.
        /// </summary>
        /// <param name="requestCommand">The request command.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        DataTable GetDataTable(MySqlCommand requestCommand, string connectionString);
    }
}