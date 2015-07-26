using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_12_variant_2
{
    public partial class General : ParentForm
    {
        Bitmap bitmap = new Bitmap(562, 358, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        public event FormClosingEventHandler EH;
        public General()
        {
            InitializeComponent();
            EH = new FormClosingEventHandler(General_FormClosing);
            this.FormClosing += EH;
            iOneColorRectangle = OneColorRectangle.Instance();
            GeneralForm = this;
            iORectangle = OneColorRectangle.Instance();
            iMRectangle = ManyColorsRectangle.Instance();
            G = this.CreateGraphics();
            GraphicsSaveFile = Graphics.FromImage(bitmap);
            MessageBox.Show("This is program create for\n\tmedium - 125%\n\tsystem text", "Warning!");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("\tPush: ok or cancel", "Exit", buttons);
            if (result == DialogResult.Yes)
            {
                this.FormClosing -= EH;
                Application.Exit();
            }
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Size().ShowDialog();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((iOneColorRectangle.X == null) || (iOneColorRectangle.Y == null) ||
                (iOneColorRectangle.Width == null) || (iOneColorRectangle.Height == null) || (iOneColorRectangle.GeneralColor == null))
                MessageBox.Show("You are not input data", "Warning!");
            else
                new ColorChange().ShowDialog();
        }

        private void General_Paint(object sender, PaintEventArgs e)
        {
            if (((iOneColorRectangle.Width + iOneColorRectangle.X) > 562f) ||
                ((iOneColorRectangle.Height + iOneColorRectangle.Y)) > 358f)
            {
                MessageBox.Show("You are input data is outside window print", "Error!");
            }
            else if (RectangleOneColorOrMany != null)
            {
                if ((bool)RectangleOneColorOrMany)
                {
                    iORectangle.PaintRectangle(G);
                    iORectangle.PaintRectangle(GraphicsSaveFile);
                }
                else
                {
                    iMRectangle.PaintRectangle(G);
                    iMRectangle.PaintRectangle(GraphicsSaveFile);
                }
            }
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralForm.Redraw();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RectangleOneColorOrMany != null)
            {
                G.Clear(Color.FromArgb(240, 240, 240));
                GraphicsSaveFile.Clear(Color.FromArgb(240, 240, 240));
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            Save.Filter = "bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
            Save.FilterIndex = 1;
            Save.RestoreDirectory = true;

            if (Save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bitmap.Save(Save.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    bitmap.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
            Open.FilterIndex = 1;
            Open.RestoreDirectory = true;

            if (Open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bitmap =(Bitmap)Image.FromFile(Open.FileName);
                    G.DrawImage(bitmap, 0, 0);
                    bitmap.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("This is program can't reading\n\t data from file", "Warning!");
                RectangleOneColorOrMany = true;
            }
        }

        private void General_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("\tPush: Ok or Cancel", "Exit", buttons);
            if (result == DialogResult.No) e.Cancel = true;
        }
    }
}
