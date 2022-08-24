using Confluent.Kafka;

namespace eda_fundamentals.Order.Infra.ExternalServices
{
    public class KafkaProducerConfig : ProducerConfig
    {
        public KafkaProducerConfig(string bootStrapServers)
        {
            BootstrapServers = bootStrapServers;
        }
    }
}
