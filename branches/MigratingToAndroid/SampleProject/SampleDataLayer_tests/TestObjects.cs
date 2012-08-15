using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using MySql.Data.MySqlClient;
using SampleDataLayer;

namespace SampleDataLayer_tests
{
    /// <summary>
    /// The base mock object for the different test objects
    /// </summary>
    public class BaseMockObject
    {
        /// <summary>
        /// Gets or sets the test message Collection.
        /// </summary>
        /// <value>The test message.</value>
        public Collection<string> TestMessages { get; set; }
        /// <summary>
        /// Gets or sets the data returned by the request in column value format
        /// </summary>
        /// <value>The test return data.</value>
        public Dictionary<string, object> TestReturnData { get; set; }

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>The connection string.</value>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMockObject"/> class.
        /// </summary>
        public BaseMockObject()
        {
            TestMessages = new Collection<string>();
            TestReturnData = new Dictionary<string, object>();
            ConnectionString = string.Empty;
        }

        /// <summary>
        /// Builds a data table from the TestReturn Data.
        /// </summary>
        /// <returns></returns>
        public DataTable BuildDataTable()
        {
            DataTable TestTable = new DataTable();
            foreach (string key in TestReturnData.Keys)
            {
                TestTable.Columns.Add(key);                
            }
            DataRow TestRow = TestTable.NewRow();
            for (int i = 0; i < TestTable.Columns.Count; i++)
            {
                TestRow[TestTable.Columns[i].ColumnName] = TestReturnData[TestTable.Columns[i].ColumnName];                
            }
            TestTable.Rows.Add(TestRow);

            return TestTable;
        }
    }

    /// <summary>
    /// A Mock test object that implements <see cref="IMySQLRequests"/> 
    /// </summary>
    public class TestMySqlRequestInterface : BaseMockObject, IMySQLRequests
    {
        /// <summary>
        /// A Mock objects That appers to gets a data table from the specifed <see cref="MySqlCommand"/>.
        /// </summary>
        /// <param name="RequestCommand">The request command.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        public DataTable GetDataTable(MySqlCommand RequestCommand, string connectionString)
        {
            TestMessages.Add("GetDataTable");
            return BuildDataTable();
        }
    }
}
