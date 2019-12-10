using System;
using System.Collections.Generic;
using System.Text;

namespace Metanit_Lessons
{
    class ImplicitConversion_30
    {
        public int Seconds { get; set; }
        
        public static implicit operator ImplicitConversion_30(int x)
        {
            return new ImplicitConversion_30 { Seconds = x };
        }

        public static explicit operator int(ImplicitConversion_30 x)
        {
            return (int)x.Seconds;
        }

        public void Display()
        {
            Console.WriteLine(this.Seconds);
        }

    }

    class Timer
    {
        private int Hours { get; set; }
        private int Minutes { get; set; }
        private int Seconds { get; set; }

        public static implicit operator Timer(ImplicitConversion_30 x)
        {
            int h = x.Seconds / 3600;
            int m = (x.Seconds - h * 3600) / 60;
            int s = x.Seconds - h * 3600 - m * 60;
            return new Timer { Hours = h, Minutes = m, Seconds = s };
        }

        public static implicit operator ImplicitConversion_30(Timer x)
        {
            int h = x.Hours * 3600;
            int m = x.Minutes * 60;
            return new ImplicitConversion_30 { Seconds = h + m + x.Seconds };
        }

        public void Display()
        {
            Console.WriteLine($"{this.Hours}:{this.Minutes}:{this.Seconds}");
        }
    }
}
