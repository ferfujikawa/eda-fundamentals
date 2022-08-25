using Confluent.Kafka;
using eda_fundamentals.Shared.Configurations;

namespace eda_fundamentals.Receipt.Infra.ExternalServices
{
    public class KafkaConsumerConfig : ConsumerConfig
    {
        public KafkaConsumerConfig(IKafkaConsumerConfiguration configuration)
        {
            BootstrapServers = configuration.BootstrapServers;
            GroupId = configuration.GroupId;
            EnableAutoCommit = configuration.EnableAutoCommit;
            AutoCommitIntervalMs = configuration.AutoCommitIntervalMs;
            StatisticsIntervalMs = configuration.StatisticsIntervalMs;
            //AutoOffsetReset = configuration.AutoOffsetReset;
            AutoOffsetReset = Confluent.Kafka.AutoOffsetReset.Earliest;
            Topic = configuration.Topic;
        }

        public string Topic { get; private set; }
    }
}
