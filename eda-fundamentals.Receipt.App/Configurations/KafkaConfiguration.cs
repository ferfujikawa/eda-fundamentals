using eda_fundamentals.Shared.Configurations;

namespace eda_fundamentals.Receipt.App.Configurations
{
    public class KafkaConfiguration : IKafkaConfiguration
    {
        public string? Url { get; set; }
    }
}
