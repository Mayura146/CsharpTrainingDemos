using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace WithSingleResponsibility
{
    class EmailNotification

    { 
        public static void SendEmail()
    {
        try
        {
            MailMessage mailMessage = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            mailMessage.From = new MailAddress("mayura.sonar83@gmail.com");
            mailMessage.To.Add(new MailAddress("mayura.sonar@outlook.com"));
            mailMessage.Subject = "Single Responsibilty Demo";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "We will be discussing SOLID Principle";
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("mayura.sonar83@gmail.com",
                "Mayura@123");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(mailMessage);
            Console.WriteLine("Email Sent Successfully");
        }

        catch (Exception e)
        {
            Console.WriteLine("Error occured" + e.Message);
        }
    }
}
}
