using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENA4_Assignment
{
    internal class ArrayList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
           
            al.Add("Pramod");
            al.Add("Aniket");
            al.Add("PENA4");
            al.Add("Sanket");
            al.Add(1234);

            foreach (var elements in al)
            {
                Console.WriteLine(elements);
            }
        }
    }
    
}
