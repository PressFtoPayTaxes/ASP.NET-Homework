using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionLesson.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mail;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using DependencyInjectionLesson.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjectionLesson.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<IActionResult> SaveEntity(EmailMessageDTO emailMessage)
        {
            await emailSenderService.SendEmail(emailMessage);
            return Ok();
        }
        
        [HttpGet("{phoneNumber}")]
        public async Task<IActionResult> GetCodeVerification(string phoneNumber)
        {
            await smsSenderService.SendSms(phoneNumber);
            return Ok();
        }
    }
}
