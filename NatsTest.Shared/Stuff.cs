using NATS.Client;
using System;

namespace NatsTest.Shared
{
    public static class Stuff
    {
        private static IConnection natsConnection;

        public static IConnection NatsConnection
        {
            get
            {
                if (natsConnection == null)
                {
                    natsConnection = ConnectToNats();
                }

                return natsConnection;
            }
        }

        private static IConnection ConnectToNats()
        {
            var factory = new ConnectionFactory();

            var options = ConnectionFactory.GetDefaultOptions();
            options.Url = "nats://localhost:4222";

            return factory.CreateConnection(options);
        }
    }
}
