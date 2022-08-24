namespace eda_fundamentals.Receipt.Domain.EventServices
{
    public interface IKafkaReceiptEventService
    {
        public Task DeQueueAsync();
    }
}
