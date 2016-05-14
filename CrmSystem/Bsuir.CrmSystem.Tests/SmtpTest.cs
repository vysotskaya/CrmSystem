using System;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bsuir.CrmSystem.Tests
{
    [TestClass]
    public class SmtpTest
    {
        [TestMethod]
        public void SmtpSendMailTest()
        {
            //Адрес SMTP-сервера
            String smtpHost = "smtp.gmail.com";
            //Порт SMTP-сервера
            int smtpPort = 465;
            //Логин
            String smtpUserName = "LOGIN";
            //Пароль
            String smtpUserPass = "PASSWORD";

            //Создание подключения
            SmtpClient client = new SmtpClient(smtpHost, smtpPort);
            client.Credentials = new NetworkCredential(smtpUserName, smtpUserPass);

            //Адрес для поля "От"
            String msgFrom = "LOGIN@SERVER.RU";
            //Адрес для поля "Кому" (адрес получателя)
            String msgTo = "KUDA@TO.RU";
            //Тема письма
            String msgSubject = "Письмо от C#";
            //Текст письма
            String msgBody = "Привет!\r\n\r\nЭто тестовое письмо\r\n\r\n--\r\nС уважением, C# :-)";
            //Вложение для письма
            //Если нужно больше вложений, для каждого вложения создаем свой объект Attachment с нужным путем к файлу
            Attachment attachData = new Attachment("D:\\Тестовое вложение.zip");

            //Создание сообщения
            MailMessage message = new MailMessage(msgFrom, msgTo, msgSubject, msgBody);
            //Крепим к сообщению подготовленное заранее вложение
            message.Attachments.Add(attachData);

            try
            {
                //Отсылаем сообщение
                client.Send(message);
            }
            catch (SmtpException ex)
            {
                //В случае ошибки при отсылке сообщения можем увидеть, в чем проблема
                Console.WriteLine(ex.InnerException.Message.ToString());
            }
        }
    }
}
