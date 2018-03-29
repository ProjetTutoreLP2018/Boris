using EASendMail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "Formulaire - Envoi LC";
            this.but_pj.Click += but_pj_Click;
            this.tb_mess.Multiline = true;
            this.tb_mess.ScrollBars = ScrollBars.Vertical;
            this.tb_mess.WordWrap = true;
            this.tb_mess.Height = 200;

            this.val.Click += valider;
            this.textBox1.Enabled = false;

            this.tb_pass.PasswordChar = '*';
        }

        private void but_pj_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

                //OR

                System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
                //etc

                //MessageBox.Show(fileToOpen, "Titre");
                this.textBox1.Text = fileToOpen.Replace("\\","/");
            }
            
        }

        private void valider(object sender, EventArgs e)
        {
            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();

            // Your gmail email address
            string from = this.tb_from.Text;
            oMail.From = from;

            //Password du type
            string pass = this.tb_pass.Text;

            // Set recipient email address
            string to = this.tb_to.Text;
            oMail.To = to;

            // Set email subject
            string title = this.tb_titre.Text;
            oMail.Subject = title;

            // Set email body
            string content = this.tb_mess.Text;
            oMail.TextBody = content;

            //Test PJ
            string pj = this.textBox1.Text;
            if (!pj.Equals(""))
                oMail.AddAttachment(pj);


            // Gmail SMTP server address
            SmtpServer oServer = new SmtpServer("smtp.gmail.com");

            // Set 587 port, if you want to use 25 port, please change 587 5o 25
            oServer.Port = 587;

            // detect SSL/TLS automatically
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

            // Gmail user authentication
            // For example: your email is "gmailid@gmail.com", then the user should be the same
            oServer.User = from;
            oServer.Password = pass;
            //Console.WriteLine("start to send email over SSL ...");
            try
            {
                oSmtp.SendMail(oServer, oMail);
                MessageBox.Show("Votre mail a bien été envoyé à l'adresse : "+to, "Message envoyé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ep)
            {
                MessageBox.Show("Problème lors de l'envoi du message : "+ ep.Message, "Erreur : Mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Console.Write("Appuyez sur Entrée pour terminer");
            //Console.ReadLine();
        }


    }
}
