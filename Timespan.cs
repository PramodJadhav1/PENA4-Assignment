﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENA4_Assignment
{
    internal class Timespan
    {
        static void Main(string[] args)
        {
            TimeSpan time;

            TimeSpan ts1 = new TimeSpan(10, 20, 50);
            TimeSpan ts2 = new TimeSpan(8, 19, 32);

            time = ts1 + ts2;

            Console.WriteLine("Hours:{0}, Minutes:{1}, Seconds:{2}", time.Hours, time.Minutes, time.Seconds);
        }
    }
    
}
