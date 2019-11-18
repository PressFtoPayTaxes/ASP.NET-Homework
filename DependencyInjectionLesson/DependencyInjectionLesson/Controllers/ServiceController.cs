using System.Threading.Tasks;
using DependencyInjectionLesson.DTOs;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionLesson.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjectionLesson.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServiceController : Controller
    {
        private readonly IEntitySaverService entitySaverService;
        private readonly IEmailSenderService emailSenderService;
        private readonly ISmsSenderService smsSenderService;

        public ServiceController(IEntitySaverService entitySaverService, IEmailSenderService emailSenderService, ISmsSenderService smsSenderService)
        {
            this.entitySaverService = entitySaverService;
            this.emailSenderService = emailSenderService;
            this.smsSenderService = smsSenderService;
        }

        [HttpPost]
        public async Task<IActionResult> SaveEntity(EntityDTO entity)
        {
            await entitySaverService.SaveEntity(entity);
            return Ok();
        }
        
        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailMessageDTO emailMessage)
        {
            await emailSenderService.SendEmail(emailMessage);
            return Ok();
        }
        
        [HttpGet/*("{phoneNumber}")*/]
        public async Task<IActionResult> GetCodeVerification(/*string phoneNumber = "+77015286829"*/)
        {
            await smsSenderService.SendSms("+77015286829");
            return Ok();
        }
    }
}
