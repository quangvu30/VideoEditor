using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranslateSubtitleVideo.functions;
using VideoEditor;
using VideoEditor.Controller;

namespace TranslateSubtitleVideo.controller
{
    class VideoController
    {
        static string folderFrames = "Photo/PhotoCuted";
        public static void GetSubtitlesFromVideo()
        {
            // lấy ảnh từ file ảnh đã cắt
            string[] Images = Directory.GetFiles(folderFrames);

            foreach (string image in Images)
            {
                // lấy tên file của từng ảnh
                string fileName = Path.GetFileName(image);

                // lất đối tượng bitmap
                Bitmap b = (Bitmap)Bitmap.FromFile(image);

                Console.WriteLine(fileName);
                DetectText detectText = new DetectText(env.Default.KeyId, env.Default.SecretKey);

                Console.WriteLine(env.Default.KeyId + ", " + env.Default.SecretKey);

                // truyền bitmap vào hàm phát hiện ảnh
                List<string> contents = detectText.TextDetection(b);
                foreach (string t in contents)
                    Console.WriteLine(t);

                // lấy số là tên của ảnh làm số thứ tự
                // index là số thứ tự ảnh, mỗi ảnh là 1 s
                CreateSubtitles.CreateFileSubtitle(int.Parse(fileName.Split('.')[0]), contents);
            }
            Console.WriteLine("==========================================");
        }

        public static void SplitFrames(string input)
        {
            string command = $@"ffmpeg -i {input} -r 1 -s 1000x600 -qscale:v 2 -f image2 Photo/%d.jpeg ";
            RunCMD(command);
        }

        public static void AddSub(string INFILE, string SUBS, string OUTFILE)
        {
            string command = $"ffmpeg -i {INFILE} -vf subtitles={SUBS}:force_style='Borderstyle=4,Fontsize=16,BackColour=H80000000' {OUTFILE}";
            RunCMD(command);
        }

        private static void RunCMD(string ffmpegComand)
        {
            using (System.Diagnostics.Process process = new System.Diagnostics.Process())
            {
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C " + ffmpegComand;

                process.StartInfo = startInfo;

                process.Start();
                process.WaitForExit();
                Console.WriteLine("Done");
            }
        }

        static Bitmap CropImage(Bitmap img, Rectangle cropRect)
        {
            Bitmap bitmap = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(img, new Rectangle(0, 0, bitmap.Width, bitmap.Height), cropRect, GraphicsUnit.Pixel);
            }
            return bitmap;
        }


        static void cutImage()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(@"Photo");
            foreach (FileInfo file in di.GetFiles())
            {
                using (Bitmap image = (Bitmap)Bitmap.FromFile(file.FullName))
                {
                    int y = (image.Height / 3);

                    System.IO.Directory.CreateDirectory(@"Photo\PhotoCuted");
                    CropImage(image, new Rectangle(0, 2 * y, image.Width, y)).Save(@"Photo\PhotoCuted\" + file.Name);
                }
            }
        }

        public static void SubCreate(string inputVideo, string outputVideo)
        {
            ClearData(@"Photo\");
            File.Delete("Subtitles.txt");
            File.Delete("SubTranslated.srt");
            SplitFrames(inputVideo);
            cutImage();
            GetSubtitlesFromVideo();
            FireFoxController.Translate("Subtitles.txt");
            AddSub(inputVideo, @"SubTranslated.srt", outputVideo);
        }

        public static void ClearData(string directory)
        {

            System.IO.DirectoryInfo di = new DirectoryInfo(directory);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
