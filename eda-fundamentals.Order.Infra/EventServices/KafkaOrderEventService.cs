using Confluent.Kafka;
using eda_fundamentals.Order.Domain.Events;
using eda_fundamentals.Order.Domain.EventServices;
using eda_fundamentals.Order.Infra.ExternalServices;
using System.Text.Json;

namespace eda_fundamentals.Order.Infra.EventServices
{
    public class KafkaOrderEventService : IOrderEventService
    {
        private readonly IProducer<string, string> _producer;

        public KafkaOrderEventService(KafkaProducerConfig producerConfig)
        {
            _producer = new ProducerBuilder<string, string>(producerConfig).Build();
        }

        public async Task QueueAsync(OrderPlacedEvent domainEvent)
        {
            string data = JsonSerializer.Serialize(domainEvent);

            await _producer.ProduceAsync(typeof(OrderPlacedEvent).Name, new Message<string, string> { Key = domainEvent.Id.ToString(), Value = data });
            _producer.Flush();
        }
    }
}
