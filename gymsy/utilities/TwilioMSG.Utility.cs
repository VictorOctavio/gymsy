using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace gymsy.utilities
{
    class TwilioMSG
    {
        public static void SendMessageWithWhatsapp()
        {
            MessageBox.Show("SENDING MESSAGE...");
            var accountSid = "ACd5798e53aef58ca10bb84d28ad380a42";
            var authToken = "c85c6cb58aada2cdf852ac30eda61657";
            TwilioClient.Init(accountSid, authToken);
            var multimedia = new[] {
            new Uri("https://www.clipartkey.com/mpngs/m/14-148170_police-officer-guard-illustration-traffic-patrol-process-security.png")
        }.ToList();
            var messageOptions = new CreateMessageOptions(
                new PhoneNumber("whatsapp:+5493794079256"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = "ALTO! tu mensualidad vence en 5 dias! No lo olvides";
            messageOptions.MediaUrl = multimedia;
            var message = MessageResource.Create(messageOptions);
            MessageBox.Show(message.Body);
        }
    }
}
