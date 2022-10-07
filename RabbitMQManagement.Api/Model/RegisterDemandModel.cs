using RabbitMQManagement.MessageContracts;

namespace RabbitMQManagement.Api.Model
{
    public class RegisterDemandModel : IRegisterDemandCommand
    {
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}
