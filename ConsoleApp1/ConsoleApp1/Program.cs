using EASendMail;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*try
            {*/
            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();

            // Your gmail email address
            oMail.From = "sender";

            // Set recipient email address
            oMail.To = "receveur@gmail.com";

            // Set email subject
            oMail.Subject = "test email from gmail account";

            // Set email body
            oMail.TextBody = "this is a test email sent from c# project with gmail.";
            // Gmail SMTP server address
            SmtpServer oServer = new SmtpServer("smtp.gmail.com");

            // Set 587 port, if you want to use 25 port, please change 587 5o 25
            oServer.Port = 587;

            // detect SSL/TLS automatically
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

            // Gmail user authentication
            // For example: your email is "gmailid@gmail.com", then the user should be the same
            oServer.User = "mailSender";
            oServer.Password = "pass";
            Console.WriteLine("start to send email over SSL ...");
            oSmtp.SendMail(oServer, oMail);
            Console.WriteLine("email was sent successfully!");
            try
            {
                
            }
            catch (Exception ep)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ep.Message);
            }
            //MessageBox.Show("mail Send");
            Console.WriteLine("mail send");
                System.Threading.Thread.Sleep(10000);
            /*}
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
                System.Threading.Thread.Sleep(10000);
            }*/
        }
    }
}
