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
            ToDoFirst();
            Console.ReadLine();
            ToDoSecond();
        }

        static void ToDoSecond()
        {
            try
            {
                Console.WriteLine("Введите размер массива");
                int size;
                string userInput = Console.ReadLine();
                bool isOperationDone = Int32.TryParse(userInput, out size);
                if (isOperationDone)
                {
                    int[] nums = new int[size];
                    for (int i = 0; i <= size; i++)
                    {
                        nums[i] = i;
                    }
                }
            }
            catch(Exception ex) {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Массив обработан");
                Console.ReadLine();
            }
        }

        static void ToDoFirst()
        {
            try
            {
                string path = Console.ReadLine();//"http://www.microsoft.com"
                WebClient client = new WebClient();
                client.DownloadString(path);
                Process.Start(path);


            }
            catch (WebException ex)
            {
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
