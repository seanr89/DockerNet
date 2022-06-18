using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace PublisherConsole;

public class RabbitMQProducer : IMessageProducer
{
    public void SendMessage<T>(T message)
    {
        Console.WriteLine("SendMessage");
        var factory = new ConnectionFactory
        {
            HostName = "localhost"
        };

        var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare("orders", exclusive: false);

        var json = JsonConvert.SerializeObject(message);
        var body = Encoding.UTF8.GetBytes(json);

        channel.BasicPublish(exchange: "", routingKey: "orders", body: body);
    }
}