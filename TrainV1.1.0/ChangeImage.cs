using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TrainV1._1._0
{
    class ChangeImage
    {
        /// <summary>
        /// 改变图片透明度
        /// </summary>
        /// <param name="image">加载图片</param>
        /// <param name="pellucidity">设置透明度的值</param>
        /// <returns></returns>
        public Image ChangeAlpha(Image image,int pellucidity)
        {
            Bitmap img = new Bitmap(image);
            using (Bitmap bmp = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(img, 0, 0);
                    for (int h = 0; h <= img.Height - 1; h++)
                    {
                        for (int w = 0; w <= img.Width - 1; w++)
                        {
                            Color c = img.GetPixel(w, h);
                            bmp.SetPixel(w, h, Color.FromArgb(pellucidity, c.R, c.G, c.B));
                        }
                    }
                    return (Image)bmp.Clone();
                }
            }
        }

        
    }
}
