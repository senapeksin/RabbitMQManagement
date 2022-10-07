using MassTransit;
using RabbitMQManagement.MessageContracts;
using System;
using System.Threading.Tasks;

namespace RabbitMQManagement.Notification
{
    class DemandRegisteredEventConsumer : IConsumer<IRegisteredDemandEvent>
    {
        public async Task Consume(ConsumeContext<IRegisteredDemandEvent> context)
        {
            await Console.Out.WriteLineAsync($"Notification sent: Demand id {context.Message.DemandId}");
        }
    }
}
