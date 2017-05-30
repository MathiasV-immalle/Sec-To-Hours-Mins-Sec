using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STHMS
{
    struct HMSTime
    {
        public int Hours;
        public int Mins;
        public int Secs;

        public override string ToString()
        {
            return String.Format("{0} hours {1} minutes and {2} seconds", Hours, Mins, Secs);
        }
    }

    class Program
    {
        static HMSTime SecToHMS(int totalSeconds)
        {
            HMSTime time;
            int rest = 0;

            time.Hours = totalSeconds / (60 * 60);
            rest = totalSeconds % (60 * 60);
            time.Mins = rest / 60;
            time.Secs = rest % 60;

            return time;
        }

        static void Main(string[] args)
        {
            HMSTime time = SecToHMS(61000);
            Console.WriteLine("{0} hours {1} minutes and {2} seconds", time.Hours, time.Mins, time.Secs);
        }

    }
}
