namespace AutoSender
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьЛимитОтправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFilesCount = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDBControl = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSMTPServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenderMailPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceiverMails = new System.Windows.Forms.TextBox();
            this.txtSenderMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioRPO_RAC = new System.Windows.Forms.RadioButton();
            this.radioRAC = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSendTimeout = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.базаДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверитьЛимитОтправкиToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // проверитьЛимитОтправкиToolStripMenuItem
            // 
            this.проверитьЛимитОтправкиToolStripMenuItem.Name = "проверитьЛимитОтправкиToolStripMenuItem";
            this.проверитьЛимитОтправкиToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.проверитьЛимитОтправкиToolStripMenuItem.Text = "Проверить лимит отправки";
            this.проверитьЛимитОтправкиToolStripMenuItem.Click += new System.EventHandler(this.проверитьЛимитОтправкиToolStripMenuItem_Click);
            // 
            // lblFilesCount
            // 
            this.lblFilesCount.AutoSize = true;
            this.lblFilesCount.Location = new System.Drawing.Point(25, 41);
            this.lblFilesCount.Name = "lblFilesCount";
            this.lblFilesCount.Size = new System.Drawing.Size(57, 13);
            this.lblFilesCount.TabIndex = 1;
            this.lblFilesCount.Text = "Найдено: ";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(28, 56);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(183, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(25, 98);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 13);
            this.lblAmount.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSendTimeout);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkDBControl);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSMTPServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSenderMailPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtReceiverMails);
            this.groupBox1.Controls.Add(this.txtSenderMail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(226, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры пересылки";
            // 
            // chkDBControl
            // 
            this.chkDBControl.AutoSize = true;
            this.chkDBControl.Checked = true;
            this.chkDBControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDBControl.Location = new System.Drawing.Point(55, 189);
            this.chkDBControl.Name = "chkDBControl";
            this.chkDBControl.Size = new System.Drawing.Size(156, 17);
            this.chkDBControl.TabIndex = 7;
            this.chkDBControl.Text = "Контроль по базе данных";
            this.chkDBControl.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(192, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Количество отправляемых файлов";
            // 
            // txtSMTPServer
            // 
            this.txtSMTPServer.Location = new System.Drawing.Point(9, 108);
            this.txtSMTPServer.Name = "txtSMTPServer";
            this.txtSMTPServer.Size = new System.Drawing.Size(259, 20);
            this.txtSMTPServer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SMTP-сервер ящика отправки";
            // 
            // txtSenderMailPassword
            // 
            this.txtSenderMailPassword.Location = new System.Drawing.Point(9, 71);
            this.txtSenderMailPassword.Name = "txtSenderMailPassword";
            this.txtSenderMailPassword.PasswordChar = '*';
            this.txtSenderMailPassword.Size = new System.Drawing.Size(259, 20);
            this.txtSenderMailPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль ящика отправки";
            // 
            // txtReceiverMails
            // 
            this.txtReceiverMails.Location = new System.Drawing.Point(284, 32);
            this.txtReceiverMails.Multiline = true;
            this.txtReceiverMails.Name = "txtReceiverMails";
            this.txtReceiverMails.Size = new System.Drawing.Size(259, 160);
            this.txtReceiverMails.TabIndex = 5;
            // 
            // txtSenderMail
            // 
            this.txtSenderMail.Location = new System.Drawing.Point(9, 32);
            this.txtSenderMail.Name = "txtSenderMail";
            this.txtSenderMail.Size = new System.Drawing.Size(259, 20);
            this.txtSenderMail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Почтовые ящики назначения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Почтовый ящик отправки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioRPO_RAC);
            this.groupBox2.Controls.Add(this.radioRAC);
            this.groupBox2.Location = new System.Drawing.Point(51, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 61);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режим TNS";
            // 
            // radioRPO_RAC
            // 
            this.radioRPO_RAC.AutoSize = true;
            this.radioRPO_RAC.Checked = true;
            this.radioRPO_RAC.Location = new System.Drawing.Point(6, 42);
            this.radioRPO_RAC.Name = "radioRPO_RAC";
            this.radioRPO_RAC.Size = new System.Drawing.Size(76, 17);
            this.radioRPO_RAC.TabIndex = 0;
            this.radioRPO_RAC.TabStop = true;
            this.radioRPO_RAC.Text = "RPO_RAC";
            this.radioRPO_RAC.UseVisualStyleBackColor = true;
            // 
            // radioRAC
            // 
            this.radioRAC.AutoSize = true;
            this.radioRAC.Location = new System.Drawing.Point(6, 19);
            this.radioRAC.Name = "radioRAC";
            this.radioRAC.Size = new System.Drawing.Size(47, 17);
            this.radioRAC.TabIndex = 0;
            this.radioRAC.Text = "RAC";
            this.radioRAC.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(51, 212);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Проверить папки";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Таймаут между письмами, мс";
            // 
            // txtSendTimeout
            // 
            this.txtSendTimeout.Location = new System.Drawing.Point(173, 163);
            this.txtSendTimeout.Name = "txtSendTimeout";
            this.txtSendTimeout.Size = new System.Drawing.Size(100, 20);
            this.txtSendTimeout.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 249);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblFilesCount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Отправка файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label lblFilesCount;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSMTPServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenderMailPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenderMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReceiverMails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьЛимитОтправкиToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkDBControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioRPO_RAC;
        private System.Windows.Forms.RadioButton radioRAC;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSendTimeout;
        private System.Windows.Forms.Label label6;
    }
}

