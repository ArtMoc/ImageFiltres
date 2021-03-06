using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFiltres
{
    class WhiteAndGray : IFilter
    {
        public Bitmap Apply(Bitmap image)
        {
            int h = image.Height;
            int w = image.Width;
            Bitmap buffer = new Bitmap(w, h);
            for (int i = 0; i < h; i++) //по высоте (y)
            {
                for (int j = 0; j < w; j++) // по ширине (x)
                {
                    Color pixel = image.GetPixel(j, i);
                    buffer.SetPixel(j, i, Color.FromArgb(pixel.R, pixel.R, pixel.R));
                }
            }
            return buffer;
        }

        public string GetName()
        {
            return "Оттенки серого";
        }
    }
}
