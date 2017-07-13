using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MassTransit;
using MetroBus;
using RabbitMQ.Client;
using Wms.Contracts;

namespace Wms.MQForm
{
    public partial class MqForm : Form
    {

        private readonly string _rabbitMqUri;
        private readonly string _rabbitMqUserName;
        private readonly string _rabbitMqPassword;
        private static string _laQueueName;
        private static string _cnvQueueName;
        private readonly string _mqOnServer;

        private IConnection _connection;
        public MqForm()
        {
            InitializeComponent();
            _rabbitMqUri = Utils.GetSettings.RabbitMqUri;
            _rabbitMqUserName = Utils.GetSettings.RabbitMqUserName;
            _rabbitMqPassword = Utils.GetSettings.RabbitMqPassword;
            _laQueueName = Utils.GetSettings.LaCnvQueueName;
            _cnvQueueName = Utils.GetSettings.CnvLaQueueName;
            _mqOnServer = Utils.GetSettings.RabbitMqOnServer;

            bool state = RabbitMqConnectionState();
            Init(state);
        }

        /// <summary>
        /// Bağlantı kontrolünü yapar.
        /// </summary>
        /// <returns></returns>
        private bool RabbitMqConnectionState()
        {
            RabbitMQ.Client.ConnectionFactory factory = new RabbitMQ.Client.ConnectionFactory();

            factory.UserName = _rabbitMqUserName;
            factory.Password = _rabbitMqPassword;
            factory.VirtualHost = "/";
            factory.HostName = _mqOnServer;

            _connection = factory.CreateConnection();
            return _connection.IsOpen;
        }

        /// <summary>
        /// AppConfigden ayarları alır
        /// </summary>
        /// <param name="state"></param>
        private void Init(bool state)
        {
            if (!state)
            {
                chkMqConnection.Checked = true;
                chkMqConnection.Text = $"{chkMqConnection.Text} bağlantısı başarısız.";
                return;
            }
            chkMqConnection.Checked = true;
            chkMqConnection.Text = $"{chkMqConnection.Text} bağlantısı başarılı";
            chkMqConnection.ForeColor = Color.Green;
            lblInformation.Text =
                $"{_mqOnServer} serverinda {_laQueueName } / {_cnvQueueName} ismindeki Queue ve Exchange e data aktarımı yapılacaktır.";
            lblInformation.ForeColor = Color.Green;

            ConnectionDataBase();
        }
        private void ConnectionDataBase()
        {
            var con = Wms.Connection.Connection.Singleton;
            if (con.SqlConnetionFactory.State != ConnectionState.Open)
            {
                lblDbConnection.Text = "Db Bağlantısı başarısız.";
                lblDbConnection.ForeColor = Color.Red;
            }
            lblDbConnection.Text = "Db Bağlantısı başarılı.";
            lblDbConnection.ForeColor = Color.Green;

        }

        public async Task SendLaCnvQueueTask(string queueName)
        {

            ISendEndpoint producerEndpoint =
                await
                    MetroBusInitializer.Instance.UseRabbitMq(_rabbitMqUri, _rabbitMqUserName, _rabbitMqPassword)
                        .InitializeProducer(queueName);


            await producerEndpoint.Send<ICnvLaQueueMessage>(new
            {
                Barcode = txtCnvBarcode.Text,
                Chute = txtCnvChute.Text,
                ErrorCode = txtCnvErrorCode.Text,
                Error = txtCnvErrorMessage.Text,
                CreateDateTime = DateTime.Now
            });
        }

        public async Task SendCnvLaQueueTask(string queueName)
        {

            ISendEndpoint producerEndpoint =
                await
                    MetroBusInitializer.Instance.UseRabbitMq(_rabbitMqUri, _rabbitMqUserName, _rabbitMqPassword)
                        .InitializeProducer(queueName);

            await producerEndpoint.Send<ILaCnvQueueMessage>(new
            {
                Barcode = txtBarcode.Text,
                Chute = txtChute.Text,
                CreateDateTime = DateTime.Now
            });
        }

        private async void btnAddLaQueue_Click(object sender, EventArgs e)
        {
            await SendCnvLaQueueTask(_laQueueName);
            txtBarcode.Text = string.Empty;
            txtChute.Text = string.Empty;
        }
        private void btnLaConsumerStart_Click(object sender, EventArgs e)
        {
            Consumer.LaConsumer.Start();
        }

        private void btnLaConsumerStop_Click(object sender, EventArgs e)
        {
            Consumer.LaConsumer.Stop();
        }

        
        private async void btnAddCnvQueue_Click(object sender, EventArgs e)
        {
            await SendLaCnvQueueTask(_cnvQueueName);
            txtCnvBarcode.Text = String.Empty;
            txtCnvChute.Text = String.Empty;
            txtCnvErrorCode.Text = String.Empty;
            txtCnvErrorMessage.Text = String.Empty;
        }

        private void btnCnvConsumerStart_Click(object sender, EventArgs e)
        {
            Consumer.CnvConsumer.Start();
        }

        private void btnCnvConsumerStop_Click(object sender, EventArgs e)
        {
            Consumer.CnvConsumer.Stop();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
          
        }
    }
}
