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
            FindPiThread e = new FindPiThread(20);

            Console.ReadKey();
        }
    }
}