using eda_fundamentals.Shared.Configurations;

namespace eda_fundamentals.Receipt.App.Configurations
{
    public class KafkaConsumerConfiguration : IKafkaConsumerConfiguration
    {
        public string? BootstrapServers { get; set; }
        public string? GroupId { get; set; }
        public bool? EnableAutoCommit { get; set; }
        public int? AutoCommitIntervalMs { get; set; }
        public int? StatisticsIntervalMs { get; set; }
        public int? AutoOffsetReset { get; set; }
    }
}
