using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;

            using (FileStream fileStream = new FileStream(@"C:\Users\Alika\source\repos\ConsoleApp3\ConsoleApp3\numbers.txt", FileMode.OpenOrCreate))
            {
                StreamReader streamReader = new StreamReader(fileStream);
                value = streamReader.ReadToEnd();
            }

            string[] points = value.Split(' ');

            List<int> newNumbers = new List<int> { };

            for (int i = 0; i < points.Length; i++)
            {
                int check;
                if (Int32.TryParse(points[i], out check))
                {
                    newNumbers.Add(Int32.Parse(points[i]));
                }          
            }

            int size = newNumbers.Count;

            int indexOfLastNumber = size - 1;
            int indexOfSecondLastNumber = indexOfLastNumber - 1;
            

            for (int i = 0; i < size; ++i)
            {
                int newElem = newNumbers[indexOfLastNumber] + newNumbers[indexOfSecondLastNumber];

                newNumbers.Add(newElem);
                indexOfLastNumber++;
                indexOfSecondLastNumber++;
            }

            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Alika\source\repos\ConsoleApp3\ConsoleApp3\RESULT.txt", false, System.Text.Encoding.Default))
            {
                foreach (int point in newNumbers)
                {
                    streamWriter.Write(point + " ");
                    Console.WriteLine(point + "- check");
                }
            }

            using (FileStream fileStream = new FileStream(@"C:\Users\Alika\source\repos\ConsoleApp3\ConsoleApp3\INPUT.txt", FileMode.OpenOrCreate))
            {
                StreamReader streamReader = new StreamReader(fileStream);
                value = streamReader.ReadToEnd();
            }

            points = value.Split(' ');
            List<int> sumOfAB = new List<int>();

            for (int i = 0; i < points.Length; ++i)
            {
                int check;
                if (Int32.TryParse(points[i], out check))
                {
                    sumOfAB.Add(Int32.Parse(points[i]));
                }
            }

            int sum = 0;

            for (int i = 0; i < sumOfAB.Count; ++i)
            {
                sum += sumOfAB[i];
            }

            newNumbers.Add(sum);

            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Alika\source\repos\ConsoleApp3\ConsoleApp3\OUTPUT.txt", false, System.Text.Encoding.Default))
            {
                streamWriter.Write(sum);
            }

            Console.ReadLine();
        }
    }
}
