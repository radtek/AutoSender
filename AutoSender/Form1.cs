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

namespace AutoSender
{
    public partial class Form1 : Form
    {
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
                        FileInfo Results = new FileInfo("Loaded\\FilesList.txt");
                        using (StreamWriter SW = new StreamWriter(Results.FullName))
                            foreach (string filename in Directory.GetFiles("ToLoad"))
                            {
                                SW.WriteLine("'" + (new FileInfo(filename)).Name + "',");
                            }
                    }
                    if (Directory.GetFiles("ToLoad").Count() > 5)
                    {
                        string[] FileNames = Directory.GetFiles("ToLoad");
                        lblAmount.BeginInvoke(new Action(() => lblAmount.Text = "Осталось: " + FileNames.Length));
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("niips.support@yandex.ru");
                        mail.To.Add(new MailAddress("gvc6@russianpost.ru"));
                        mail.Subject = "autosender";
                        mail.Body = "";
                        for (int i = 0; i < 5; i++)
                            mail.Attachments.Add(new Attachment(FileNames[i]));
                        SmtpClient client = new SmtpClient();
                        client.Host = "smtp.yandex.ru";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential("niips.support", "Niips2015");
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.Send(mail);
                        mail.Dispose();
                        for (int i = 0; i < 5; i++)
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
                        mail.From = new MailAddress("niips.support@yandex.ru");
                        mail.To.Add(new MailAddress("gvc6@russianpost.ru"));
                        mail.Subject = "autosender";
                        mail.Body = "";
                        for (int i = 0; i < FileNames.Length; i++)
                            mail.Attachments.Add(new Attachment(FileNames[i]));
                        SmtpClient client = new SmtpClient();
                        client.Host = "smtp.yandex.ru";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential("niips.support", "Niips2015");
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
    }
}
