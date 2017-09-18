using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path=Console.ReadLine();//"http://www.microsoft.com"
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex) {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
