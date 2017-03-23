using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank_Measurement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.WriteLine("Welcome to my application. This app will help you determine the amount of fuel fills that you'll have to perform during your ride");
            Console.WriteLine("First enter the distance of your journey in km.");
            string Distance = Console.ReadLine();
            double a;
            double.TryParse(Distance, out a);
            Console.WriteLine("Now enter average fuel consumption in km/l.");
            string fuel_consumption = Console.ReadLine();
            double b;
            double.TryParse(fuel_consumption, out b);
            Console.WriteLine("Now lastly enter the fuel tank size in L.");
            string fuel_tank = Console.ReadLine();
            double c;
            double.TryParse(fuel_tank, out c);

            //Process
            double d = b * c;
            double e = a / d;
            double f = Math.Ceiling(e);
                                    
            //Output
            Console.WriteLine("You need to top up your tank " + f + " times.");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
