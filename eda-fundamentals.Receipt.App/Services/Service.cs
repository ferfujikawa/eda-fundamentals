using eda_fundamentals.Order.Infra.EventServices;
using eda_fundamentals.Receipt.Domain.EventServices;

namespace eda_fundamentals.Receipt.App.Services
{
    public class Service
    {
        public IKafkaReceiptEventService kafkaReceiptEventService { get; private set; }

        public Service(IKafkaReceiptEventService kafkaReceiptEventService)
        {
            this.kafkaReceiptEventService = kafkaReceiptEventService;
        }

        public async Task RunAsync()
        {
            await kafkaReceiptEventService.DeQueueAsync();
        }
    }
}
