using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace bookingDetailsRecieve
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.Uri = new Uri("amqp://vani:vani@localhost:5672");
            var connection = await connectionFactory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();
           await channel.QueueDeclareAsync("vani-Topic-Queue", true, false, false);
           await channel.QueueBindAsync("vani-Topic-Queue", "vani-Topic-BookingExchange", "Order.*");
            var eventBasicconsumer = new AsyncEventingBasicConsumer(channel);
            //Event is triggered when message comes from Exchange
            eventBasicconsumer.ReceivedAsync += (sender, e) =>
            {
                var bookingResponse = Encoding.UTF8.GetString(e.Body.ToArray());
                Console.WriteLine(bookingResponse);
                return Task.CompletedTask;
            };
           await channel.BasicConsumeAsync("vani-Topic-Queue", true, eventBasicconsumer);
            Console.ReadLine();
        }
    }
}
