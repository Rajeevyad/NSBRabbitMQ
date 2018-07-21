using Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.ClientUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rabbit.ClientUI";

            var endpointConfiguration = new EndpointConfiguration("Rabbit.ClientUI");

            var transport = endpointConfiguration.UseTransport<RabbitMQTransport>();
            transport.ConnectionString("host=localhost");
            transport.UsePublisherConfirms(true);
            transport.UseDirectRoutingTopology();

            var routing = transport.Routing();
            routing.RouteToEndpoint(typeof(PlaceOrder), "Rabbit.Sales");
        }
    }
}
