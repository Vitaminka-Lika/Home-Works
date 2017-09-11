using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Car
    {
        private string mark;
        private string model;
        private string color;
        private double volueOfCistern;
        private int horsepower;

        public void SetMark(string mark)
        {
            this.mark = mark;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetVolueOfCistern(double volueOfCistern)
        {
            this.volueOfCistern = volueOfCistern;
        }
        public void SetHorsepower(int horsepower)
        {
            this.horsepower = horsepower;
        }

        public string GetMark()
        {
            return mark;
        }
        public string GetModel()
        {
            return model;
        }
        public string GetColor()
        {
            return color;
        }
        public double GetVolueOfCistern()
        {
            return volueOfCistern;
        }
        public int GetHorsepower()
        {
            return horsepower;
        }
    }
}
