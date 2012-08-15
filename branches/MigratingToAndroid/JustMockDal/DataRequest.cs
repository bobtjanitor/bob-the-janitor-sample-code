using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace JustMockDal
{
    public class DataRequest
    {
        private SqlConnection _sqlConnection = null;
        public SqlConnection Connection
        {
            get
            {
                if (_sqlConnection ==null)
                {
                    _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersDB"].ConnectionString);
                }
                return _sqlConnection;
            }
            set { _sqlConnection = value; }
        }

        public List<string> GetUserList()
        {
            List<string> list = new List<string>();

            using (Connection)
            {
                Connection.Open();
                SqlCommand cmd = Connection.CreateCommand();

            }

            return list;
        }
    }
}
