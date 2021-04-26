using System.Collections.Generic;
using System.IO;
using TranslateSubtitleVideo.models;

namespace TranslateSubtitleVideo.controller
{
    class CreateSubtitles
    {
        public static bool CreateFileSubtitle(int index, List<string> texts)
        {
            try
            {
                Subtitles subtitle = new Subtitles();

                // index là số thứ tự ảnh được chuyền vào từ lớp videocontroler qua hàm getsubfromvideo()
                subtitle.index = index;
                subtitle.timeStart = Process(index);
                subtitle.timeStart.milisecond = 0;

                subtitle.timeEnd = Process(index);
                subtitle.timeEnd.milisecond = 999;

                subtitle.contentSubtitle = texts;
                using (StreamWriter writer = new StreamWriter(@"Subtitles.txt", true))
                {
                    writer.WriteLine(subtitle.index);
                    writer.WriteLine(subtitle.timeStart.ToString() + " --> " + subtitle.timeEnd.ToString());
                    foreach (string line in subtitle.contentSubtitle)
                    {
                        writer.WriteLine(line);
                    }
                    writer.WriteLine();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        static Time Process(int index)
        {
            Time time = new Time();
            if (index < 60) // second
            {
                time.hour = 0;
                time.minute = 0;
                time.second = index;
            }
            else if (index < 3600) // minute
            {
                time.hour = 0;
                time.minute = index / 60;
                time.second = index - (index / 60) * 60;
            }
            else
            {
                time.hour = index / 3600;
                time.minute = (index - time.hour * 3600) / 60;
                time.second = index - (time.minute * 60 + time.hour * 3600);
            }
            return time;
        }
    }
}
