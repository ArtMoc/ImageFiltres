using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFiltres
{
    class Mirror : IFilter
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
                    buffer.SetPixel(w-j-1, i, pixel);
                }
            }
            return buffer;
        }

        public string GetName()
        {
            return "Отразить";
        }
    }

}
