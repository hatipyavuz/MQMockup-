namespace Wms.MQForm
{
    partial class MqForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDbConnection = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCnvErrorMessage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCnvErrorCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCnvChute = new System.Windows.Forms.TextBox();
            this.btnAddCnvQueue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCnvBarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCnvConsumerStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCnvConsumerStop = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.chkMqConnection = new System.Windows.Forms.CheckBox();
            this.txtChute = new System.Windows.Forms.TextBox();
            this.btnLaConsumerStart = new System.Windows.Forms.Button();
            this.btnLaConsumerStop = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddLaQueue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDbConnection
            // 
            this.lblDbConnection.AutoSize = true;
            this.lblDbConnection.Location = new System.Drawing.Point(12, 363);
            this.lblDbConnection.Name = "lblDbConnection";
            this.lblDbConnection.Size = new System.Drawing.Size(10, 13);
            this.lblDbConnection.TabIndex = 17;
            this.lblDbConnection.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "LA -> Konveyor ";
            // 
            // txtCnvErrorMessage
            // 
            this.txtCnvErrorMessage.Location = new System.Drawing.Point(95, 95);
            this.txtCnvErrorMessage.Name = "txtCnvErrorMessage";
            this.txtCnvErrorMessage.Size = new System.Drawing.Size(100, 20);
            this.txtCnvErrorMessage.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Error Message : ";
            // 
            // txtCnvErrorCode
            // 
            this.txtCnvErrorCode.Location = new System.Drawing.Point(95, 69);
            this.txtCnvErrorCode.Name = "txtCnvErrorCode";
            this.txtCnvErrorCode.Size = new System.Drawing.Size(100, 20);
            this.txtCnvErrorCode.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Error Code :";
            // 
            // txtCnvChute
            // 
            this.txtCnvChute.Location = new System.Drawing.Point(95, 45);
            this.txtCnvChute.Name = "txtCnvChute";
            this.txtCnvChute.Size = new System.Drawing.Size(100, 20);
            this.txtCnvChute.TabIndex = 5;
            // 
            // btnAddCnvQueue
            // 
            this.btnAddCnvQueue.Location = new System.Drawing.Point(126, 121);
            this.btnAddCnvQueue.Name = "btnAddCnvQueue";
            this.btnAddCnvQueue.Size = new System.Drawing.Size(75, 23);
            this.btnAddCnvQueue.TabIndex = 8;
            this.btnAddCnvQueue.Text = "Ekle";
            this.btnAddCnvQueue.UseVisualStyleBackColor = true;
            this.btnAddCnvQueue.Click += new System.EventHandler(this.btnAddCnvQueue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barkod :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chute :";
            // 
            // txtCnvBarcode
            // 
            this.txtCnvBarcode.Location = new System.Drawing.Point(95, 19);
            this.txtCnvBarcode.Name = "txtCnvBarcode";
            this.txtCnvBarcode.Size = new System.Drawing.Size(100, 20);
            this.txtCnvBarcode.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Konveyor -> LA";
            // 
            // btnCnvConsumerStart
            // 
            this.btnCnvConsumerStart.Location = new System.Drawing.Point(6, 45);
            this.btnCnvConsumerStart.Name = "btnCnvConsumerStart";
            this.btnCnvConsumerStart.Size = new System.Drawing.Size(75, 23);
            this.btnCnvConsumerStart.TabIndex = 4;
            this.btnCnvConsumerStart.Text = "Start";
            this.btnCnvConsumerStart.UseVisualStyleBackColor = true;
            this.btnCnvConsumerStart.Click += new System.EventHandler(this.btnCnvConsumerStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txtCnvErrorMessage);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCnvErrorCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCnvChute);
            this.groupBox2.Controls.Add(this.btnAddCnvQueue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCnvBarcode);
            this.groupBox2.Location = new System.Drawing.Point(239, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 236);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCnvConsumerStart);
            this.groupBox4.Controls.Add(this.btnCnvConsumerStop);
            this.groupBox4.Location = new System.Drawing.Point(20, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 74);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consumer";
            // 
            // btnCnvConsumerStop
            // 
            this.btnCnvConsumerStop.Location = new System.Drawing.Point(100, 45);
            this.btnCnvConsumerStop.Name = "btnCnvConsumerStop";
            this.btnCnvConsumerStop.Size = new System.Drawing.Size(75, 23);
            this.btnCnvConsumerStop.TabIndex = 5;
            this.btnCnvConsumerStop.Text = "Stop";
            this.btnCnvConsumerStop.UseVisualStyleBackColor = true;
            this.btnCnvConsumerStop.Click += new System.EventHandler(this.btnCnvConsumerStop_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(12, 327);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(10, 13);
            this.lblInformation.TabIndex = 13;
            this.lblInformation.Text = " ";
            // 
            // chkMqConnection
            // 
            this.chkMqConnection.AutoSize = true;
            this.chkMqConnection.Location = new System.Drawing.Point(12, 307);
            this.chkMqConnection.Name = "chkMqConnection";
            this.chkMqConnection.Size = new System.Drawing.Size(129, 17);
            this.chkMqConnection.TabIndex = 16;
            this.chkMqConnection.Text = "RabbitMq Connection";
            this.chkMqConnection.UseVisualStyleBackColor = true;
            // 
            // txtChute
            // 
            this.txtChute.Location = new System.Drawing.Point(59, 52);
            this.txtChute.Name = "txtChute";
            this.txtChute.Size = new System.Drawing.Size(100, 20);
            this.txtChute.TabIndex = 2;
            // 
            // btnLaConsumerStart
            // 
            this.btnLaConsumerStart.Location = new System.Drawing.Point(6, 45);
            this.btnLaConsumerStart.Name = "btnLaConsumerStart";
            this.btnLaConsumerStart.Size = new System.Drawing.Size(75, 23);
            this.btnLaConsumerStart.TabIndex = 4;
            this.btnLaConsumerStart.Text = "Start";
            this.btnLaConsumerStart.UseVisualStyleBackColor = true;
            this.btnLaConsumerStart.Click += new System.EventHandler(this.btnLaConsumerStart_Click);
            // 
            // btnLaConsumerStop
            // 
            this.btnLaConsumerStop.Location = new System.Drawing.Point(100, 45);
            this.btnLaConsumerStop.Name = "btnLaConsumerStop";
            this.btnLaConsumerStop.Size = new System.Drawing.Size(75, 23);
            this.btnLaConsumerStop.TabIndex = 5;
            this.btnLaConsumerStop.Text = "Stop";
            this.btnLaConsumerStop.UseVisualStyleBackColor = true;
            this.btnLaConsumerStop.Click += new System.EventHandler(this.btnLaConsumerStop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLaConsumerStart);
            this.groupBox3.Controls.Add(this.btnLaConsumerStop);
            this.groupBox3.Location = new System.Drawing.Point(6, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 74);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consumer";
            // 
            // btnAddLaQueue
            // 
            this.btnAddLaQueue.Location = new System.Drawing.Point(84, 78);
            this.btnAddLaQueue.Name = "btnAddLaQueue";
            this.btnAddLaQueue.Size = new System.Drawing.Size(75, 23);
            this.btnAddLaQueue.TabIndex = 3;
            this.btnAddLaQueue.Text = "Ekle";
            this.btnAddLaQueue.UseVisualStyleBackColor = true;
            this.btnAddLaQueue.Click += new System.EventHandler(this.btnAddLaQueue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chute :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(59, 23);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(100, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtChute);
            this.groupBox1.Controls.Add(this.btnAddLaQueue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 236);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // MqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 459);
            this.Controls.Add(this.lblDbConnection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.chkMqConnection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MqForm";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDbConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCnvErrorMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCnvErrorCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCnvChute;
        private System.Windows.Forms.Button btnAddCnvQueue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCnvBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCnvConsumerStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCnvConsumerStop;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.CheckBox chkMqConnection;
        private System.Windows.Forms.TextBox txtChute;
        private System.Windows.Forms.Button btnLaConsumerStart;
        private System.Windows.Forms.Button btnLaConsumerStop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddLaQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
    }
}

