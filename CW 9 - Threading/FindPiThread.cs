/* Author: Jordan Taylor
 * Date: 03 / 22 / 2021
 * Description: Throws darts and checks if it hits or not.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    // Houses thread state and function
    class FindPiThread
    {
        int _dartNum = 0; // number of darts to throw
        public int dartsLanded = 0; // darts that land inside
        private Random _genNum;

        public FindPiThread(int dartNum)
        {
            _genNum = new Random(); // unsure why but the instructions say to
            _dartNum = dartNum; // initializing _dartNum == dartNum from main
            dartsLanded = 0; // says to initialize so I did, unsure why
        }

        public int getLanded
        {
            get => dartsLanded;
            set => dartsLanded = value;
        }

        public void throwDarts()
        {
            double x = 0.0; // x coordinate on the board
            double y = 0.0; // y coordinate on the board

            // loop to throw darts at the board at random x and y locations
            for (int i = 0; i < _dartNum; i++)
            {
                // randomizing x and y
                x = _genNum.NextDouble();
                y = _genNum.NextDouble();

                x = x * x;
                y = y * y;

                // checking if the hypotenuse is 1 or lower
                if (Math.Sqrt(x + y) < 1)
                {
                    dartsLanded++;
                }
            }
        }
    }
}