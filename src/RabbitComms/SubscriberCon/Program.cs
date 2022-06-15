
using RabbitMQ.Client;

namespace SubscriberCon;

public class Program
{
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Starting Subscriber App");

        // TODO: Begin listening!!
        var factory = new ConnectionFactory { HostName = "localhost" }; 
        var connection = factory.CreateConnection(); 
        using var channel = connection.CreateModel();
        channel.QueueDeclare("orders");
        
        
        Console.ReadKey();
    }
}