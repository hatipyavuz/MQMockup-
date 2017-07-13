using MassTransit;
using MetroBus;
using System.Configuration;

namespace Consumer
{
    public class CnvConsumer
    {
        private static string _rabbitMqUri;
        private static string _rabbitMqUserName;
        private static string _rabbitMqPassword;
        private static string _cnvQueueName;
        private static IBusControl _bus;

        /// <summary>
        /// App.Config üzerinde belirlenen değerleri setler
        /// </summary>
        private static void Initilaze()
        {
            _rabbitMqUri = Wms.Utils.GetSettings.RabbitMqUri;
            _rabbitMqUserName = Wms.Utils.GetSettings.RabbitMqUserName;
            _rabbitMqPassword = Wms.Utils.GetSettings.RabbitMqPassword;
            _cnvQueueName = Wms.Utils.GetSettings.CnvLaQueueName;
        }
       
        /// <summary>
        /// Consumer Servisini durdurur class ismindeki queueden veriler okunmaya başlanır.
        /// </summary>
        public static void Stop()
        {
            _bus.Stop();
        }
        /// <summary>
        /// Consumer Servisini başladır class ismindeki queueden veriler okunmaya başlanır.
        /// </summary>
        public static void Start()
        {
            Initilaze();

            _bus = MetroBusInitializer.Instance.UseRabbitMq(_rabbitMqUri, _rabbitMqUserName, _rabbitMqPassword)
                .InitializeConsumer<Service.CnvConsumerService>(_cnvQueueName)
                .Build();

            _bus.Start();
        }
    }
}