using MassTransit;
using RabbitMQManagement.MessageContracts;
using System;

namespace RabbitMQManagement.Thirdparty.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Thirdparty";
            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(RabbitMqConsts.ThirdPartyServiceQueue, e =>
                {
                    e.Consumer<DemandRegisteredEventConsumer>();
                });
            });
            bus.StartAsync();
            Console.WriteLine("Listening for  Demand registered Events.." + "Press enter to exit");
            Console.ReadLine();
            bus.StopAsync();
        }
    }
}
