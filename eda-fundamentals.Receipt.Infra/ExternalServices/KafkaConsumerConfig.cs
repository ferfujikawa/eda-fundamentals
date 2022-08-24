using Confluent.Kafka;
using eda_fundamentals.Shared.Configurations;

namespace eda_fundamentals.Receipt.Infra.ExternalServices
{
    public class KafkaConsumerConfig : ConsumerConfig
    {
        public KafkaConsumerConfig(IKafkaConsumerConfiguration kafkaConsumerConfiguration)
        {
            BootstrapServers = kafkaConsumerConfiguration.BootstrapServers;
            GroupId = kafkaConsumerConfiguration.GroupId;
            EnableAutoCommit = kafkaConsumerConfiguration.EnableAutoCommit;
            AutoCommitIntervalMs = kafkaConsumerConfiguration.AutoCommitIntervalMs;
            StatisticsIntervalMs = kafkaConsumerConfiguration.StatisticsIntervalMs;
            //AutoOffsetReset = kafkaConsumerConfiguration.AutoOffsetReset;
            AutoOffsetReset = Confluent.Kafka.AutoOffsetReset.Earliest;
        }
    }
}
