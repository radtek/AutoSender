using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Data.OracleClient;

namespace AutoSender
{
    public partial class Form1 : Form
    {
        private int SelValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSenderMail.Text = Properties.Settings.Default.strSenderMail;
            txtSenderMailPassword.Text = Properties.Settings.Default.strSenderPassword;
            txtSMTPServer.Text = Properties.Settings.Default.strSMTPServer;
            txtReceiverMails.Text = Properties.Settings.Default.strReceiverMails;
            comboBox1.SelectedItem = comboBox1.Items[Properties.Settings.Default.strSelectedIndex];
            chkDBControl.Checked = Properties.Settings.Default.strDBControl;
            if (Properties.Settings.Default.strTNSRACMode)
            {
                radioRAC.Checked = true;
                radioRPO_RAC.Checked = false;
            }
            else
            {
                radioRAC.Checked = false;
                radioRPO_RAC.Checked = true;
            }
            if (Directory.Exists("ToLoad") && Directory.Exists("Loaded"))
            {
                lblFilesCount.Text = "Найдено: " + (Directory.GetFiles("ToLoad").Count()).ToString();
                if (Directory.GetFiles("ToLoad").Count() > 0)
                    btnSend.Enabled = true;
            }
            else
                if (!Directory.Exists("ToLoad"))
                {
                    lblFilesCount.Text = "Отсутствует папка \"ToLoad\"";
                    return;
                }
                else
                {
                    lblFilesCount.Text = "Отсутствует папка \"Loaded\"";
                    return;
                }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            SelValue = Convert.ToInt32(comboBox1.SelectedItem);
            await Task.Factory.StartNew(() =>
                {
                    Sending();
                }
                );
            lblAmount.Text = "Осталось: 0";
        }
        private void Sending()
        {
            Boolean b = false;
            try
            {
                while (Directory.GetFiles("ToLoad").Count() > 0)
                {
                    if (!b)
                    {
                        b = true;
                        if (chkDBControl.Checked)
                        {
                            using (OracleConnection Conn = new OracleConnection(@"Data Source=" + (radioRPO_RAC.Checked ? "rpo_rac" : "rpo") + "; User Id=romanchuk; Password=niips123"))
                            {
                                if (Conn.State != ConnectionState.Open)
                                    Conn.Open();
                                OracleCommand Command = new OracleCommand();
                                Command.Connection = Conn;
                                Command.CommandType = CommandType.Text;
                                Command.CommandText = "begin " +
                                                    "delete from romanchuk.sender_table " +
                                                    "where sysdate - date_access >= 1/144; " +
                                                    //"delete from romanchuk.sender_table " +
                                                    //"where mail = '" + txtSenderMail.Text + "';" +
                                                    "insert into romanchuk.sender_table " +
                                                    "values ('" + txtSenderMail.Text + "', sysdate, " + Directory.GetFiles("ToLoad").Count() + "); end;";
                                //MessageBox.Show(Command.CommandText);
                                Command.ExecuteNonQuery();
                                Conn.Dispose();
                            }
                        }
                        FileInfo Results = new FileInfo("Loaded\\FilesList.txt");
                        using (StreamWriter SW = new StreamWriter(Results.FullName))
                            foreach (string filename in Directory.GetFiles("ToLoad"))
                            {
                                SW.WriteLine("'" + (new FileInfo(filename)).Name + "',");
                            }
                    }
                    if (Directory.GetFiles("ToLoad").Count() > SelValue)
                    {
                        string[] FileNames = Directory.GetFiles("ToLoad");
                        lblAmount.BeginInvoke(new Action(() => lblAmount.Text = "Осталось: " + FileNames.Length));
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(txtSenderMail.Text);
                        string ReceiverMails = txtReceiverMails.Text.Replace("\r\n", "");
                        foreach (string ReceiverMail in ReceiverMails.Split(';'))
                            mail.To.Add(new MailAddress(ReceiverMail));
                        mail.Subject = "autosender";
                        mail.Body = "";
                        for (int i = 0; i < SelValue; i++)
                            mail.Attachments.Add(new Attachment(FileNames[i]));
                        SmtpClient client = new SmtpClient();
                        //client.Host = "smtp.yandex.ru";
                        client.Host = txtSMTPServer.Text;
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential(txtSenderMail.Text.Split('@')[0], txtSenderMailPassword.Text);
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.Send(mail);
                        mail.Dispose();
                        for (int i = 0; i < SelValue; i++)
                        {
                            FileInfo FI = new FileInfo(FileNames[i]);
                            FI.MoveTo("Loaded\\" + FI.Name);
                        }
                    }
                    else
                    {
                        string[] FileNames = Directory.GetFiles("ToLoad");
                        lblAmount.BeginInvoke(new Action(() => lblAmount.Text = "Осталось: " + FileNames.Length));
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(txtSenderMail.Text);
                        string ReceiverMails = txtReceiverMails.Text.Replace("\r\n", "");
                        foreach (string ReceiverMail in ReceiverMails.Split(';'))
                            mail.To.Add(new MailAddress(ReceiverMail));
                        mail.Subject = "autosender";
                        mail.Body = "";
                        for (int i = 0; i < FileNames.Length; i++)
                            mail.Attachments.Add(new Attachment(FileNames[i]));
                        SmtpClient client = new SmtpClient();
                        //client.Host = "smtp.yandex.ru";
                        client.Host = txtSMTPServer.Text;
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential(txtSenderMail.Text.Split('@')[0], txtSenderMailPassword.Text);
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.Send(mail);
                        mail.Dispose();
                        for (int i = 0; i < FileNames.Length; i++)
                        {
                            FileInfo FI = new FileInfo(FileNames[i]);
                            FI.MoveTo("Loaded\\" + FI.Name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.strSenderMail = txtSenderMail.Text;
            Properties.Settings.Default.strSenderPassword = txtSenderMailPassword.Text;
            Properties.Settings.Default.strSMTPServer = txtSMTPServer.Text;
            Properties.Settings.Default.strReceiverMails = txtReceiverMails.Text;
            Properties.Settings.Default.strSelectedIndex = comboBox1.SelectedIndex;
            Properties.Settings.Default.strDBControl = chkDBControl.Checked;
            if (radioRAC.Checked)
                Properties.Settings.Default.strTNSRACMode = true;
            else
                Properties.Settings.Default.strTNSRACMode = false;
            Properties.Settings.Default.Save();
        }

        private void проверитьЛимитОтправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection(@"Data Source=" +
                                                                    /*"(DESCRIPTION=(LOAD_BALANCE=yes)(ADDRESS_LIST=" +
                                                                    "(ADDRESS=(PROTOCOL=TCP)(HOST=10.7.30.145)(PORT=1521))" +
                                                                    "(ADDRESS=(PROTOCOL=TCP)(HOST=10.7.30.147)(PORT=1521)))" +
                                                                    "(CONNECT_DATA)=(FAILOVER_MODE=(TYPE=select)(METHOD=basic)(RETRIES=180)(DELAY=5))" +
                                                                    "(SERVER=dedicated)(SERVICE_NAME=rpo)(UR=A)));" + */
                                                                    (radioRPO_RAC.Checked ? "rpo_rac" : "rpo") +
                                                                    ";Password=niips123;User Id=romanchuk"))
                {
                    if (Conn.State != ConnectionState.Open)
                    {
                        Conn.Open();
                    }
                    OracleCommand Command = new OracleCommand();
                    Command.Connection = Conn;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = "select * from romanchuk.sender_table";
                    OracleDataReader reader = Command.ExecuteReader();
                    string ExecResult = "";
                    while (reader.Read())
                    {
                        ExecResult += "Ящик: " + reader[0] + " Последнее отправление: " + reader[1] + " Файлов: " + reader[2] + Environment.NewLine;
                    }
                    MessageBox.Show(ExecResult);
                    Conn.Dispose();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
