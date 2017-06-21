using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using SummatorRemoteService;

namespace SummatorHost
{
    class SummatorHost
    {
        static void Main(string[] args)
        {
            var channal = new TcpChannel(51495);
            ChannelServices.RegisterChannel(channal, false);
            var service = new SummatorRemoteService.SummatorRemoveService();
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(SummatorRemoteService.SummatorRemoveService), 
                "Summator", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Servise work");
            Console.ReadLine();

        }
    }
}
