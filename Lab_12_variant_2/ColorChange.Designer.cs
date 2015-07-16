namespace Lab_12_variant_2
{
    partial class ColorChange
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxUp = new System.Windows.Forms.ComboBox();
            this.checkBoxBlack = new System.Windows.Forms.CheckBox();
            this.comboBoxLeft = new System.Windows.Forms.ComboBox();
            this.comboBoxDown = new System.Windows.Forms.ComboBox();
            this.comboBoxRigth = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(301, 148);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 33);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(12, 148);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 33);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxUp);
            this.groupBox1.Controls.Add(this.checkBoxBlack);
            this.groupBox1.Controls.Add(this.comboBoxLeft);
            this.groupBox1.Controls.Add(this.comboBoxDown);
            this.groupBox1.Controls.Add(this.comboBoxRigth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set color sides";
            // 
            // comboBoxUp
            // 
            this.comboBoxUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUp.FormattingEnabled = true;
            this.comboBoxUp.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboBoxUp.Location = new System.Drawing.Point(135, 23);
            this.comboBoxUp.Name = "comboBoxUp";
            this.comboBoxUp.Size = new System.Drawing.Size(121, 28);
            this.comboBoxUp.TabIndex = 1;
            this.comboBoxUp.SelectedIndexChanged += new System.EventHandler(this.comboBoxUp_SelectedIndexChanged);
            this.comboBoxUp.Click += new System.EventHandler(this.comboBoxUp_Click);
            // 
            // checkBoxBlack
            // 
            this.checkBoxBlack.AutoSize = true;
            this.checkBoxBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBlack.Location = new System.Drawing.Point(146, 57);
            this.checkBoxBlack.Name = "checkBoxBlack";
            this.checkBoxBlack.Size = new System.Drawing.Size(100, 28);
            this.checkBoxBlack.TabIndex = 5;
            this.checkBoxBlack.Text = "Black all";
            this.checkBoxBlack.UseVisualStyleBackColor = true;
            this.checkBoxBlack.Click += new System.EventHandler(this.checkBoxBlack_Click);
            // 
            // comboBoxLeft
            // 
            this.comboBoxLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLeft.FormattingEnabled = true;
            this.comboBoxLeft.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboBoxLeft.Location = new System.Drawing.Point(19, 58);
            this.comboBoxLeft.Name = "comboBoxLeft";
            this.comboBoxLeft.Size = new System.Drawing.Size(121, 28);
            this.comboBoxLeft.TabIndex = 2;
            this.comboBoxLeft.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeft_SelectedIndexChanged);
            // 
            // comboBoxDown
            // 
            this.comboBoxDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDown.FormattingEnabled = true;
            this.comboBoxDown.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboBoxDown.Location = new System.Drawing.Point(135, 92);
            this.comboBoxDown.Name = "comboBoxDown";
            this.comboBoxDown.Size = new System.Drawing.Size(121, 28);
            this.comboBoxDown.TabIndex = 4;
            this.comboBoxDown.SelectedIndexChanged += new System.EventHandler(this.comboBoxDown_SelectedIndexChanged);
            // 
            // comboBoxRigth
            // 
            this.comboBoxRigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRigth.FormattingEnabled = true;
            this.comboBoxRigth.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboBoxRigth.Location = new System.Drawing.Point(252, 57);
            this.comboBoxRigth.Name = "comboBoxRigth";
            this.comboBoxRigth.Size = new System.Drawing.Size(121, 28);
            this.comboBoxRigth.TabIndex = 3;
            this.comboBoxRigth.SelectedIndexChanged += new System.EventHandler(this.comboBoxRigth_SelectedIndexChanged);
            // 
            // ColorChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 190);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorChange";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUp;
        private System.Windows.Forms.ComboBox comboBoxLeft;
        private System.Windows.Forms.ComboBox comboBoxRigth;
        private System.Windows.Forms.ComboBox comboBoxDown;
        private System.Windows.Forms.CheckBox checkBoxBlack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;

    }
}