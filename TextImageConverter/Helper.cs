using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TextImageConverter
{
    public static class Helper
    {
        public static byte[] ToByteArrayUTF8(this string input)
        {
            return System.Text.Encoding.UTF8.GetBytes(input);
        }

        public static List<Color> ToColors(this byte[] input)
        {
            List<byte> bytes = new List<byte>();
            foreach (byte b in input)
            {
                bytes.Add(b);
            }

            List<Color> colors = new List<Color>();
            while(bytes.Count % 3 != 0)
            {
                bytes.Add(0);
            }

            for(int i = 0; i < bytes.Count; i +=3)
            {
                Color c = Color.FromArgb(bytes[i],bytes[i+1],bytes[i+2]);
                
                colors.Add(c);
            }
            return colors;
        }

        public static Bitmap ToBitmap (this List<Color> input)
        {
            //Determine Dimensions
            int wh = (int)Math.Ceiling(Math.Sqrt(input.Count));

            Bitmap bmp = new Bitmap(wh,wh);
            for (int i = 0; i < wh; i++)
            {
                for(int j = 0; j < wh; j++)
                {
                    if(input.Count != 0)
                    {
                        bmp.SetPixel(i, j, input[0]);
                        input.Remove(input[0]);
                    }
                    else
                    {
                        
                    }
                }
            }
            return bmp;
        }
        public static List<Color> ToColors(this Bitmap bmp)
        {
            List<Color> colors = new List<Color>();

            for(int i = 0; i<bmp.Width; i++)
            {
                for(int j = 0; j<bmp.Height;j++)
                {
                    colors.Add(bmp.GetPixel(i, j));
                }
            }
            return colors;
        }

        public static byte[] ToByteArray(this List<Color> colors)
        {
            List<byte> bytes = new List<byte>();
            for(int i = 0; i < colors.Count; i++)
            {
                bytes.Add(colors[i].R);
                bytes.Add(colors[i].G);
                bytes.Add(colors[i].B);
            }
            
            return bytes.ToArray();
        }
        public static string ToStringUTF8(this byte[] bytes)
        {
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}
