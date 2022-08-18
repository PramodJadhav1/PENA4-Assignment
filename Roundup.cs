using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENA4_Assignment
{
    internal class Roundup
    {
        static void Main(string[] args)
        {
            double[] val = { 4.125, 4.135, 4.165, 4.175 };
            Console.WriteLine("Rounded values are:");

            foreach (double value in val)
           Console.WriteLine("{0} == {1}", value, Math.Round(value, 2, MidpointRounding.ToEven));


        }
    }
}
