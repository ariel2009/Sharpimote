using NetCoreServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SharpiMoteServer.Workflow;

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
        protected override void OnStopping()
        {
            WorkflowVisualization.additionalText = string.Empty;
        }
    }
}
