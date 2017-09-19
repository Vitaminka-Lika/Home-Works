using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = Console.ReadLine();//"http://www.microsoft.com"
                WebClient client=new WebClient();
                client.DownloadString(path);
                Process.Start(path);


            }
            catch (WebException ex) {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.ReadLine();
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Ошибка: " + ex.Message);
            //    Console.ReadLine();
            //}
        }
    }
}
