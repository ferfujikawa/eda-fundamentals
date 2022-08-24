using Confluent.Kafka;
using eda_fundamentals.Receipt.Domain.EventServices;
using eda_fundamentals.Receipt.Infra.ExternalServices;

namespace eda_fundamentals.Order.Infra.EventServices
{
    public class KafkaReceiptEventService : IKafkaReceiptEventService
    {
        private readonly IConsumer<string, string> _consumer;

        public KafkaReceiptEventService(KafkaConsumerConfig consumerConfig)
        {
            _consumer = new ConsumerBuilder<string, string>(consumerConfig).Build();
            _consumer.Subscribe("OrderPlacedEvent");
        }

        public async Task DeQueueAsync()
        {
            while (true)
            {
                var cr = await Task.FromResult(_consumer.Consume());
                Console.WriteLine($"Consumed record with key {cr.Message.Key} and value {cr.Message.Value}");
            }
        }
    }
}
