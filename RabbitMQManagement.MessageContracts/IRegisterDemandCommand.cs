namespace RabbitMQManagement.MessageContracts
{
    /// <summary>
    /// Talebi kaydetmek için interface
    /// </summary>
    public interface  IRegisterDemandCommand
    {
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}
