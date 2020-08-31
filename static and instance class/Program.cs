using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_and_instance_class
{

    class Circle
    {
        float _PI = 3.14F;
        int _Radius;

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea ()
        {
            return this._PI * this._Radius * this._Radius;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(7);
            float Area = c1.CalculateArea();
            Console.WriteLine("Area of the circle is = {0}", Area);
            Console.ReadLine();


        }
    }
}
