using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace ConAppBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Start Ad Id :");
            int StartAdId = int.Parse(Console.ReadLine());
            Console.Write("Enter Last Ad Id :");
            int StartLast = int.Parse(Console.ReadLine());
            for (int i = StartAdId; i <= StartLast; i++)
            {
                var data = new ProcessStartInfo("chrome.exe");
                data.Arguments = "http://adsjob5k.com/5k02/cashads.php?ad=" +i.ToString();
                Process.Start(data);
                Console.WriteLine(i.ToString());
                Thread.Sleep(60000);
            }
            Console.Read();
        }
    }
}
