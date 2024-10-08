﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoreServer;
using System.Net;
using System.Net.Sockets;
using SharpiMoteServer.Workflow;

namespace SharpiMoteServer.Networking
{
    internal class BaseSession : TcpSession
    {
        public BaseSession(TcpServer server) : base(server) { }
        protected override void OnConnected()
        {
            WorkflowVisualization.additionalText += $"Sharpimote TCP session with {Id} connected!";

            // Send invite message
            string message = "Hello from TCP Sharpimote! Please send a message or '!' to disconnect the client!";
            SendAsync(message);
        }

        protected override void OnDisconnected()
        {
            Console.WriteLine($"Sharpimote TCP session with Id {Id} disconnected!");
        }

        protected override void OnReceived(byte[] buffer, long offset, long size)
        {
            string message = Encoding.UTF8.GetString(buffer, (int)offset, (int)size);
            Console.WriteLine("Incoming: " + message);

            // Multicast message to all connected sessions
            Server.Multicast(message);

            // If the buffer starts with '!' the disconnect the current session
            if (message == "!")
                Disconnect();
        }

        protected override void OnError(SocketError error)
        {
            Console.WriteLine($"Sharpimote TCP session caught an error with code {error}");
        }
    }
}
