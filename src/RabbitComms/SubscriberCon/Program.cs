
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace SubscriberCon;

public class Program
{
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Starting Subscriber App");

        var factory = new ConnectionFactory { HostName = "localhost" }; 
        var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();
        channel.QueueDeclare("orders", exclusive: false);

        var consumer = new EventingBasicConsumer(channel);
        consumer.Received += (model, eventArgs) =>
        {
            var body = eventArgs.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);

            Console.WriteLine(message);
        };

        //Start consumer
        Console.WriteLine("Starting Consumer");
        channel.BasicConsume(queue: "orders", autoAck: true, consumer: consumer);

        Console.WriteLine("Subscribe Process Complete - Awaiting KeyPress");
        Console.ReadKey();
    }
}