using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class TestClass:Attribute
    {
        int currentCount;
        public void Change(int count)
        {
            currentCount = count;
            currentCount++;
        }
        public int Return()
        {
            return currentCount;
        }
    }
}
