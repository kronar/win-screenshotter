using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using System;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int screenWidth = Screen.GetBounds(new Point(0, 0)).Width;
            int screenHeight = Screen.GetBounds(new Point(0, 0)).Height;
            Bitmap bmpScreenShot = new Bitmap(screenWidth, screenHeight);
            Graphics gfx = Graphics.FromImage((Image)bmpScreenShot);
            gfx.CopyFromScreen(0, 0, 0, 0, new Size(screenWidth, screenHeight));
            bmpScreenShot.Save("screen.png", ImageFormat.Png);
        }
    }
}
