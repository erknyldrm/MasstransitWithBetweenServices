using MassTransit;
using MessageContracts.Events;

namespace MessageContracts.Consumers
{
    public class SubmittedOrderBillEventConsumer : IConsumer<IOrderSubmittedEvent>
    {

        public async Task Consume(ConsumeContext<IOrderSubmittedEvent> context)
        {
            var message = context.Message;
            await Console.Out.WriteLineAsync($"A bill has been created for the order Id with: {message.OrderId}");
        }
    }
}
