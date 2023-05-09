using Azure.Messaging.ServiceBus;
using Common.ServiceBus;

namespace Fiap.Microservices.Ui.Extensions
{
    public static class ServiceBusStoreCatalog
    {
        public async static Task<IServiceCollection> AddServiceBusStoreCatalog(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ServiceBusConnection"];
            var queueName = "ingredients";

            var consumer = new Consumer(connectionString, queueName);

            await consumer.Start(MessageHandler, ErrorHandler);

            return services;
        }

        async static Task MessageHandler(ProcessMessageEventArgs args)
        {
            string body = args.Message.Body.ToString();
            Console.WriteLine($"Received: {body}");

            // complete the message. message is deleted from the queue. 
            await args.CompleteMessageAsync(args.Message);
        }

        // handle any errors when receiving messages
        static Task ErrorHandler(ProcessErrorEventArgs args)
        {
            Console.WriteLine(args.Exception.ToString());
            return Task.CompletedTask;
        }
    }
}
