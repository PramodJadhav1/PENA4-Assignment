using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENA4_Assignment
{
    internal class Biggestnumber
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Find the Biggest of three numbers:");
            Console.Write("------------------------------------");
            Console.WriteLine("Enter the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number is the Biggest among three.");
                }
                else
                {
                    Console.WriteLine("The 3rd Number is the Biggest among three.");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd Number is the Biggest among three.");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the Biggest among three.");
            }
        }

    }
}

