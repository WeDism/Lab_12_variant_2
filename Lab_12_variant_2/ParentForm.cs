using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Lab_12_variant_2.Rectangle;

namespace Lab_12_variant_2
{
    public class ParentForm : Form
    {
        internal static Graphics G;
        internal static Graphics GraphicsSaveFile;
        internal static General GeneralForm;
        internal static bool? RectangleOneColorOrMany;
        internal static ManyColorsRectangle iManyColorsRectangle;
        internal static OneColorRectangle iOneColorRectangle;
        internal IRectangle iORectangle;
        internal IRectangle iMRectangle;
        internal static bool defaultValues = true;

        internal void Redraw()
        {
            InvokePaint(GeneralForm, null);
        }

        //public ManyColorsRectangle ReturnManyColorsRectangle
        //{
        //    get
        //    {
        //        return iManyColorsRectangle;
        //    }
        //}

        //public OneColorRectangle ReturnManyColorsRectangle
        //{
        //    get
        //    {
        //        return iOneColorRectangle;
        //    }
        //}
    }
}
