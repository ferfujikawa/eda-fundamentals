using Confluent.Kafka;
using eda_fundamentals.Shared.Configurations;

namespace eda_fundamentals.Order.Infra.ExternalServices
{
    public class KafkaProducerConfig : ProducerConfig
    {
        public KafkaProducerConfig(IKafkaProducerConfiguration configuration)
        {
            BootstrapServers = configuration.BootstrapServers;
            Topic = configuration.Topic;
        }

        public string Topic { get; private set; }
    }
}
