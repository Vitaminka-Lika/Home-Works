using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Worker : IWorker
    {
        public bool DoJob(House house, int step)
        {
            if (house.GetStep() == 11) { house.AddStep(); return true; }
            else { house.AddStep(); return false; }
        }
    }
}
