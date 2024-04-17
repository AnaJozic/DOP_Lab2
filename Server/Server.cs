
using System;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace DOP.Remoting
{
    class Server
    {
        static void Main(string[] args)
        {
            var channel = new TcpServerChannel(8086);
            ChannelServices.RegisterChannel(channel, true);
            
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Logger), "LoggerService", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Server is running (press [enter] to terminate)\n");
            Console.ReadLine();
        }
    }
}
