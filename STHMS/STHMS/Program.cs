using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STHMS
{
    class Program
    {
        static void SecsToHoursMinsSecs(int totalSeconds, out int hours, out int mins, out int secs)
        {
            // tijdelijke tussentijdse variabele
            int rest = 0;

            // algoritme:
            hours = totalSeconds / (60 * 60);
            rest = totalSeconds % (60 * 60);
            mins = rest / 60;
            secs = rest % 60;
        }
        static void Main(string[] args)
        {
            int h = 0;
            int m = 0;
            int s = 0;

            SecsToHoursMinsSecs(61, out h, out m, out s);

            Console.WriteLine("{0} hours {1} minutes and {2} seconds", h, m, s);
        }
    }
}
