namespace eda_fundamentals.Shared.Configurations
{
    public interface IKafkaProducerConfiguration
    {
        string BootstrapServers { get; set; }
        string Topic { get; set; }
    }
}
