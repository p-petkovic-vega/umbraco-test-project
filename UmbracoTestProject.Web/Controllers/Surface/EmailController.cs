using UmbracoTestProject.Core.Handlers;
using UmbracoTestProject.Models.AdditionalModels;

namespace UmbracoTestProject.Web.Controllers.Surface
{
    public class EmailController
    {
        public void SendEmail(EmailFormData data)
        {
            MailHandler.Instance.SendMail(string.Empty, string.Empty, string.Empty);
        }
    }
}