using System;
using System.Collections.Generic;
using System.Diagnostics;
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


        /// <summary>
        /// 获取直方图的最大值并生成直方图的图像
        /// </summary>
        /// <param name="sourceImageItem">原图像</param>
        /// <returns>直方图图像，最大直方图值</returns>
        /// 
        public static Bitmap GenerateHistogramImage(List<int> histogram)
        {

            Bitmap histogramImageItem = new Bitmap(300, 300);
            int brightness;

            int histogramMax = histogram.Max();
            int histogramMin = histogram.Min();

            // 在 histogramImage 中显示直方图


            Pen curPen = new Pen(Brushes.Black, 1);
            //获取Graphics对象
            Graphics g = Graphics.FromImage(histogramImageItem);
            //绘制坐标轴
            g.DrawLine(curPen, 50, 240, 320, 240);//在点(50,240)与(320,240)间画条线，x轴
            //g.DrawLine(curPen, 50, 240, 50, 30);//y轴

            //绘制并标识坐标刻度
            g.DrawLine(curPen, 100, 240, 100, 242);//同上，画长度为2的线
            g.DrawLine(curPen, 150, 240, 150, 242);
            g.DrawLine(curPen, 200, 240, 200, 242);
            g.DrawLine(curPen, 250, 240, 250, 242);
            g.DrawLine(curPen, 300, 240, 300, 242);

            //在x轴上为刻度标出刻度值
            //g.DrawString("0", new Font("New Timer", 8), Brushes.Black, new PointF(46, 242));
            //g.DrawString("50", new Font("New Timer", 8), Brushes.Black, new PointF(92, 242));
            //g.DrawString("100", new Font("New Timer", 8), Brushes.Black, new PointF(139, 242));
            //g.DrawString("150", new Font("New Timer", 8), Brushes.Black, new PointF(189, 242));
            //g.DrawString("200", new Font("New Timer", 8), Brushes.Black, new PointF(239, 242));
            //g.DrawString("250", new Font("New Timer", 8), Brushes.Black, new PointF(289, 242));

            //在y轴上为标刻度及刻度值
            g.DrawLine(curPen, 48, 40, 50, 40);
            //g.DrawString("0", new Font("New Timer", 8), Brushes.Black, new PointF(34, 234));
            g.DrawString(histogramMax.ToString(), new Font("New Timer", 8), Brushes.Black, new PointF(18, 34));

            //绘制直方图
            double temp = 0;
            for (int i = 0; i < 256; i++)
            {
                //纵坐标长度
                temp = 200.0 * histogram[i] / histogramMax;
                g.DrawLine(curPen, 50 + i, 240, 50 + i, 240 - (int)temp);
            }
            //释放对象
            curPen.Dispose();

            // 计算并显示平滑直方图的最大值及其索引
            //int histogramMaxIndex = histogramMaxValue.Max(item => item.Value);
            //string peakHistogram = histogramMaxValue.HistogramMax(histogramMaxIndex);
            //histogramImageItem.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return histogramImageItem;
        }


    }
}
