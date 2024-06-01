using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharpiMoteServer.Networking.CredentialsRecieverServer
{
    internal class CredServerManager
    {
        const ushort PORT = 4479;
        BaseServer credRecieverServer;
        public CredServerManager() {
            credRecieverServer = new BaseServer(IPAddress.Any, PORT);
        }
        public void StartServer()
        {
            
        }
    }
}
