using MassTransit;
using RabbitMQManagement.MessageContracts;
using System;

namespace RabbitMQManagement.Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Registration";
            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(RabbitMqConsts.RegisterDemandServiceQueue, e =>
                 {
                     e.Consumer<RegisterDemandCommandConsumer>();
                 });
            });
            bus.StartAsync();
            Console.WriteLine("Listening for Register Demand Commands.."+ "Press enter to exit");
            Console.ReadLine();
            bus.StopAsync(); 
        }
    }
}
