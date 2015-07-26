using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Lab_12_variant_2
{
    public class ManyColorsRectangle : IRectangle
    {
        private static Color? colorA;
        private static Color? colorB;
        private static Color? colorC;
        private static Color? colorD;
        private static PointF? pointA;
        private static PointF? pointB;
        private static PointF? pointC;
        private static PointF? pointD;
        private static ManyColorsRectangle uniqueInsanse;

        private ManyColorsRectangle()
        {
            ChangeColorSides(ReCalculate());
        }

        //Instance Singleton
        public static ManyColorsRectangle Instance()
        {
            if (uniqueInsanse == null)
                uniqueInsanse = new ManyColorsRectangle();

            return uniqueInsanse;
        }

        public Color? ReCalculate()
        {
            OneColorRectangle iOneColorRectangle = OneColorRectangle.Instance();
            pointA = (iOneColorRectangle.GetDirectReference.X == null) || (iOneColorRectangle.GetDirectReference.Y == null) ?
                new PointF?() :
                new PointF?(new PointF((float)iOneColorRectangle.GetDirectReference.X, (float)iOneColorRectangle.GetDirectReference.Y));
            pointB = ((iOneColorRectangle.GetDirectReference.X + iOneColorRectangle.GetDirectReference.Width) == null) ||
                      (iOneColorRectangle.GetDirectReference.Y == null) ?
                new PointF?() :
                new PointF?(new PointF((float)(iOneColorRectangle.GetDirectReference.X + iOneColorRectangle.GetDirectReference.Width),
                                       (float)(iOneColorRectangle.GetDirectReference.Y)));
            pointC = ((iOneColorRectangle.GetDirectReference.X + iOneColorRectangle.GetDirectReference.Width) == null) ||
                                ((iOneColorRectangle.GetDirectReference.Y + iOneColorRectangle.GetDirectReference.Height) == null) ?
                new PointF?() :
                new PointF?(new PointF((float)(iOneColorRectangle.GetDirectReference.X + iOneColorRectangle.GetDirectReference.Width),
                                       (float)(iOneColorRectangle.GetDirectReference.Y + iOneColorRectangle.GetDirectReference.Height)));
            pointD = (iOneColorRectangle.GetDirectReference.X == null) ||
                    ((iOneColorRectangle.GetDirectReference.Y + iOneColorRectangle.GetDirectReference.Height) == null) ?
                new PointF?() :
                new PointF?(new PointF((float)iOneColorRectangle.GetDirectReference.X,
                                       (float)(iOneColorRectangle.GetDirectReference.Y + iOneColorRectangle.GetDirectReference.Height)));
            return iOneColorRectangle.GeneralColor;
        }

        public ManyColorsRectangle GetDirectReference
        {
            get
            {
                return this;
            }
        }

        internal void ChangeColorSides(Color? color)
        {
            colorA = color;
            colorB = color;
            colorC = color;
            colorD = color;
        }

        internal void ChangeColorSides(Color? color, string[] colors)
        {
            colorA = Color.FromName(colors[0]);
            colorB = Color.FromName(colors[1]);
            colorC = Color.FromName(colors[2]);
            colorD = Color.FromName(colors[3]);
        }

        internal Color ReturnOnlyOneColor
        {
            get
            {
                if ((colorA != null) && (colorB == null) && (colorC == null) && (colorD == null))
                    return (Color)colorA;
                else if ((colorA == null) && (colorB != null) && (colorC == null) && (colorD == null))
                    return (Color)colorB;
                else if ((colorA == null) && (colorB == null) && (colorC != null) && (colorD == null))
                    return (Color)colorC;
                else if ((colorA == null) && (colorB == null) && (colorC == null) && (colorD != null))
                    return (Color)colorD;
                else throw new ArgumentException();
            }
        }

        public void PaintRectangle(Graphics G)
        {
            if ((pointA != null) && (pointB != null) && (pointC != null) && (pointD != null) &&
                (colorA != null) && (colorB != null) && (colorC != null) && (colorD != null))
            {
                G.Clear(Color.FromArgb(240, 240, 240));
                using (Pen penA = new Pen((Color)colorA))
                {
                    G.DrawLine(penA, (PointF)pointA, (PointF)pointB);
                }
                using (Pen penB = new Pen((Color)colorB))
                {
                    G.DrawLine(penB, (PointF)pointB, (PointF)pointC);
                }
                using (Pen penC = new Pen((Color)colorC))
                {
                    G.DrawLine(penC, (PointF)pointC, (PointF)pointD);
                }
                using (Pen penD = new Pen((Color)colorD))
                {
                    G.DrawLine(penD, (PointF)pointD, (PointF)pointA);
                }
            }
        }

        public Color ColorA
        {
            get
            {
                return (Color)colorA;
            }
            set
            {
                colorA = value;
            }
        }
        public Color ColorB
        {
            get
            {
                return (Color)colorB;
            }
            set
            {
                colorB = value;
            }
        }
        public Color ColorC
        {
            get
            {
                return (Color)colorC;
            }
            set
            {
                colorC = value;
            }
        }
        public Color ColorD
        {
            get
            {
                return (Color)colorD;
            }
            set
            {
                colorD = value;
            }
        }
    }
}
