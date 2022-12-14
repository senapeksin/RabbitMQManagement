using Microsoft.AspNetCore.Mvc;
using RabbitMQManagement.Api.Model;
using RabbitMQManagement.MessageContracts;
using System;
using System.Threading.Tasks;

namespace RabbitMQManagement.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandController : ControllerBase
    {
        public async Task<IActionResult> Post([FromBody] RegisterDemandModel moodel)
        {
            var bus = BusConfigurator.ConfigureBus();

            var sendToUri = new Uri($"{RabbitMqConsts.RabbitMqUri}{RabbitMqConsts.RegisterDemandServiceQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            await endPoint.Send<IRegisterDemandCommand>(moodel);
            return Ok();
        }
    }
}
