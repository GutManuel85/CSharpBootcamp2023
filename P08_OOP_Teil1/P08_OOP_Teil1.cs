using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_OOP_Teil1
{
    internal class P08_OOP_Teil1
    {

        public static void Main(string[] args)
        {
            Car car1 = new Car("BMW", "d45", 2004, 6.0f);
            car1.Honk();
            Console.WriteLine(car1.GetFullInfo());
            Console.WriteLine($"Das Auto verbraucht {car1.CalculateFuelConsumption(400)} Liter Benzin");
        }

    }
}
