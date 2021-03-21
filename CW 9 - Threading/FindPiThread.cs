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
        int _dartNum = 0;
        int _dartsLanded = 100; // temporary
        Random _genNum = new Random();

        public FindPiThread(int dartNum)
        {
            _dartNum = dartNum;
            int randomNum = _genNum.Next(dartNum, _dartsLanded);
        }
    }
}