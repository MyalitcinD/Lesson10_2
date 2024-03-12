using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradus = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            int seconds = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(gradus, minutes, seconds);
            //Angle angle2 = new Angle(5, 30, 30);
            Console.WriteLine("Radians = {0}", angle.ToRadians());
            Console.WriteLine("deg = {0} min = {1} sec = {2}", angle.Gradus, angle.Min, angle.Sec);
            Console.ReadKey();
        }
    }
}
