using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;
using System.Threading.Tasks;

namespace BooKingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        [HttpPost("BookOrder")]

        public async Task<ActionResult> BookOrder()
        {
            string bookingMsg = "Order Placed Successfully";
            string routingKey = "Order.Placed";
           await  SendDataToExchange(bookingMsg,routingKey);
            return Ok($"{bookingMsg}");
        }
        [HttpPost("cancelOrder")]
        public async Task<ActionResult> CancelOrder()
        {
            string bookingMsg = "Order Placed Successfully";
            string routingKey = "Order.Cancel";
            await SendDataToExchange(bookingMsg, routingKey);
            return Ok($"{bookingMsg}");
        }

        private async Task SendDataToExchange(string bookingMsg, string routingKey)
        {
            #region DirectExchange
            //byte[] bookingMsgInBytes = Encoding.UTF8.GetBytes(bookingMsg);
            //ConnectionFactory connectionFactory = new ConnectionFactory();
            //connectionFactory.Uri = new System.Uri("amqp://vani:vani@localhost:5672");
            //using var connection = await connectionFactory.CreateConnectionAsync();
            //using var channel = await connection.CreateChannelAsync();
            //await channel.ExchangeDeclareAsync("vani-Direct-BookingExchange", ExchangeType.Direct, true, false);
            //await channel.BasicPublishAsync("vani-Direct-BookingExchange", routingKey, bookingMsgInBytes);
            //await channel.CloseAsync();
            //await connection.CloseAsync();
            #endregion
            #region FanoutExchange
            //byte[] bookingMsgInBytes = Encoding.UTF8.GetBytes(bookingMsg);
            //ConnectionFactory connectionFactory = new ConnectionFactory();
            //connectionFactory.Uri = new System.Uri("amqp://vani:vani@localhost:5672");
            //using var connection = await connectionFactory.CreateConnectionAsync();
            //using var channel = await connection.CreateChannelAsync();
            //await channel.ExchangeDeclareAsync("vani-Fanout-BookingExchange", ExchangeType.Fanout, true, false);
            //await channel.BasicPublishAsync("vani-Fanout-BookingExchange", routingKey, bookingMsgInBytes);
            //await channel.CloseAsync();
            //await connection.CloseAsync();
            #endregion
            byte[] bookingMsgInBytes = Encoding.UTF8.GetBytes(bookingMsg);
            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.Uri = new System.Uri("amqp://vani:vani@localhost:5672");
            using var connection = await connectionFactory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();
            await channel.ExchangeDeclareAsync("vani-Topic-BookingExchange", ExchangeType.Topic, true, false);
            await channel.BasicPublishAsync("vani-Topic-BookingExchange", routingKey, bookingMsgInBytes);
            await channel.CloseAsync();
            await connection.CloseAsync();

        }
    }
}
