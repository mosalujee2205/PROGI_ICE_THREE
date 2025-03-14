using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICETaskThree
{
    class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }

    }

