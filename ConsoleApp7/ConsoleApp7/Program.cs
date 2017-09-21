using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            House house = new House();
            TeamLeader teamLeader = new TeamLeader();
            Worker worker = new Worker();
            while (house.GetStep() != 11)
            {
                teamLeader.DoJob(house,house.GetStep());
                worker.DoJob(house, house.GetStep());
            }
            Console.WriteLine("Done \n (T_T)");
            Console.ReadLine();
        }
    }
}
