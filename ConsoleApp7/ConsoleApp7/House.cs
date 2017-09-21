using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class House 
    {
        public List<object> allParts = new List<object> {};

        private int step = 0;
        public House()
        {
            allParts.Add(new Basement());
            allParts.Add(new Walls());
            allParts.Add(new Windows());
            allParts.Add(new Door());
            allParts.Add(new Roof());                   
        }
        public int GetStep() {
            return step;
        }
        public void AddStep()
        {
            step++;
        }
    }
}
