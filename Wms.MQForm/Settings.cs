using System;
using System.Configuration;
using System.Windows.Forms;

namespace Wms.MQForm
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            if (txtUri.Text != string.Empty)
            {
                config.AppSettings.Settings.Remove("RabbitMqUri");
                config.AppSettings.Settings.Add("RabbitMqUri", Crypto.Crypto.Encrypt(txtUri.Text));
                config.Save(ConfigurationSaveMode.Modified);
            }

            if (txtUser.Text != string.Empty)
            {
                config.AppSettings.Settings.Remove("RabbitMqUserName");
                config.AppSettings.Settings.Add("RabbitMqUserName", Crypto.Crypto.Encrypt(txtUser.Text));
                config.Save(ConfigurationSaveMode.Modified);
            }

            if (txtPassword.Text != string.Empty)
            {
                config.AppSettings.Settings.Remove("RabbitMqPassword");
                config.AppSettings.Settings.Add("RabbitMqPassword", Crypto.Crypto.Encrypt(txtPassword.Text));
                config.Save(ConfigurationSaveMode.Modified);
            }

            if (txtOnServer.Text != string.Empty)
            {
                config.AppSettings.Settings.Remove("RabbitMqOnServer");
                config.AppSettings.Settings.Add("RabbitMqOnServer", Crypto.Crypto.Encrypt(txtOnServer.Text));
                config.Save(ConfigurationSaveMode.Modified);
            }

            if (txtLaCnv.Text != string.Empty)
            {
                config.AppSettings.Settings.Remove("LaCnvQueueName");
                config.AppSettings.Settings.Add("LaCnvQueueName", Crypto.Crypto.Encrypt(txtLaCnv.Text));
                config.Save(ConfigurationSaveMode.Modified);
            }
            if (txtCnvLa.Text != string.Empty)
            {
                config.AppSettings.Settings.Remove("CnvLaQueueName");
                config.AppSettings.Settings.Add("CnvLaQueueName", Crypto.Crypto.Encrypt(txtCnvLa.Text));
                config.Save(ConfigurationSaveMode.Modified);
            }
            if (txtConnStr.Text != string.Empty)
            {
                config.AppSettings.Settings.Remove("DatabaseConnStr");
                config.AppSettings.Settings.Add("DatabaseConnStr", Crypto.Crypto.Encrypt(txtConnStr.Text));
                config.Save(ConfigurationSaveMode.Modified);
            }
            CloseForm();
        }


        private void CloseForm()
        {
            this.Close();
        }
    }
}
