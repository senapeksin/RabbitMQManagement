namespace RabbitMQManagement.MessageContracts
{
    public class RabbitMqConsts
    {
        public const string RabbitMqUri = "rabbitmq://localhost/";
        public const string UserName = "end";
        public const string Password = "@123456@";
        public const string RegisterDemandServiceQueue = "registerdemand.service";
        public const string RegisterDemandServiceQueueUpdate = "registerdemandUpdate.service";
        public const string NotificationServiceQueue = "notification.service";
        public const string ThirdPartyServiceQueue = "thirdparty.service";
    }
}
