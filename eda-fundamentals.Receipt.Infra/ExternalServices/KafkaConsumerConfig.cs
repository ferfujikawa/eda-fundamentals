using Confluent.Kafka;
using eda_fundamentals.Shared.Configurations;

namespace eda_fundamentals.Receipt.Infra.ExternalServices
{
    public class KafkaConsumerConfig : ConsumerConfig
    {
        public KafkaConsumerConfig(IKafkaConfiguration kafkaConfiguration)
        {
            BootstrapServers = kafkaConfiguration.Url;
            GroupId = "local";
            EnableAutoCommit = true;
            AutoCommitIntervalMs = 5000;
            StatisticsIntervalMs = 6000;
            AutoOffsetReset = Confluent.Kafka.AutoOffsetReset.Earliest;
        }
    }
}
