using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ForecastDesign.Statics.StaticClasses.GetApiKeys;

namespace ForecastDesign.Statics.StaticClasses.GetSmtpCode
{
    public static class GetCode
    {
        public static async Task<string> GmailVerify(string gmail)
        {
            //----------- SMTP ------------

            int VerifyCode = Random.Shared.Next(111111, 999999);
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(GetApiKey.GetApiKeyString("Smtp","Gmail"));
            string sbj = "VERIFY CODE";
            msg.Subject = sbj;
            msg.To.Add(new MailAddress(gmail));
            msg.Body = VerifyCode.ToString();
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("pervinagayev28@gmail.com",GetApiKey.GetApiKeyString("Smtp", "Password")),
                EnableSsl = true
            };
            smtpClient.Send(msg);
            return VerifyCode.ToString();
        }
    }
}
