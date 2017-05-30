using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STHMS
{
    class Time
    {
        private int totalSecs;
        private int hours;
        private int mins;
        private int secs;

        public Time(int totalSeconds)
        {
            totalSecs = totalSeconds;

            int rest = 0;

            hours = totalSeconds / (60 * 60);
            rest = totalSeconds % (60 * 60);
            mins = rest / 60;
            secs = rest % 60;
        }

        public int Hours { get { return hours; } }
        public int Mins { get { return mins; } }
        public int Secs { get { return secs; } }
        public int TotalSeconds { get { return totalSecs; } }

        public override string ToString()
        {
            return string.Format("{0} hours {1} minutes and {2} seconds", hours, mins, secs);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time(61);

            Console.WriteLine(t);
            Console.WriteLine("{0} seconden zijn eigenlijk {1} uur, {2} minuten en {3} seconden.",
                t.TotalSeconds, t.Hours, t.Mins, t.Secs);
        }
    }
}
