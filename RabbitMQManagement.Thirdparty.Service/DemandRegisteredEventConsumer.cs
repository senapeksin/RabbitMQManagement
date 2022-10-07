using MassTransit;
using RabbitMQManagement.MessageContracts;
using System;
using System.Threading.Tasks;

namespace RabbitMQManagement.Thirdparty.Service
{
    public class DemandRegisteredEventConsumer : IConsumer<IRegisteredDemandEvent>
    {
        public async Task Consume(ConsumeContext<IRegisteredDemandEvent> context)
        {
            await Console.Out.WriteLineAsync($"Thirdparty integration done: Demand id {context.Message.DemandId}");
        }
    }
}
