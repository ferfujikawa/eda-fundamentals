using Confluent.Kafka;
using eda_fundamentals.Order.Domain.Events;
using eda_fundamentals.Order.Domain.EventServices;
using eda_fundamentals.Order.Infra.ExternalServices;
using System.Text.Json;
using static Confluent.Kafka.ConfigPropertyNames;

namespace eda_fundamentals.Order.Infra.EventServices
{
    public class KafkaOrderEventService : IOrderEventService
    {
        private readonly IProducer<string, string> _producer;
        private readonly TopicPartition _topicPartition;

        public KafkaOrderEventService(KafkaProducerConfig producerConfig)
        {
            _producer = new ProducerBuilder<string, string>(producerConfig).Build();
            _topicPartition = new TopicPartition(producerConfig.Topic, new Partition());
        }

        public async Task QueueAsync(OrderPlacedEvent domainEvent)
        {
            string data = JsonSerializer.Serialize(domainEvent);
            await _producer.ProduceAsync(_topicPartition, new Message<string, string> { Key = domainEvent.Id.ToString(), Value = data });
            _producer.Flush();
        }
    }
}
