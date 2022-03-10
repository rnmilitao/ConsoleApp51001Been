using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51001Been
{
   public class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(args[0]);
            int B = int.Parse(args[1]);

            int X = A + B;
            Console.WriteLine("X= {0}\n", X);
            Console.ReadKey();
        }
    }
}
