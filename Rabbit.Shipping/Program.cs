using Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rabbit Shipping";

            var endpointConfiguration = new EndpointConfiguration("Rabbit.Shipping");

            var transport = endpointConfiguration.UseTransport<RabbitMQTransport>();
            transport.ConnectionString("host=localhost");
            transport.UsePublisherConfirms(true);
            transport.UseDirectRoutingTopology();
        }
    }
}
