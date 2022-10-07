using RabbitMQManagement.MessageContracts;

namespace RabbitMQManagement.WebApplication.Model
{
    public class RegisterDemandModel : IRegisterDemandCommand
    {
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}
