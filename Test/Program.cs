using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using confluence.slackbot;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            notifier.config cfg = new notifier.config();

            cfg.channel = "HELIX";
            cfg.team = "confluence-software";
            cfg.token = "[REDACTED]";

            Console.WriteLine("Slackbot notifier test app");
            Console.WriteLine();

            Console.Write("Enter message: ");
            string message = Console.ReadLine();
            bool status = notifier.send(cfg, message);

            Console.WriteLine();
            Console.WriteLine("STATUS: " + status.ToString());
            Console.ReadLine();
        }
    }
}
