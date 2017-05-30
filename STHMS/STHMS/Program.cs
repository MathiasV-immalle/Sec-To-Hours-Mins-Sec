using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STHMS
{
    class Program
    {
        static int hours;
        static int mins;
        static int secs;

        static void SecToHoursMinsSecs(int totalSeconds)
        {
            int rest = 0;

            hours = totalSeconds / (60 * 60);
            rest = totalSeconds % (60 * 60);
            mins = rest / 60;
            secs = rest % 60;
        }

        static void Main(string[] args)
        {
            SecToHoursMinsSecs(61);

            Console.WriteLine("{0} Hours {1} Minutes and {2} Seconds", hours, mins, secs);
        }
    }
}
