using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace DependencyInjectionLesson.Services
{
    public class SmsSenderService : ISmsSenderService
    {
        public Task SendSms(string phoneNumber)
        {
            const string accountSid = "ACd24769f7bcf82e80861fde0719a3cc1f";
            const string authToken = "f8c770a942e3f56b48ab5808f5fe0715";

            TwilioClient.Init(accountSid, authToken);

            return MessageResource.CreateAsync(
                body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
                from: new Twilio.Types.PhoneNumber("+15005550006"),
                to: new Twilio.Types.PhoneNumber(phoneNumber)
            );
        }
    }
}
