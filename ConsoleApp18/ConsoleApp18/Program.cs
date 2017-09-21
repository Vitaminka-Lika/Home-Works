using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                 new Book{
                    Name="firstName",
                    Cost=34.5,
                    Author="firstAuthor",
                    Year=2007
                },
                 new Book{
                    Name="secondName",
                    Cost=525.5,
                    Author="secondAuthor",
                    Year=2011
                },new Book{
                    Name="thirdName",
                    Cost=238,
                    Author="thirdAuthor",
                    Year=2016
                },
            };

            int sizeOfList = books.Count;

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("books.txt", FileMode.OpenOrCreate))
            {
                foreach (Book bo in books)
                {
                    formatter.Serialize(fs, bo);
                    Console.WriteLine("Объект сериализован");
                }
            }

            Console.ReadLine();

            using (FileStream fs = new FileStream("books.txt", FileMode.OpenOrCreate))
            {
                for(int i=0; i < sizeOfList; i++) { 
                    List<Book> booksDeserialized = new List<Book> { };
                    booksDeserialized.Add((Book)formatter.Deserialize(fs));

                    foreach (Book dbook in booksDeserialized)
                    {
                        Console.WriteLine("Объект десериализован");
                        Console.WriteLine("Название: {0} \t Автор: {1}", dbook.Name, dbook.Author);
                    }
                }
            }
            Console.ReadLine();

            TestClass test = new TestClass();
            test.Change(43);
            int result = test.Return();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
