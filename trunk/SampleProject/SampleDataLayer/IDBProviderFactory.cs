using System.Data;
using System.Data.Common;

namespace SampleDataLayer
{
    /// <summary>
    /// The Interface for defining DB connections
    /// </summary>
    public interface IDBProviderFactory
    {
        /// <summary>
        /// Gets a connection.
        /// </summary>
        /// <returns></returns>
        IDbConnection GetConnection();

        /// <summary>
        /// Adds a parameter with value of the correct provider type.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        DbParameter AddParameterWithValue(string name,string value);
    }
}