using Confluent.Kafka;
using eda_fundamentals.Shared.Configurations;

namespace eda_fundamentals.Order.Infra.ExternalServices
{
    public class KafkaProducerConfig : ProducerConfig
    {
        public KafkaProducerConfig(IKafkaConfiguration kafkaConfiguration)
        {
            BootstrapServers = kafkaConfiguration.Url;
        }
    }
}
