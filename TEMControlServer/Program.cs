using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;

namespace TEMControlServer
{
    class TEMControlRemoteServer
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Server: Reading the config file..");
            RemotingConfiguration.Configure("Server.config", false);

            Console.WriteLine("Server ready...");
            Console.ReadLine();
        }
    }
}
