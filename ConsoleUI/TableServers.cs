
using System.Collections.Generic;

namespace ConsoleUI
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();
        public List<string> servers = new List<string>();
        private int nextServer = 0;
        private TableServers()
        {
            servers.Add("sevrer_1");
            servers.Add("sevrer_2");
            servers.Add("sevrer_3");
            servers.Add("sevrer_4");
            servers.Add("sevrer_5");
        }
        public static TableServers GetTableServers()
        {
            return _instance;
        }

        public string GetNextServer() 
        {
            string output = servers[nextServer];
            nextServer += 1;

            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }
            return output;
        }
    }
}
