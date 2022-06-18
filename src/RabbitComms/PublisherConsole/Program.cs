using RabbitMQ.Client;

namespace PublisherConsole;

public class Program
{
    public static async Task Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Starting Publisher App");

        // var factory = new ConnectionFactory { HostName = "localhost" };
        // var connection = factory.CreateConnection();
        // using var channel = connection.CreateModel();
        // channel.QueueDeclare("orders");
        var messagePub = new RabbitMQProducer();

        //TODO: Begin listening!!
        var counter = 0;
        var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
        while (max == -1 || counter < max)
        {
            //Console.WriteLine($"Counter: {++counter}");
            Order order = new()
                {
                Id = counter,
                ProductName = "hello",
                Price = new Random().Next(10, 50),
                Date = DateTime.Now
            };
            messagePub.SendMessage(order);
            await Task.Delay(5000);
        }
        Console.WriteLine("Process Complete");
        Console.ReadLine();
    }
}