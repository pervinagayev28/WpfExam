using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ForecastDesign.Statics.StaticClasses.GetSmtpCode
{
    public static class GetCode
    {
        public static string GmailVerify(string gmail)
        {
            //----------- SMTP ------------

            int VerifyCode = Random.Shared.Next(111111, 999999);
            string fp = "vovj vpqf mcgx sopj";
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("pervinagayev28@gmail.com");
            string sbj = "VERIFY CODE";
            msg.Subject = sbj;
            msg.To.Add(new MailAddress(gmail));
            msg.Body = VerifyCode.ToString();
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("pervinagayev28@gmail.com", fp),
                EnableSsl = true
            };
            smtpClient.Send(msg);
            return VerifyCode.ToString();
        }
    }
}
