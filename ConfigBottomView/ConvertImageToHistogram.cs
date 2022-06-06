using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConfigBottomView
{
    /// <summary>
    ///  将读取的图像转换为直方图的类
    /// </summary>
    public static class ConvertImageToHistogram
    {
        /// <summary>
        /// 获取直方图的最大值并生成直方图的图像
        /// </summary>
        /// <param name="sourceImageItem">原图像</param>
        /// <returns>直方图图像，最大直方图值</returns>
        /// 
        public static (Bitmap, string) GenerateHistogramImage(Bitmap sourceImageItem)
        {
            Bitmap histogramImageItem = new Bitmap(256, 145);
            int brightness;
            List<int> histogram = new int[256].ToList();

            // 读取像素颜色信息、计算亮度信息并创建直方图值
            BitmapData bitmapData = sourceImageItem.LockBits(new Rectangle(0, 0, sourceImageItem.Width, sourceImageItem.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] pixelRGB = new byte[sourceImageItem.Width * sourceImageItem.Height * 4];
            Marshal.Copy(bitmapData.Scan0, pixelRGB, 0, pixelRGB.Length);
            for (int i = 0; i < pixelRGB.Length; i += 4)
            {
                //Gray = 0.299R + 0.587G + 0.144B
                brightness = Math.Min((int)Math.Round(0.299f * (float)pixelRGB[i + 2] + 0.587f * (float)pixelRGB[i + 1] + 0.114f * (float)pixelRGB[i]), 255);
                histogram[brightness]++;
            }
            Marshal.Copy(pixelRGB, 0, bitmapData.Scan0, pixelRGB.Length);
            sourceImageItem.UnlockBits(bitmapData);

            // 获取直方图的最大值
            int histogramMax = histogram.Max();
            // 获取直方图的最大值
            int histogramMin = histogram.Min();


            // 在 histogramImage 中显示直方图
            float smoothingPeak, smoothingPeakMax = 0.0f;
            Dictionary<int, int> histogramMaxValue = new Dictionary<int, int>();
            Point smoothingStartPoint = new Point(0, (int)Math.Round((float)histogram[0] / (float)histogramMax * 145.0f) - 1);
            Point smoothingEndPoint;
            Pen histogramPen = new Pen(Color.FromArgb(255,210,210,210), 1.0f);
            Pen smoothingHistogramPen = new Pen(Color.FromArgb(255, 210, 210, 210), 2.0f);
            Graphics histogramGraphics;
            Graphics smoothingHistogramGraphics;

            for (int i = 0; i < 256; i++)
            {
                histogramGraphics = Graphics.FromImage(histogramImageItem);
                histogramGraphics.DrawLine(histogramPen, new Point(i, (int)(((float)histogram[i] / (float)histogramMax) * 128.0f)), new Point(i, 0));
                histogramGraphics.Dispose();

                if (i > 0 && i < 255)
                {
                    smoothingPeak = (float)(histogram[i - 1] + 2.0f * histogram[i] + histogram[i + 1]) / 4.0f;
                    smoothingEndPoint = new Point(i, (int)Math.Round(smoothingPeak / (float)histogramMax * 128.0f) - 1);
                    if (smoothingStartPoint.Y != -1 || smoothingEndPoint.Y != -1)
                    {
                        smoothingHistogramGraphics = Graphics.FromImage(histogramImageItem);
                        smoothingHistogramGraphics.DrawLine(smoothingHistogramPen, smoothingStartPoint, smoothingEndPoint);
                        smoothingHistogramGraphics.Dispose();
                        if (smoothingPeakMax <= smoothingPeak)
                        {
                            histogramMaxValue.Add(i, (int)smoothingPeak);
                            smoothingPeakMax = smoothingPeak;
                        }
                    }
                    smoothingStartPoint = smoothingEndPoint;
                }
            }
            histogramPen.Dispose();

            // 计算并显示平滑直方图的最大值及其索引
            int histogramMaxIndex = histogramMaxValue.Max(item => item.Value);
            string peakHistogram = histogramMaxValue.HistogramMax(histogramMaxIndex); 
            //Extensions.HistogramMax(histogramMaxValue, histogramMaxIndex);
            histogramImageItem.RotateFlip(RotateFlipType.RotateNoneFlipY);
            //Graphics histogramGraphicsText = Graphics.FromImage(histogramImageItem);
            //histogramGraphicsText.DrawString("Peak=" + peakHistogram, new Font("MS UI Gothic", 9, FontStyle.Regular), Brushes.Black, 20, 0);
            //histogramGraphicsText.DrawImage(histogramImageItem, 0, 0);
            return (histogramImageItem, peakHistogram);
        }


    }
}
