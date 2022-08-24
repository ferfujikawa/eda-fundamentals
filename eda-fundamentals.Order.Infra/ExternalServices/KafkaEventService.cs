using Confluent.Kafka;
using eda_fundamentals.Shared.Events;
using eda_fundamentals.Shared.EventServices;
using System.Text.Json;

namespace eda_fundamentals.Order.Infra.ExternalServices
{
    public class KafkaEventService : IEventService
    {
        public async Task QueueAsync(IDomainEvent evt)
        {
            var config = LoadConfig();
            var value = JsonSerializer.Serialize(evt);
            Produce("orders", evt.Id.ToString(), value, config);
        }

        private static ClientConfig LoadConfig()
        {
            var cloudConfig = new Dictionary<string, string>
            {
                {"bootstrap.servers", "localhost:29092"}
            };

            var clientConfig = new ClientConfig(cloudConfig);
            return clientConfig;
        }

        private static void Produce(string topic, string key, string value, ClientConfig config)
        {
            using var producer = new ProducerBuilder<string, string>(config).Build();
            
            producer.Produce(topic, new Message<string, string> { Key = key, Value = value },
            (deliveryReport) =>
            {
                if (deliveryReport.Error.Code != ErrorCode.NoError)
                    throw new Exception(deliveryReport.Error.Reason);
            });
            producer.Flush(TimeSpan.FromSeconds(10));
        }
    }
}
