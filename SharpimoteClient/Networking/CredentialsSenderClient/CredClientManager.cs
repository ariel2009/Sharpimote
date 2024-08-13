using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SharpimoteClient.Networking.CredentialsSenderClient
{
    internal class CredentialsJSON
    {
        public string? IP_addr { get; set; } = "NO_IP_RETRIEVED";
        public string? Code { get; set; } = "NO_USERNAME_RETRIEVED";
        public string? Password { get; set; } = "NO_PASS_RETRIEVED";
        public CredentialsJSON(string? _ip_addr, string? _code, string? _password)
        {
            IP_addr = _ip_addr;
            Code = _code;
            Password = _password;
        }
    }
    internal class CredClientManager
    {
        const ushort PORT = 4479;
        const string SERVER_ADDR = "127.0.0.1";
        BaseClient credSenderClient;
        public CredClientManager()
        {
            credSenderClient = new BaseClient(SERVER_ADDR, PORT);
        }
        public void StartClient()
        {
            credSenderClient.ConnectAsync();
        }
        public void SerializeCredAndSend(CredentialsJSON creds)
        {
            string jsonString = JsonSerializer.Serialize(creds);
            credSenderClient.SendAsync(Encoding.UTF8.GetBytes(jsonString));
        }
        public void StopClient()
        {
            credSenderClient.DisconnectAndStop();
        }
    }
}
