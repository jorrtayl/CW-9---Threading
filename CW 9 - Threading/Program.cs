using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            int test1 = 0;

            FindPiThread e = new FindPiThread(test1);

            Console.WriteLine("Enter a number");
            test1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}