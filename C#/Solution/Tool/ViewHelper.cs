﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Xml.Linq;

namespace Tool
{
    public class ViewHelper
    {
        public static T FindVisualChild<T>(DependencyObject obj) where T : DependencyObject
        {
            if (obj is FrameworkElement)
            {
                (obj as FrameworkElement).ApplyTemplate();
            }
            if (obj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                    if (child != null && child is T)
                    {
                        return (T)child;
                    }
                    T childItem = FindVisualChild<T>(child);
                    if (childItem != null) return childItem;
                }
            }
            return null;
        }

        /// <summary>
        /// 通过给定的依赖对象，在控件树中向上查找指定类型的控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T FindVisualParent<T>(DependencyObject obj) where T : class
        {
            while (obj != null)
            {
                if (obj is T)
                    return obj as T;

                obj = VisualTreeHelper.GetParent(obj);
            }

            return null;
        }

        /// <summary>
        /// 在给定的空间中，查找给定坐标点的给定类型的控件
        /// </summary>
        public static T HitTestView<T>(Visual visual, Point pos) where T : class
        {
            HitTestResult result = VisualTreeHelper.HitTest(visual, pos);
            if (result == null)
                return null;
            DependencyObject obj = result.VisualHit;

            return FindVisualParent<T>(obj);
        }
    }
}
