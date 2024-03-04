using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = x+1; i < x+7; i++ )
            
                Console.WriteLine(i+2);
            }
        }
    }
}
