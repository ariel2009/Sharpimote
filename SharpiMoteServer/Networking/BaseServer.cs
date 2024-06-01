using NetCoreServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharpiMoteServer.Networking
{
    internal class BaseServer : TcpServer
    {
        public BaseServer(IPAddress address, int port) : base(address, port) { }

        protected override TcpSession CreateSession() { return new BaseSession(this); }

        protected override void OnError(SocketError error)
        {
            Console.WriteLine($"Sharpimote TCP server caught an error with code {error}");
        }
    }
}
