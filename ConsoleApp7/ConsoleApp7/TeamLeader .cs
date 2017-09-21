using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class TeamLeader : IWorker
    {
        public bool DoJob(House house, int step)
        {
            if (step == house.allParts.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
