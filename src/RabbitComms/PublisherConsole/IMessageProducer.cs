namespace PublisherConsole;

public interface IMessageProducer
{
    void SendMessage<T> (T message);
}