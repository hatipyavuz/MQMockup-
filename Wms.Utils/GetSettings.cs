using System.Configuration;
namespace Wms.Utils
{
    public static class GetSettings
    {

        static GetSettings()
        {
            _rabbitMqUserName= Crypto.Crypto.Decrypt(ConfigurationManager.AppSettings["RabbitMqUserName"]);
            _rabbitMqUri = Crypto.Crypto.Decrypt(ConfigurationManager.AppSettings["RabbitMqUri"]);
            _rabbitMqPassword = Crypto.Crypto.Decrypt(ConfigurationManager.AppSettings["RabbitMqPassword"]);
            _rabbitMqOnServer = Crypto.Crypto.Decrypt(ConfigurationManager.AppSettings["RabbitMqOnServer"]);
            _laCnvQueueName = Crypto.Crypto.Decrypt(ConfigurationManager.AppSettings["LaCnvQueueName"]);
            _cnvLaQueueName = Crypto.Crypto.Decrypt(ConfigurationManager.AppSettings["CnvLaQueueName"]);
            _databaseConnStr = Crypto.Crypto.Decrypt(ConfigurationManager.AppSettings["DatabaseConnStr"]);

        }

        private static string _rabbitMqUri;
        public static string RabbitMqUri
        {
            get { return _rabbitMqUri; }
        }

        private static string _rabbitMqUserName;
        public static string RabbitMqUserName
        {
            get { return _rabbitMqUserName; }
             
        }

        private static string _rabbitMqPassword;
        public static string RabbitMqPassword
        {
            get { return _rabbitMqPassword; }

        }


        private static string _rabbitMqOnServer;
        public static string RabbitMqOnServer
        {
            get { return _rabbitMqOnServer; } 
        }

        private static string _laCnvQueueName;
        public static string LaCnvQueueName
        {
            get { return _laCnvQueueName; }
        }

        private static string _cnvLaQueueName;
        public static string CnvLaQueueName
        {
            get { return _cnvLaQueueName; }
        }

        private static string _databaseConnStr;
        public static string DatabaseConnStr
        {
            get { return _databaseConnStr; }
        }

 

    }
}
