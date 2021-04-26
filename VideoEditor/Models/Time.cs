using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateSubtitleVideo.models
{
    class Time
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public int milisecond { get; set; }

        public Time(int hour, int minute, int second, int milisecond)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.milisecond = milisecond;
        }

        public Time() { }

        public override string ToString()
        {
            return hour + ":" + minute + ":" + second + "," + milisecond;
        }
    }
}
