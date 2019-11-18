using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace DependencyInjectionLesson.Services
{
    public class SmsSenderService : ISmsSenderService
    {
        public Task SendSms(string phoneNumber)
        {
            const string accountSid = "ACfd3a59498b9338b75e77b9b2df1c5d20";
            const string authToken = "29c18325e74ec04668c1dc46b0f6baca";

            TwilioClient.Init(accountSid, authToken);

            return MessageResource.CreateAsync(
                body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
                from: new Twilio.Types.PhoneNumber("+15803664617"),
                to: new Twilio.Types.PhoneNumber(phoneNumber)
            );
        }
    }
}
