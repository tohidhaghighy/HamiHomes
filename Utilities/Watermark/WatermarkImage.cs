using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace Utilities.Watermark
{
    public class WatermarkImage
    {


        //public Boolean ReturnImageResized(HttpPostedFileBase postedFile, string uploadpath, string watermarkpath, string filename)
        //{
        //    if (postedFile != null)
        //    {
        //        //Get the file name.
        //        string fileName = Path.GetFileNameWithoutExtension(postedFile.FileName) + ".png";

        //        //Read the File into a Bitmap.
        //        using (Bitmap bmp = new Bitmap(postedFile.InputStream, false))
        //        {
        //            using (Graphics grp = Graphics.FromImage(bmp))
        //            {
        //                Image imgPhoto = Image.FromFile(watermarkpath);
        //                Image imgPhotoresized;
        //                if (bmp.Width <= bmp.Height)
        //                {
        //                    imgPhotoresized = ResizeImage(imgPhoto, bmp.Width / 2, bmp.Height / 10);
        //                }
        //                else
        //                {
        //                    imgPhotoresized = ResizeImage(imgPhoto, bmp.Width / 2, bmp.Height / 6);
        //                }

        //                Point position = new Point(0, bmp.Height - imgPhotoresized.Height);
        //                grp.DrawImage(imgPhotoresized, position);
        //                bmp.Save(uploadpath + filename);
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        //public static Bitmap ResizeImageWithstrech(Image image, int width, int height)
        //{
        //    var destRect = new Rectangle(0, 0, width, height);
        //    var destImage = new Bitmap(width, height);

        //    destImage.SetResolution(100, 100);

        //    using (var graphics = Graphics.FromImage(destImage))
        //    {
        //        graphics.CompositingMode = CompositingMode.SourceCopy;
        //        graphics.CompositingQuality = CompositingQuality.HighQuality;
        //        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        graphics.SmoothingMode = SmoothingMode.HighQuality;
        //        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        //        using (var wrapMode = new ImageAttributes())
        //        {
        //            wrapMode.SetWrapMode(WrapMode.TileFlipXY);
        //            graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
        //        }
        //    }

        //    return destImage;
        //}

        //private static Image ResizeImage(Image imgToResize, int width, int height)
        //{
        //    int sourceWidth = imgToResize.Width;
        //    int sourceHeight = imgToResize.Height;

        //    float nPercent = 0;
        //    float nPercentW = 0;
        //    float nPercentH = 0;

        //    nPercentW = ((float)width / (float)sourceWidth);
        //    nPercentH = ((float)height / (float)sourceHeight);

        //    if (nPercentH < nPercentW)
        //        nPercent = nPercentH;
        //    else
        //        nPercent = nPercentW;

        //    int destWidth = (int)(sourceWidth * nPercent);
        //    int destHeight = (int)(sourceHeight * nPercent);

        //    Bitmap b = new Bitmap(destWidth, destHeight);
        //    Graphics g = Graphics.FromImage((Image)b);
        //    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

        //    g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
        //    g.Dispose();

        //    return (Image)b;
        //}


    }
}
