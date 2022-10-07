using System;

namespace RabbitMQManagement.MessageContracts
{
    /// <summary>
    /// Kaydedilen talebi dinleyen consumer’ları bilgilendirmek için interface
    /// </summary>
    public interface IRegisteredDemandEvent
    {
        public Guid DemandId { get; set; }
    }
}
