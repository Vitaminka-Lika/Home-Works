using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            int size;
            string userInput = Console.ReadLine();
            bool isOperationDone = Int32.TryParse(userInput, out size);
            if (isOperationDone)
            {
                Console.WriteLine("Введите числа через Enter");
                int[] nums = new int[size];
                for (int i = 0; i < size; i++)
                {
                    int number;
                    bool isOperationDone2 = Int32.TryParse(Console.ReadLine(), out number);
                    if (isOperationDone2)
                    {
                        nums[i] = (int)Math.Pow(number, 2);
                    }
                    else {
                        Console.WriteLine("Ошибка ввода");
                        Console.ReadLine();
                    }
                }
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Number"+i+" "+nums[i]);                   
                }
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Ошибка ввода");
                Console.ReadLine();
            }
        }
    }
}
