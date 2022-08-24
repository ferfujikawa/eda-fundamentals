using eda_fundamentals.Shared.Configurations;

namespace eda_fundamentals.Order.Api.Configurations
{
    public class KafkaConfiguration : IKafkaConfiguration
    {
        public string? Url { get; set; }
    }
}
