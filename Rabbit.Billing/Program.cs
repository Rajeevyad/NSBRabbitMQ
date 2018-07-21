using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Billing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rabbit Billing";

            var endpointConfiguration = new EndpointConfiguration("Rabbit.Billing");

            var transport = endpointConfiguration.UseTransport<RabbitMQTransport>();
            transport.ConnectionString("host=localhost");
            transport.UsePublisherConfirms(true);
            transport.UseDirectRoutingTopology();
        }
    }
}
