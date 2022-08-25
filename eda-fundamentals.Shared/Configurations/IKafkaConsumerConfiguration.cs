namespace eda_fundamentals.Shared.Configurations
{
    public interface IKafkaConsumerConfiguration
    {
        string BootstrapServers { get; set; }
        string GroupId { get; set; }
        string Topic { get; set; }
        bool EnableAutoCommit { get; set; }
        int AutoCommitIntervalMs { get; set; }
        int StatisticsIntervalMs { get; set; }
        int AutoOffsetReset { get; set; }
    }
}
