/* Author: Jordan Taylor
 * Date: 03 / 22 / 2021
 * Description: Throws darts at a board and estimates pi from it. The more you throw the closer you get to pi.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            int throwNum = 0; // throws to make
            int threadNum = 0; // threads to run
            int dartsInside = 0;

            List<Thread> threads = new List<Thread>();
            List<FindPiThread> piThread = new List<FindPiThread>();

            Console.WriteLine("Enter how many throws to make ");
            throwNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter how many threads ");
            threadNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < threadNum; i++)
            {
                FindPiThread pi = new FindPiThread(throwNum);
                piThread.Add(pi);

                Thread thread = new Thread(new ThreadStart(pi.throwDarts));
                threads.Add(thread);
                thread.Start();
                Thread.Sleep(16);
            }
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
            foreach (FindPiThread thread in piThread)
            {
                dartsInside += thread.dartsLanded;
            }

            double total = throwNum * threadNum; // this is to help make the console output a double

            Console.WriteLine(4 * (dartsInside / total));

            Console.ReadKey();
        }
    }
}