using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMicroservice2.IntergrationEvents.Events;
using RabbitMQ.Client;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Text;

namespace StudentMicroservice2.Service
{
    public class SimpleEventBusService : ISimpleEventBusService
    {
        public void Publish(StudentCreatedIntegratedEvent studentCreatedIntegratedEvent)
        {
            Debug.WriteLine("Publish running");
            var factory = new ConnectionFactory() { HostName = "rabbitmqyeosy-75ddc5ee1994a137.elb.us-east-2.amazonaws.com", Port = 5672};
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "Eventbus", type: ExchangeType.Fanout);

                var message = JsonConvert.SerializeObject(studentCreatedIntegratedEvent);
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: "Eventbus",
                                     routingKey: "",
                                     basicProperties: null,
                                     body: body);
                Debug.WriteLine(" StudentController Sent {0}", message);
            }

        }
    }
}
