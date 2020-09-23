using SmsIrRestful;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace Utilities.Smsdotir
{
    public class SendSms
    {
        public static Boolean SendSmsActivation(string to, string text)
        {
            var token = new Token().GetToken("52b6109a842e993ee1193d23", "hamihomes");
            var restVerificationCode = new RestVerificationCode()
            {
                Code = text,
                MobileNumber = to,

            };

            var restVerificationCodeRespone = new VerificationCode().Send(token, restVerificationCode);

            if (restVerificationCodeRespone.IsSuccessful)
            {
                return true;
            }
            else
            {

            }
            return false;
        }
    }

    
}
