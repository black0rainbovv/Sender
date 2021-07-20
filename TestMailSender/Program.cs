using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace TestMailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage message = new MailMessage("black0rainbovv@gmail.com", "black0rainbovv@gmail.com");
            message.Subject = "Заголовок";
            message.Body = "тело";
            message.IsBodyHtml = false;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential
            {
                UserName = "black0rainbovv",
                Password = "123"
            };

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Не удалось отправить сообщение {0}", ex);
            }
            Console.ReadLine();
        }
    }
}
