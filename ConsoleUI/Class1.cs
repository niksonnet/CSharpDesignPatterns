using System;

namespace ConsoleUI
{
    public class Class1
    {
        public static readonly TableServers host1 = TableServers.GetTableServers();
        public static readonly TableServers host2 = TableServers.GetTableServers();
        public static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                GetHost1servers();
                GetHost2servers();
            }

            Console.ReadLine();
        }

        public static void GetHost1servers()
        {
            Console.WriteLine("The next Sevver is {0}", host1.GetNextServer());
        }
        public static void GetHost2servers()
        {
            Console.WriteLine("The next Sevver is {0}", host1.GetNextServer());
        }
    }
}
