using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Lab_12_variant_2
{
    class OneColorRectangle : IRectangle
    {
        internal static float? x;
        internal static float? y;
        internal static float? width;
        internal static float? height;
        internal static Color? generalColor;

        public float? X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public float? Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public float? Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public float? Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public Color? GeneralColor
        {
            get
            {
                return generalColor;
            }
            set
            {
                generalColor = value;
            }
        }

        public OneColorRectangle GetDirectReference
        {
            get
            {
                return this;
            }
        }
        
        public void PaintRectangle(Graphics G)
        {
            if ((width != null) && (height != null) && (generalColor != null) && (x != null) && (y != null))
            {
                G.Clear(Color.FromArgb(240, 240, 240));
                using (Pen pen = new Pen((Color)generalColor))
                {
                    G.DrawRectangle(pen, (float)x, (float)y, (float)width, (float)height);
                }
            }
        }
    }
}
