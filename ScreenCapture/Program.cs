using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace ScreenCapture
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                Thread.Sleep(1000);
                //ScreenShot.ScreenCapture sc = new ScreenShot.ScreenCapture();
                //sc.CaptureScreenToFile($"{new Random().Next(10)}.jpeg", ImageFormat.Jpeg);

                Bitmap bt = CaptureScreen.CS.GetDesktopImage();
                bt.Save($"{new Random().Next(10)}.jpeg", ImageFormat.Jpeg);
            }
        }
    }
}
