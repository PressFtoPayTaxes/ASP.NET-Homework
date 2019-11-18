using System.Threading.Tasks;

namespace DependencyInjectionLesson.Services
{
    public interface ISmsSenderService
    {
        Task SendSms(string phoneNumber);
    }
}
