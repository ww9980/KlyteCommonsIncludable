﻿using System;
using UnityEngine;

namespace Klyte.Commons.Utils
{
    public static class ColorExtensions
    {
        public static string ToRGBA(this Color32 color)
        {
            return color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2") + color.a.ToString("X2");
        }
        public static string ToRGB(this Color32 color)
        {
            return color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
        }
        public static Color32 FromRGBA(string rgba)
        {
            var value = Convert.ToInt64(rgba, 16);
            return new Color32((byte)((value & 0xFF000000) >> 24), (byte)((value & 0xFF0000) >> 16), (byte)((value & 0xFF00) >> 8), (byte)((value & 0xFF)));
        }
        public static Color32 FromRGB(string rgb)
        {
            var value = Convert.ToInt32(rgb, 16);
            return new Color32((byte)((value & 0xFF0000) >> 16), (byte)((value & 0xFF00) >> 8), (byte)((value & 0xFF)), 0xFF);
        }
    }
}