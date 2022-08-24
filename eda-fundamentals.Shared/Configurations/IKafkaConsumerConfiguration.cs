namespace eda_fundamentals.Shared.Configurations
{
    public interface IKafkaConsumerConfiguration
    {
        public string? BootstrapServers { get; set; }
        public string? GroupId { get; set; }
        public bool? EnableAutoCommit { get; set; }
        public int? AutoCommitIntervalMs { get; set; }
        public int? StatisticsIntervalMs { get; set; }
        public int? AutoOffsetReset { get; set; }
    }
}
