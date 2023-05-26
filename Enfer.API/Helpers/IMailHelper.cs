using Enfer.Shared.Responses;

namespace Enfer.API.Helpers
{
    public interface IMailHelper
    {

        Response SendMail(string toName, string toEmail, string subject, string body);

    }
}
