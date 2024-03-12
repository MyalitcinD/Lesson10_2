using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Angle
    {
        int gradus { get; set; }
        int min { get; set; }
        int sec { get; set; }
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if(value < 0) {
                    Console.WriteLine("Градусы меньше 0");
                }
                else {
                    gradus = value;
                }
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if(value < 0) {
                    Console.WriteLine("Минуты меньше 0");
                }
                else {
                    Gradus += value / 60;
                    min = value % 60;
                }

            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if(value < 0) {
                    Console.WriteLine("Секунды меньше 0");
                }
                else {
                    Min += value / 60;
                    sec = value % 60;
                }
            }
        }
        public Angle(int gradus, int minutes, int seconds)
        {
            this.Gradus = gradus;
            this.Min = minutes;
            this.Sec = seconds;
        }

        public double ToRadians()
        {
            double res = (Gradus + Min / 60.0 + Sec / 3600.0) * (Math.PI / 180);
            return res;
        }

    }
}
