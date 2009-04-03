using System.Data;
using MySql.Data.MySqlClient;

namespace SampleDataLayer
{
    public interface IMySQLRequests
    {
        /// <summary>
        /// Gets a data table from the specifed MySqlCommand.
        /// </summary>
        /// <param name="RequestCommand">The request command.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        DataTable GetDataTable(MySqlCommand RequestCommand, string connectionString);
    }
}