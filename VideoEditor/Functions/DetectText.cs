using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateSubtitleVideo.functions
{
    class DetectText
    {
        AmazonRekognitionClient rekognitionClient;
        public DetectText(string KeyId, string secretKey)
        {
            rekognitionClient = new AmazonRekognitionClient(KeyId, secretKey, Amazon.RegionEndpoint.APNortheast2);
        }

        public async Task<List<string>> TextDetectionAsync(Bitmap b)
        {
            List<string> res = new List<string>();

            DetectTextRequest detectText = new DetectTextRequest()
            {
                Image = new Amazon.Rekognition.Model.Image()
                {
                    Bytes = new MemoryStream(ImageToBytes(b))
                }
            };

            try
            {
                DetectTextResponse detectTextResponse = await rekognitionClient.DetectTextAsync(detectText);
                foreach (TextDetection text in detectTextResponse.TextDetections)
                {

                    if (text.Type == TextTypes.LINE)
                    {
                        res.Add(text.DetectedText);
                        Console.WriteLine("Left : " + text.Geometry.BoundingBox.Left);
                        Console.WriteLine("Top " + text.Geometry.BoundingBox.Top);
                        Console.WriteLine("Height " + text.Geometry.BoundingBox.Height);
                        Console.WriteLine("width " + text.Geometry.BoundingBox.Width);
                    }
                    Console.WriteLine("------------------------------------");
                }
                return res;
            }
            catch
            {
                return new List<string>();
            }
        }


        public List<string> TextDetection(Bitmap b)
        {
            List<string> res = new List<string>();

            DetectTextRequest detectText = new DetectTextRequest()
            {
                Image = new Amazon.Rekognition.Model.Image()
                {
                    Bytes = new MemoryStream(ImageToBytes(b))
                }
            };

            try
            {
                DetectTextResponse detectTextResponse = rekognitionClient.DetectText(detectText);
                foreach (TextDetection text in detectTextResponse.TextDetections)
                {

                    if (text.Type == TextTypes.LINE)
                    {
                        res.Add(text.DetectedText);
                        Console.WriteLine("Left : " + text.Geometry.BoundingBox.Left);
                        Console.WriteLine("Top " + text.Geometry.BoundingBox.Top);
                        Console.WriteLine("Height " + text.Geometry.BoundingBox.Height);
                        Console.WriteLine("width " + text.Geometry.BoundingBox.Width);
                    }
                    Console.WriteLine("------------------------------------");
                }
                return res;
            }
            catch
            {
                return new List<string>();
            }
        }

        public List<string> TextDetectionNon(Bitmap b)
        {
            List<string> res = new List<string>();

            DetectTextRequest detectText = new DetectTextRequest()
            {
                Image = new Amazon.Rekognition.Model.Image()
                {
                    Bytes = new MemoryStream(ImageToBytes(b))
                }
            };

            try
            {
                DetectTextResponse detectTextResponse = rekognitionClient.DetectText(detectText);
                foreach (TextDetection text in detectTextResponse.TextDetections)
                {

                    if (text.Type == TextTypes.LINE)
                    {
                        res.Add(text.DetectedText);
                        Console.WriteLine("Left : " + text.Geometry.BoundingBox.Left);
                        Console.WriteLine("Top " + text.Geometry.BoundingBox.Top);
                        Console.WriteLine("Height " + text.Geometry.BoundingBox.Height);
                        Console.WriteLine("width " + text.Geometry.BoundingBox.Width);
                    }
                    Console.WriteLine("------------------------------------");
                }
                return res;
            }
            catch
            {
                return new List<string>();
            }
        }

        byte[] ImageToBytes(Bitmap img)
        {
            return (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
        }
    }
}
