using DependencyInjectionLesson.DTOs;
using System.Threading.Tasks;

namespace DependencyInjectionLesson.Services
{
    public interface IEmailSenderService
    {
        Task SendEmail(EmailMessageDTO emailMessage);
    }
}
