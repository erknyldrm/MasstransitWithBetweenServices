using MassTransit;
using MessageContracts;
using MessageContracts.Consumers;

var bus = BusConfigurator.ConfigureBus(configuration =>
{
    configuration.ReceiveEndpoint(RabbitMQConstants.OrderServiceQueueName, e =>
    {
        e.Consumer<SubmitOrderCommandConsumer>();
    });
});

await bus.StartAsync();

Console.WriteLine("Listening order commands... Press any key to exit.");
Console.ReadKey();

await bus.StopAsync();
