using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { };

            bool isOperationDone = false;

            int size=0;

            int max=0;
            int secondMax=0;

            int sum=0;

            for (; !isOperationDone;)
            {
                
                Console.WriteLine("Введите количество элементов:");

                isOperationDone = Int32.TryParse(Console.ReadLine(), out size);

                if (size < 0)
                {
                    isOperationDone = false;
                }

                else
                {
                    for (int i = 0; i < size; i++)
                    {

                        isOperationDone = false;

                        for (; !isOperationDone;)
                        {                          
                            Console.WriteLine("Введите значение:");
                        
                            int element;
                            isOperationDone = Int32.TryParse(Console.ReadLine(), out element);

                            if (isOperationDone)
                            {
                                list.Add(element);
                               
                                if (i == 0)
                                {
                                    max = element;
                                    secondMax = element;
                                    sum += element;
                                }
                                else
                                {
                                    if (i % 2 == 0)
                                    {
                                        sum += element;
                                    }

                                    if (element >= max)
                                    {
                                        secondMax = max;
                                        max = element;
                                    }
                                }
                            }
                        }
                    }
                }
            }
           
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("Второй максимальный элемент = {0} \t Сумма на четных позициях = {1}", secondMax, sum);
            Console.ReadLine();
        }
    }
}
