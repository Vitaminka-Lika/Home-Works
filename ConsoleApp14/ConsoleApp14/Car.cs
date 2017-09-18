using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
     public partial class Car
    {
        static string nameOfObject;//Это все машины
        static long series;//из одной серии

        private string mark;
        private string model;
        private string color;
        private double volueOfCistern;
        private int horsepower;

        public Car()
        {
            SetMark("none");
            SetModel("none");
            SetColor("none");
            SetVolueOfCistern(0);
            SetHorsepower(0);
            SetNameOfObject("Car");
            SetSeries(0);
        }

        public Car(string _nameOfObject, long _series, string mark, string model, string color, double volueOfCistern, int horsepower)
        {
            SetNameOfObject(_nameOfObject);
            SetSeries(_series);
            SetMark(mark);
            SetModel(model);
            SetColor(color);
            SetVolueOfCistern(volueOfCistern);
            SetHorsepower(horsepower);
        }

        public Car(string _nameOfObject, long _series)
        {
            SetNameOfObject(_nameOfObject);
            SetSeries(_series);
        }

        static Car()
        {           
            SetNameOfObject("Car");
            SetSeries(000);
        }
        public static void SetNameOfObject(string _nameOfObject)
        {
            nameOfObject = _nameOfObject;
        }
        public static void SetSeries(long _series)
        {
            series = _series;
        }
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

        public void SetHorsePower(ref int horsepower)
        {
            this.horsepower = horsepower;
        }

        public static string GetNameOfObject()
        {
            return nameOfObject;
        }
        public static long GetSeries()
        {
            return series;
        }
    }
}
