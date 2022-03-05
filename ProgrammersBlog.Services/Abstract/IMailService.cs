using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;

namespace ProgrammersBlog.Services.Abstract
{
    public interface IMailService
    {
        IResult Send(EmailSendDto emailSendDto); //alper@altu.dev
        IResult SendContactEmail(EmailSendDto emailSendDto); //alper@altu.dev info@programmersblog.com iletisim@programmersblog.com
    }
}
