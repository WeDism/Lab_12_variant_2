using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_12_variant_2
{
    public partial class Size : ParentForm
    {
        bool isColor;
        decimal buf_x;
        decimal buf_y;
        public Size()
        {
            InitializeComponent();
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
            numericUpDownHeigth.Value = iOneColorRectangle.Height == null ? 0 : (decimal)iOneColorRectangle.Height;
            numericUpDownWidth.Value = iOneColorRectangle.Width == null ? 0 : (decimal)iOneColorRectangle.Width;
            numericUpDownX.Value = iOneColorRectangle.X == null ? 0 : (decimal)iOneColorRectangle.X;
            numericUpDownY.Value = iOneColorRectangle.Y == null ? 0 : (decimal)iOneColorRectangle.Y - 33m;
            if (iOneColorRectangle.GeneralColor == Color.Red) radioButtonRed.Checked = true;
            else if (iOneColorRectangle.GeneralColor == Color.Green) radioButtonGreen.Checked = true;
            else if (iOneColorRectangle.GeneralColor == Color.Blue) radioButtonBlue.Checked = true;
            else if ((iOneColorRectangle.GeneralColor == Color.Black) && (!defaultValues)) radioButtonBlack.Checked = true;
            else if (defaultValues)
            {
                checkBoxTest.Checked = true;
                checkBoxTest_Click(null, null);
            }
            else checkBoxClean.Checked = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            isColor = true;
            bool isLogic = true;
            if (radioButtonRed.Checked)
            {
                iOneColorRectangle.GeneralColor = Color.Red;
                isLogic = false;
            }
            else if (radioButtonGreen.Checked)
            {
                iOneColorRectangle.GeneralColor = Color.Green;
                isLogic = false;
            }
            else if (radioButtonBlue.Checked)
            {
                iOneColorRectangle.GeneralColor = Color.Blue;
                isLogic = false;
            }
            else if (radioButtonBlack.Checked)
            {
                iOneColorRectangle.GeneralColor = Color.Black;
                isLogic = false;
            }
            if ((checkBoxClean.Checked) || (numericUpDownWidth.Value == 0m) ||
                (numericUpDownHeigth.Value == 0m) || (isLogic))
            {
                iOneColorRectangle.GeneralColor = null;
                isColor = false;
            }
            if (isColor)
            {
                iOneColorRectangle.Width = (float)numericUpDownWidth.Value;
                iOneColorRectangle.Height = (float)numericUpDownHeigth.Value;
                iOneColorRectangle.X = (float)numericUpDownX.Value;
                iOneColorRectangle.Y = (float)(numericUpDownY.Value + 33m);
                RectangleOneColorOrMany = true;
                iManyColorsRectangle = new ManyColorsRectangle();
                //GeneralForm.General_Paint(this, null);
                this.Close();
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("You are not input correct data", "Caution!", button);
            }
        }

        private void checkBoxClean_Click(object sender, EventArgs e)
        {
            if ((!checkBoxTest.Checked) && (!radioButtonRed.Checked) && (!radioButtonGreen.Checked) &&
                (!radioButtonBlue.Checked) && (!radioButtonBlack.Checked) &&
                (numericUpDownWidth.Value == 0m) && (numericUpDownHeigth.Value == 0m) &&
                (numericUpDownX.Value == 0m) && (numericUpDownY.Value == 0m))
                checkBoxClean.Checked = true;
            else
            {
                checkBoxTest.Checked = false;
                radioButtonRed.Checked = false;
                radioButtonGreen.Checked = false;
                radioButtonBlue.Checked = false;
                radioButtonBlack.Checked = false;
                numericUpDownWidth.Value = 0m;
                numericUpDownHeigth.Value = 0m;
                numericUpDownX.Value = 0m;
                numericUpDownY.Value = 0m;
            }
            //if (generalColor == Color.Red)
            //    radioButtonRed.Checked = true;
            //else if (generalColor == Color.Green)
            //    radioButtonGreen.Checked = true;
            //else if (generalColor == Color.Blue)
            //    radioButtonBlue.Checked = true;
            //else if (generalColor == Color.Black)
            //    radioButtonBlack.Checked = true;
            //else throw new ArgumentException();
        }

        private void radioButtonRed_Click(object sender, EventArgs e)
        {
            checkBoxClean.Checked = false;
            checkBoxTest.Checked = false;
        }

        private void radioButtonGreen_Click(object sender, EventArgs e)
        {
            checkBoxClean.Checked = false;
            checkBoxTest.Checked = false;
        }

        private void radioButtonBlue_Click(object sender, EventArgs e)
        {
            checkBoxClean.Checked = false;
            checkBoxTest.Checked = false;
        }

        private void radioButtonBlack_Click(object sender, EventArgs e)
        {
            checkBoxClean.Checked = false;
            checkBoxTest.Checked = false;
        }

        private void checkBoxDefault_Click(object sender, EventArgs e)
        {
            checkBoxTest.Checked = false;
            checkBoxClean.Checked = false;
            if ((numericUpDownX.Enabled) && (numericUpDownY.Enabled))
            {
                numericUpDownX.Enabled = false;
                numericUpDownY.Enabled = false;
                buf_x = numericUpDownX.Value;
                buf_y = buf_y == 0m ? numericUpDownY.Value : numericUpDownY.Value - 33m;
                numericUpDownX.Value = 0m;
                numericUpDownY.Value = 0m;
            }
            else
            {
                numericUpDownX.Value = buf_x;
                numericUpDownY.Value = buf_y;
                numericUpDownX.Enabled = true;
                numericUpDownY.Enabled = true;
            }
        }

        private void numericUpDownWidth_Click(object sender, EventArgs e)
        {
            checkBoxClean.Checked = false;
            checkBoxTest.Checked = false;
        }

        private void numericUpDownHeigth_Click(object sender, EventArgs e)
        {
            checkBoxClean.Checked = false;
            checkBoxTest.Checked = false;
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            checkBoxClean.Checked = false;
            checkBoxTest.Checked = false;
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            checkBoxClean.Checked = false;
            checkBoxTest.Checked = false;
        }

        private void numericUpDownX_Click(object sender, EventArgs e)
        {
            checkBoxClean.Checked = false;
            checkBoxTest.Checked = false;
        }

        private void numericUpDownY_Click(object sender, EventArgs e)
        {
            checkBoxClean.Checked = false;
            checkBoxTest.Checked = false;
        }

        private void checkBoxTest_Click(object sender, EventArgs e)
        {
            if (checkBoxTest.Checked)
            {
                defaultValues = true;
                checkBoxClean.Checked = false;
                radioButtonRed.Checked = false;
                radioButtonGreen.Checked = false;
                radioButtonBlue.Checked = false;
                radioButtonBlack.Checked = true;
                groupBoxInputSidesRectangle.Enabled = false;
                groupBoxCleanAll.Enabled = false;
                groupBoxChangeColors.Enabled = false;
                groupBoxInputX_and_Y_Coordinates.Enabled = false;
                numericUpDownWidth.Value = 200m;
                numericUpDownX.Value = 100m;
                numericUpDownHeigth.Value = 200m;
                numericUpDownY.Value = 100m;
            }
            else
            {
                defaultValues = false;
                groupBoxInputSidesRectangle.Enabled = true;
                groupBoxCleanAll.Enabled = true;
                groupBoxChangeColors.Enabled = true;
                groupBoxInputX_and_Y_Coordinates.Enabled = true;
            }
        }

    }
}
