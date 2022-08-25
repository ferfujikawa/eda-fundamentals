using eda_fundamentals.Shared.Configurations;

namespace eda_fundamentals.Order.Api.Configurations
{
    public class KafkaConfiguration : IKafkaProducerConfiguration
    {
        public string BootstrapServers { get; set; }
        public string Topic { get; set; }
    }
}
