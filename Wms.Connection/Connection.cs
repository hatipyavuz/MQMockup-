
using Crypto;
using System.Configuration;
using System.Data.SqlClient;

namespace Wms.Connection
{

   public class Connection
    {
       
        private static readonly string ConnectionString = Utils.GetSettings.DatabaseConnStr ;
        private static Connection _singleton;
        private static SqlConnection _sqlConnection;

        public SqlConnection SqlConnetionFactory => _sqlConnection;

        private Connection() { }

        public static Connection Singleton
        {
            get
            {
                if (_singleton == null)
                    _singleton = new Connection();

                _sqlConnection = new SqlConnection(ConnectionString);
                return _singleton;
            }
        }


    }
}
