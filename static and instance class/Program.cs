using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_and_instance_class
{

    class Circle
    {
        static float _PI;
        int _Radius;

        

        public Circle(int Radius)
        {
            Console.WriteLine("Instance constructor called");
            this._Radius = Radius;
        }

        static Circle()
        {
            Console.WriteLine("Static constructor called");
            Circle._PI = 3.141F;

        }

        public float CalculateArea ()
        {
            // return this._PI * this._Radius * this._Radius;
            return Circle._PI * this._Radius * this._Radius;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(7);
            float Area1 = c1.CalculateArea();
            Console.WriteLine("Area of the circle is = {0}", Area1);
            

            Circle c2 = new Circle(10);
            float Area2 = c2.CalculateArea();
            Console.WriteLine("Area of the circle is = {0}", Area2);
            Console.ReadLine();


        }
    }
}
