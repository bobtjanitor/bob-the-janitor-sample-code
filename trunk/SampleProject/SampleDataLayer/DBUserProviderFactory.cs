using System.Configuration;
using System.Data.Common;
using System.Data;

namespace SampleDataLayer
{
    /// <summary>
    /// A class the implements the <see cref="IDBProviderFactory"/> 
    /// and is used for getting a connection for doing authentication  
    /// </summary>
    public class DBUserProviderFactory : IDBProviderFactory
    {
        /// <summary>
        /// Gets and Instance of the Get Authentication Provider Factory
        /// </summary>
        public static readonly IDBProviderFactory Instance = new DBUserProviderFactory();
        private DbProviderFactory _frameworkDBProviderFactory;
        private ConnectionStringSettings _authenticationSettings;

        /// <summary>
        /// Initializes a new instance of the <see cref="DBAuthenticationProviderFactory"/> class.
        /// this is set as private in order to implement the singleton pattern 
        /// </summary>
        private DBUserProviderFactory()
        {
            _authenticationSettings = ConfigurationManager.ConnectionStrings["User"];
            _frameworkDBProviderFactory = DbProviderFactories.GetFactory(_authenticationSettings.ProviderName); 
        }
        /// <summary>
        /// Gets an <see cref="IDbConnection"/> for doing Authentication.
        /// </summary>
        /// <returns></returns>
        public IDbConnection GetConnection()
        {
            IDbConnection connection =  _frameworkDBProviderFactory.CreateConnection();
            connection.ConnectionString = _authenticationSettings.ConnectionString;            
            return connection;
        }

        /// <summary>
        /// Adds a parameter with value of the correct provider type.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public DbParameter AddParameterWithValue(string name,string value)
        {
            DbParameter parameter = _frameworkDBProviderFactory.CreateParameter();
            parameter.Value = value;
            parameter.ParameterName = name;
            return parameter;
        }
    }
}
