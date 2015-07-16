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
    public partial class ColorChange : ParentForm
    {
        string buf_A;
        string buf_B;
        string buf_C;
        string buf_D;
        public ColorChange()
        {
            buf_A = iManyColorsRectangle.ColorA.Name;
            buf_B = iManyColorsRectangle.ColorB.Name;
            buf_C = iManyColorsRectangle.ColorC.Name;
            buf_D = iManyColorsRectangle.ColorD.Name;
            InitializeComponent();
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
            comboBoxUp.Text = buf_A != "Black" ? buf_A : "";
            comboBoxDown.Text = buf_C != "Black" ? buf_C : "";
            comboBoxRigth.Text = buf_B != "Black" ? buf_B : "";
            comboBoxLeft.Text = buf_D != "Black" ? buf_D : "";
            checkBoxBlack.Checked = buf_A.Equals("Black") || buf_B.Equals("Black") ||
                            buf_C.Equals("Black") || buf_D.Equals("Black") ?
                            true : false;
            comboBoxUp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDown.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRigth.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLeft.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void checkBoxBlack_Click(object sender, EventArgs e)
        {
            bool logic = true;
            if (buf_A.Equals("Black") || buf_B.Equals("Black") ||
                        buf_C.Equals("Black") || buf_D.Equals("Black"))
            {
                checkBoxBlack.Checked = true;
                logic = false;
                MessageBox.Show("Choose all sides");
            }
            if (logic)
            {
                if (checkBoxBlack.Checked)
                {
                    buf_A = "Black";
                    buf_B = "Black";
                    buf_C = "Black";
                    buf_D = "Black";
                    comboBoxUp.SelectedItem = null;
                    comboBoxDown.SelectedItem = null;
                    comboBoxRigth.SelectedItem = null;
                    comboBoxLeft.SelectedItem = null;
                    comboBoxUp.ResetText();
                    comboBoxDown.ResetText();
                    comboBoxRigth.ResetText();
                    comboBoxLeft.ResetText();
                    checkBoxBlack.Checked = true;
                }
                else
                {
                    comboBoxUp.Text = buf_A != "Black" ? buf_A : "";
                    comboBoxDown.Text = buf_C != "Black" ? buf_C : "";
                    comboBoxRigth.Text = buf_B != "Black" ? buf_B : "";
                    comboBoxLeft.Text = buf_D != "Black" ? buf_D : "";
                    checkBoxBlack.Checked = true;
                }
            }
        }

        private void comboBoxUp_Click(object sender, EventArgs e)
        {
            comboBoxUp.ValueMember = buf_A;
        }

        private void comboBoxUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buf_A = comboBoxUp.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                buf_A = "";
            }
            checkBoxBlack.Checked = false;
        }

        private void comboBoxDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buf_C = comboBoxDown.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                buf_C = "";
            }
            checkBoxBlack.Checked = false;
        }

        private void comboBoxRigth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buf_B = comboBoxRigth.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                buf_B = "";
            }
            checkBoxBlack.Checked = false;
        }

        private void comboBoxLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buf_D = comboBoxLeft.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                buf_D = "";
            }
            checkBoxBlack.Checked = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if ((Color.FromName(buf_A) != Color.Black) && (Color.FromName(buf_B) != Color.Black) &&
                (Color.FromName(buf_C) != Color.Black) && (Color.FromName(buf_D) != Color.Black) &&
                (buf_A != "") && (buf_B != "") && (buf_C != "") && (buf_D != ""))
            {
                iManyColorsRectangle.ColorA = Color.FromName(buf_A);
                iManyColorsRectangle.ColorB = Color.FromName(buf_B);
                iManyColorsRectangle.ColorC = Color.FromName(buf_C);
                iManyColorsRectangle.ColorD = Color.FromName(buf_D);
                RectangleOneColorOrMany = false;
                this.Close();
            }
            else MessageBox.Show("You are not change all sides");
        }

    }
}
