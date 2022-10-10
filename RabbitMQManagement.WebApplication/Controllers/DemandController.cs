using Microsoft.AspNetCore.Mvc;
using RabbitMQManagement.WebApplication.Model;
using RabbitMQManagement.MessageContracts;
using System;
using System.Threading.Tasks;

namespace RabbitMQManagement.WebApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DemandController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterDemandModel moodel)
        {
            var bus = BusConfigurator.ConfigureBus();

            var sendToUri = new Uri($"{RabbitMqConsts.RabbitMqUri}{RabbitMqConsts.RegisterDemandServiceQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            await endPoint.Send<IRegisterDemandCommand>(moodel);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] RegisterDemandModel moodel)
        {
            var bus = BusConfigurator.ConfigureBus();

            var sendToUri = new Uri($"{RabbitMqConsts.RabbitMqUri}{RabbitMqConsts.RegisterDemandServiceQueueUpdate}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            await endPoint.Send<IRegisterDemandCommand>(moodel);
            return Ok();
        }
    }
}
