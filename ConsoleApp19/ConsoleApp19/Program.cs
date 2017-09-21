using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("https://habrahabr.ru/rss/interesting/");
            XmlElement main = xmlDocument.DocumentElement;

            List<Item> list = new List<Item>();

            foreach (XmlElement Doc in main)
            {
                foreach (XmlElement current in Doc)
                {
                    if (current.Name.Equals("item"))
                    {
                        Item item = new Item();
                        item.Title = current["title"].InnerText;
                        item.Link = current["link"].InnerText;
                        item.Description = current["description"].InnerText;
                        item.PubDate = DateTime.Parse(current["pubDate"].InnerText);
                        list.Add(item);
                    }
                }
            }

            foreach (Item item in list)
            {
                Console.WriteLine(item.Title);
            }

            Console.ReadLine();

            XmlDocument document = new XmlDocument();
            document.Load("Student.xml");

            XmlElement sMain = document.DocumentElement;

            XmlElement student = document.CreateElement("student");
            XmlElement name = document.CreateElement("name");
            XmlElement course = document.CreateElement("course");

            XmlText nameContent = document.CreateTextNode("Example name");
            XmlText courseContent = document.CreateTextNode("1");

            name.AppendChild(nameContent);
            course.AppendChild(courseContent);

            student.AppendChild(course);
            sMain.AppendChild(student);

            document.Save("Student.xml");

            Console.WriteLine(document["name"] + " " + document["course"]);
            Console.ReadLine();
        }
    }
}
