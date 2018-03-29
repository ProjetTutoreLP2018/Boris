using EASendMail;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();

            // Your gmail email address
            Console.Write("Your mail : ");
            string from = Console.ReadLine();
            oMail.From = from;

            //Password du type
            Console.Write("Password : ");
            string pass = "";
            // Backspace Should Not Work
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter);
            Console.WriteLine("");

            // Set recipient email address
            Console.Write("To : ");
            string to = Console.ReadLine();
            oMail.To = to;

            // Set email subject
            Console.Write("Titre : ");
            string title = Console.ReadLine();
            oMail.Subject = title;

            // Set email body
            Console.Write("Contenu : ");
            string content = Console.ReadLine();
            oMail.TextBody = content;

            //Test PJ
            Console.Write("Chemin de la pièce jointe : ");
            string pj = Console.ReadLine();
            pj = pj.Substring(1,pj.Length-2);
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
            Console.Write("Appuyez sur Entrée pour terminer");
            Console.ReadLine();
        }
    }
}
