using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoFirst();
            ToDoSecond();
        }

        static void ToDoFirst()
        {
            Type type = typeof(Console);
            foreach (MethodInfo methodInfo in type.GetMethods())
            {
                ParameterInfo[] paramInfo = methodInfo.GetParameters();
                for (int i = 0; i < paramInfo.Length; i++)
                {
                    Console.WriteLine(paramInfo[i].ParameterType.Name + ": " + paramInfo[i].ParameterType.Attributes);
                }
            }

            Console.ReadLine();
        }

        static void ToDoSecond()
        {
            Book book = new Book()
            {
                Name = "Name",
                Cost = 2840.7,
                Author = "Author",
                Year = 2012
            };

            Type type = typeof(Book);

            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                Console.WriteLine(propertyInfo.Name + " " + propertyInfo.GetValue(book));
            }

            Console.ReadLine();
        }   
    }
}
