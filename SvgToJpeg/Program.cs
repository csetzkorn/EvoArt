using Svg;
using System.Drawing.Imaging;

namespace SvgToJpeg
{
    class Program
    {
        static void Main()
        {
            const string inputPath = "D:\\fractal.svg";
            const string exportPath = "d:\\fractal.jpeg";
            var sampleDoc = SvgDocument.Open(inputPath);
            sampleDoc.Draw().Save(exportPath, ImageFormat.Jpeg);
        }
    }
}
