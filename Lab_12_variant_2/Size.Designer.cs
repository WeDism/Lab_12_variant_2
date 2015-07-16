namespace Lab_12_variant_2
{
    partial class Size
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSidesWidth = new System.Windows.Forms.Label();
            this.labelSidesHeigth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeigth = new System.Windows.Forms.NumericUpDown();
            this.groupBoxInputSidesRectangle = new System.Windows.Forms.GroupBox();
            this.groupBoxChangeColors = new System.Windows.Forms.GroupBox();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxCleanAll = new System.Windows.Forms.GroupBox();
            this.checkBoxClean = new System.Windows.Forms.CheckBox();
            this.groupBoxInputX_and_Y_Coordinates = new System.Windows.Forms.GroupBox();
            this.checkBoxDefault = new System.Windows.Forms.CheckBox();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.labelX = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelY = new System.Windows.Forms.Label();
            this.groupBoxTestValues = new System.Windows.Forms.GroupBox();
            this.checkBoxTest = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeigth)).BeginInit();
            this.groupBoxInputSidesRectangle.SuspendLayout();
            this.groupBoxChangeColors.SuspendLayout();
            this.groupBoxCleanAll.SuspendLayout();
            this.groupBoxInputX_and_Y_Coordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.groupBoxTestValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSidesWidth
            // 
            this.labelSidesWidth.AutoSize = true;
            this.labelSidesWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSidesWidth.Location = new System.Drawing.Point(6, 25);
            this.labelSidesWidth.Name = "labelSidesWidth";
            this.labelSidesWidth.Size = new System.Drawing.Size(62, 20);
            this.labelSidesWidth.TabIndex = 0;
            this.labelSidesWidth.Text = "Width :";
            // 
            // labelSidesHeigth
            // 
            this.labelSidesHeigth.AutoSize = true;
            this.labelSidesHeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSidesHeigth.Location = new System.Drawing.Point(6, 60);
            this.labelSidesHeigth.Name = "labelSidesHeigth";
            this.labelSidesHeigth.Size = new System.Drawing.Size(68, 20);
            this.labelSidesHeigth.TabIndex = 1;
            this.labelSidesHeigth.Text = "Heigth :";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownWidth.Location = new System.Drawing.Point(83, 24);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(169, 24);
            this.numericUpDownWidth.TabIndex = 2;
            this.numericUpDownWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownWidth.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownWidth.Click += new System.EventHandler(this.numericUpDownWidth_Click);
            // 
            // numericUpDownHeigth
            // 
            this.numericUpDownHeigth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownHeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownHeigth.Location = new System.Drawing.Point(83, 59);
            this.numericUpDownHeigth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHeigth.Name = "numericUpDownHeigth";
            this.numericUpDownHeigth.Size = new System.Drawing.Size(169, 24);
            this.numericUpDownHeigth.TabIndex = 3;
            this.numericUpDownHeigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownHeigth.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownHeigth.Click += new System.EventHandler(this.numericUpDownHeigth_Click);
            // 
            // groupBoxInputSidesRectangle
            // 
            this.groupBoxInputSidesRectangle.Controls.Add(this.numericUpDownHeigth);
            this.groupBoxInputSidesRectangle.Controls.Add(this.labelSidesWidth);
            this.groupBoxInputSidesRectangle.Controls.Add(this.numericUpDownWidth);
            this.groupBoxInputSidesRectangle.Controls.Add(this.labelSidesHeigth);
            this.groupBoxInputSidesRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputSidesRectangle.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInputSidesRectangle.Name = "groupBoxInputSidesRectangle";
            this.groupBoxInputSidesRectangle.Size = new System.Drawing.Size(258, 103);
            this.groupBoxInputSidesRectangle.TabIndex = 4;
            this.groupBoxInputSidesRectangle.TabStop = false;
            this.groupBoxInputSidesRectangle.Text = "Input sides rectangle";
            // 
            // groupBoxChangeColors
            // 
            this.groupBoxChangeColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChangeColors.Controls.Add(this.radioButtonBlack);
            this.groupBoxChangeColors.Controls.Add(this.radioButtonBlue);
            this.groupBoxChangeColors.Controls.Add(this.radioButtonGreen);
            this.groupBoxChangeColors.Controls.Add(this.radioButtonRed);
            this.groupBoxChangeColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxChangeColors.Location = new System.Drawing.Point(140, 225);
            this.groupBoxChangeColors.Name = "groupBoxChangeColors";
            this.groupBoxChangeColors.Size = new System.Drawing.Size(130, 148);
            this.groupBoxChangeColors.TabIndex = 5;
            this.groupBoxChangeColors.TabStop = false;
            this.groupBoxChangeColors.Text = "Change colors";
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBlack.Location = new System.Drawing.Point(6, 113);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(72, 24);
            this.radioButtonBlack.TabIndex = 3;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            this.radioButtonBlack.Click += new System.EventHandler(this.radioButtonBlack_Click);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBlue.Location = new System.Drawing.Point(6, 83);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(64, 24);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.Click += new System.EventHandler(this.radioButtonBlue_Click);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGreen.Location = new System.Drawing.Point(6, 53);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(76, 24);
            this.radioButtonGreen.TabIndex = 1;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.Click += new System.EventHandler(this.radioButtonGreen_Click);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonRed.Location = new System.Drawing.Point(6, 23);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(60, 24);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.Click += new System.EventHandler(this.radioButtonRed_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(12, 380);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 38);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(190, 380);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 38);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxCleanAll
            // 
            this.groupBoxCleanAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCleanAll.Controls.Add(this.checkBoxClean);
            this.groupBoxCleanAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCleanAll.Location = new System.Drawing.Point(12, 225);
            this.groupBoxCleanAll.Name = "groupBoxCleanAll";
            this.groupBoxCleanAll.Size = new System.Drawing.Size(122, 59);
            this.groupBoxCleanAll.TabIndex = 9;
            this.groupBoxCleanAll.TabStop = false;
            this.groupBoxCleanAll.Text = "Clean all";
            // 
            // checkBoxClean
            // 
            this.checkBoxClean.AutoSize = true;
            this.checkBoxClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxClean.Location = new System.Drawing.Point(10, 23);
            this.checkBoxClean.Name = "checkBoxClean";
            this.checkBoxClean.Size = new System.Drawing.Size(74, 24);
            this.checkBoxClean.TabIndex = 9;
            this.checkBoxClean.Text = "Clean";
            this.checkBoxClean.UseVisualStyleBackColor = true;
            this.checkBoxClean.Click += new System.EventHandler(this.checkBoxClean_Click);
            // 
            // groupBoxInputX_and_Y_Coordinates
            // 
            this.groupBoxInputX_and_Y_Coordinates.Controls.Add(this.checkBoxDefault);
            this.groupBoxInputX_and_Y_Coordinates.Controls.Add(this.numericUpDownY);
            this.groupBoxInputX_and_Y_Coordinates.Controls.Add(this.labelX);
            this.groupBoxInputX_and_Y_Coordinates.Controls.Add(this.numericUpDownX);
            this.groupBoxInputX_and_Y_Coordinates.Controls.Add(this.labelY);
            this.groupBoxInputX_and_Y_Coordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputX_and_Y_Coordinates.Location = new System.Drawing.Point(12, 121);
            this.groupBoxInputX_and_Y_Coordinates.Name = "groupBoxInputX_and_Y_Coordinates";
            this.groupBoxInputX_and_Y_Coordinates.Size = new System.Drawing.Size(258, 103);
            this.groupBoxInputX_and_Y_Coordinates.TabIndex = 5;
            this.groupBoxInputX_and_Y_Coordinates.TabStop = false;
            this.groupBoxInputX_and_Y_Coordinates.Text = "Input X and Y coordinates";
            // 
            // checkBoxDefault
            // 
            this.checkBoxDefault.AutoSize = true;
            this.checkBoxDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDefault.Location = new System.Drawing.Point(10, 63);
            this.checkBoxDefault.Name = "checkBoxDefault";
            this.checkBoxDefault.Size = new System.Drawing.Size(177, 24);
            this.checkBoxDefault.TabIndex = 10;
            this.checkBoxDefault.Text = "Default coordinates";
            this.checkBoxDefault.UseVisualStyleBackColor = true;
            this.checkBoxDefault.Click += new System.EventHandler(this.checkBoxDefault_Click);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownY.Location = new System.Drawing.Point(172, 21);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(80, 24);
            this.numericUpDownY.TabIndex = 3;
            this.numericUpDownY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownY.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownY.Click += new System.EventHandler(this.numericUpDownY_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(6, 25);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(30, 20);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X :";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownX.Location = new System.Drawing.Point(42, 23);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(80, 24);
            this.numericUpDownX.TabIndex = 2;
            this.numericUpDownX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownX.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownX.Click += new System.EventHandler(this.numericUpDownX_Click);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(137, 25);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(29, 20);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y :";
            // 
            // groupBoxTestValues
            // 
            this.groupBoxTestValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTestValues.Controls.Add(this.checkBoxTest);
            this.groupBoxTestValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTestValues.Location = new System.Drawing.Point(12, 290);
            this.groupBoxTestValues.Name = "groupBoxTestValues";
            this.groupBoxTestValues.Size = new System.Drawing.Size(122, 59);
            this.groupBoxTestValues.TabIndex = 10;
            this.groupBoxTestValues.TabStop = false;
            this.groupBoxTestValues.Text = "Test Values";
            // 
            // checkBoxTest
            // 
            this.checkBoxTest.AutoSize = true;
            this.checkBoxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTest.Location = new System.Drawing.Point(10, 23);
            this.checkBoxTest.Name = "checkBoxTest";
            this.checkBoxTest.Size = new System.Drawing.Size(64, 24);
            this.checkBoxTest.TabIndex = 9;
            this.checkBoxTest.Text = "Test";
            this.checkBoxTest.UseVisualStyleBackColor = true;
            this.checkBoxTest.Click += new System.EventHandler(this.checkBoxTest_Click);
            // 
            // Size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 430);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxTestValues);
            this.Controls.Add(this.groupBoxInputX_and_Y_Coordinates);
            this.Controls.Add(this.groupBoxCleanAll);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxChangeColors);
            this.Controls.Add(this.groupBoxInputSidesRectangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Size";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Size";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeigth)).EndInit();
            this.groupBoxInputSidesRectangle.ResumeLayout(false);
            this.groupBoxInputSidesRectangle.PerformLayout();
            this.groupBoxChangeColors.ResumeLayout(false);
            this.groupBoxChangeColors.PerformLayout();
            this.groupBoxCleanAll.ResumeLayout(false);
            this.groupBoxCleanAll.PerformLayout();
            this.groupBoxInputX_and_Y_Coordinates.ResumeLayout(false);
            this.groupBoxInputX_and_Y_Coordinates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.groupBoxTestValues.ResumeLayout(false);
            this.groupBoxTestValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSidesWidth;
        private System.Windows.Forms.Label labelSidesHeigth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeigth;
        private System.Windows.Forms.GroupBox groupBoxInputSidesRectangle;
        private System.Windows.Forms.GroupBox groupBoxChangeColors;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxCleanAll;
        private System.Windows.Forms.CheckBox checkBoxClean;
        private System.Windows.Forms.GroupBox groupBoxInputX_and_Y_Coordinates;
        private System.Windows.Forms.CheckBox checkBoxDefault;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.GroupBox groupBoxTestValues;
        private System.Windows.Forms.CheckBox checkBoxTest;
    }
}