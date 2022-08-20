using MassTransit;
using MessageContracts;
using MessageContracts.Consumers;

var bus = BusConfigurator.ConfigureBus(configuration =>
{
    configuration.ReceiveEndpoint(RabbitMQConstants.BillingServiceQueueName, e =>
    {
        e.Consumer<SubmittedOrderBillEventConsumer>();
    });
});

await bus.StartAsync();

Console.WriteLine("Listening order commands... Press any key to exit.");
Console.ReadKey();

await bus.StopAsync();