using Microsoft.Extensions.Options;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using ProgrammersBlog.Shared.Utilities.Results.Concrete;
using System.Net;
using System.Net.Mail;

namespace ProgrammersBlog.Services.Concrete
{
    public class MailManager : IMailService
    {
        private readonly SmtpSettings _smtpSettings;

        public MailManager(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }

        public IResult Send(EmailSendDto emailSendDto)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(_smtpSettings.SenderEmail), // alpertunga004@outlook.com
                To = { new MailAddress(emailSendDto.Email) }, //alper@altu.dev
                Subject = emailSendDto.Subject, //Şifremi Unuttum // Siparişiniz Başarıyla Kargolandı.
                IsBodyHtml = true,
                Body = emailSendDto.Message // "12345" No'lu siparişiniz kargolanmıştır.
            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpSettings.Server,
                Port = _smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);

            return new Result(ResultStatus.Success, $"E-Postanız başarıyla gönderilmiştir.");
        }

        public IResult SendContactEmail(EmailSendDto emailSendDto)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(_smtpSettings.SenderEmail), // Ahmet Yılmaz ahmetyilmaz@gmail.com // Blog Uygulamanıza Yeni Bir İçerik Önerisi
                To = { new MailAddress("novalioglu2@gmail.com") }, //info@grogrammersblog.com
                Subject = emailSendDto.Subject,
                IsBodyHtml = true,
                Body = $"Gönderen Kişi: {emailSendDto.Name},<br/> Gönderen E-Posta Adresi: {emailSendDto.Email},<br/> Mesajınız: {emailSendDto.Message}"
            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpSettings.Server,
                Port = _smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);

            return new Result(ResultStatus.Success, $"E-Postanız başarıyla gönderilmiştir.");
        }
    }
}
