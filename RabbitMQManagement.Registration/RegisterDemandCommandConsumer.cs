using MassTransit;
using RabbitMQManagement.MessageContracts;
using System;
using System.Threading.Tasks;

namespace RabbitMQManagement.Registration
{
    public class RegisterDemandCommandConsumer : IConsumer<IRegisterDemandCommand>
    {
        public Task Consume(ConsumeContext<IRegisterDemandCommand> context)
        {
            var message = context.Message;
            var guid = Guid.NewGuid();
            Console.WriteLine($"Demand successfully registered. Sunject:{message.Subject}, Description{message.Description}, ID: {guid}");
            context.Publish<IRegisteredDemandEvent>(new
            {
                DemandId = guid
            });
            return Task.CompletedTask;
        }
    }
    public class RegisterDemandCommandUpdateConsumer : IConsumer<IRegisterDemandCommand>
    {
        public Task Consume(ConsumeContext<IRegisterDemandCommand> context)
        {
            var message = context.Message;
            var guid = Guid.NewGuid();
            Console.WriteLine($"Demand successfully updated. Sunject:{message.Subject}, Description{message.Description}, ID: {guid}");
            context.Publish<IRegisteredDemandEvent>(new
            {
                DemandId = guid
            });
            return Task.CompletedTask;
        }
    }
}
