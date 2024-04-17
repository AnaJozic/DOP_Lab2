
using System;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace DOP.Remoting
{
    class Client
    {
      

        static void Main(string[] args)
        {
            ChannelServices.RegisterChannel(new TcpClientChannel(), true);

            ILogger logger = (ILogger) Activator.GetObject(typeof(ILogger), "tcp://localhost:8086/LoggerService");

            logger.LogMessage(1, "Anamarija");
            logger.LogMessage(2, "Jozic");
            logger.LogMessage(3, "2307");


            Console.WriteLine("Client finished (press [enter] to terminate)\n");
            Console.ReadLine();
        }
    }
}
