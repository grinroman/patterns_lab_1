using System;
using System.Collections.Generic;
using System.Text;

namespace lab_real_1_patterns
{
    public sealed class BackendServer
    {

        private static readonly Dictionary<int, BackendServer> serverPool =
        new Dictionary<int, BackendServer>
        {
            {1,new BackendServer() { ServerName="Server 1", IPAddress="121.121.121.121" } },
            {2,new BackendServer() { ServerName="Server 2", IPAddress="121.125.129.122" } },
            {3,new BackendServer() { ServerName="Server 3", IPAddress="121.131.121.123" } }
        };

        private static readonly object _lock = new object();
        string ServerName { get; set; }
        string IPAddress { get; set; }

        public void Display()
        {
            Console.WriteLine("Request received by backend server {0} ip {1}", ServerName, IPAddress);
        }

        private static readonly Random random = new Random();
        private static readonly object randomLock = new object();
        public static BackendServer GetAvailableBackendServer()
        {
            lock (randomLock)
            {
                int key = random.Next(1, (serverPool.Count + 1));
                return serverPool[key];
            }

        }
    }
    class LoadBalancer
    {
        BackendServer ConnectToAvailableServer()
        {
            return BackendServer.GetAvailableBackendServer();
        }

        public void SericeRequest()
        {
            BackendServer instance = ConnectToAvailableServer();
            instance.Display();
        }
    }
}
