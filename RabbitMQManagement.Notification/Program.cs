using MassTransit;
using RabbitMQManagement.MessageContracts;
using System;

namespace RabbitMQManagement.Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Notification";
            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(RabbitMqConsts.NotificationServiceQueue, e =>
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
