using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateSubtitleVideo.models
{
    class Subtitles
    {
        public int index { get; set; }
        public Time timeStart { get; set; }
        public Time timeEnd { get; set; }
        public List<string> contentSubtitle { get; set; }
    }
}
