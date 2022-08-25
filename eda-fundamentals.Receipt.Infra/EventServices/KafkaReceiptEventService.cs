using Confluent.Kafka;
using eda_fundamentals.Receipt.Domain.Events;
using eda_fundamentals.Receipt.Domain.EventServices;
using eda_fundamentals.Receipt.Infra.ExternalServices;
using System.Text.Json;

namespace eda_fundamentals.Receipt.Infra.EventServices
{
    public class KafkaReceiptEventService : IKafkaReceiptEventService
    {
        private readonly IConsumer<string, string> _consumer;

        public KafkaReceiptEventService(KafkaConsumerConfig consumerConfig)
        {
            _consumer = new ConsumerBuilder<string, string>(consumerConfig).Build();
            _consumer.Subscribe(consumerConfig.Topic);
        }

        public async Task DeQueueAsync()
        {
            while (true)
            {
                var cr = await Task.FromResult(_consumer.Consume());
                var data = JsonSerializer.Deserialize<OrderPlacedEvent>(cr.Message.Value);
                Console.WriteLine($"Consumed record with key {cr.Message.Key} and Order Id {data?.Order.Id.ToString()}");
            }
        }
    }
}
