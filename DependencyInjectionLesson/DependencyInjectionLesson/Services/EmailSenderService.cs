﻿using DependencyInjectionLesson.DTOs;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Net;

namespace DependencyInjectionLesson.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        public Task SendEmail(EmailMessageDTO emailMessage)
        {
            using (SmtpClient client = new SmtpClient("smtp.mail.ru", 587))
            {
                client.Credentials = new NetworkCredential { UserName = "igor_2002_25@mail.ru", Password = "GoFuckYourselfHack3r" };
                client.EnableSsl = true;
                client.Timeout = 5000;
                return client.SendMailAsync("igor_2002_25@mail.ru", emailMessage.To, emailMessage.Title, emailMessage.Text);
            }
        }
    }
}
