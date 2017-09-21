﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Roof : IPart
    {
        bool isHave = false;

        public bool GetCondition()
        {
            return isHave;
        }
        public void GetName(House house)
        {
            house.AddStep();
            Console.WriteLine("Roof");
            isHave = true;
        }
    }
}
