namespace Checkbox_Radiobutton_Baitap_
{
    partial class Form1
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
            this.txtShow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbColor = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdbtnBlue = new System.Windows.Forms.RadioButton();
            this.rdbtnRed = new System.Windows.Forms.RadioButton();
            this.gpbStyle = new System.Windows.Forms.GroupBox();
            this.chkboxUnderline = new System.Windows.Forms.CheckBox();
            this.chkboxItalic = new System.Windows.Forms.CheckBox();
            this.chkboxBold = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gpbColor.SuspendLayout();
            this.gpbStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtShow
            // 
            this.txtShow.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow.Location = new System.Drawing.Point(16, 49);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(495, 120);
            this.txtShow.TabIndex = 0;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập chữ bạn muốn chỉnh sửa:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.gpbColor);
            this.groupBox1.Controls.Add(this.gpbStyle);
            this.groupBox1.Location = new System.Drawing.Point(0, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // gpbColor
            // 
            this.gpbColor.Controls.Add(this.radioButton3);
            this.gpbColor.Controls.Add(this.rdbtnBlue);
            this.gpbColor.Controls.Add(this.rdbtnRed);
            this.gpbColor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbColor.Location = new System.Drawing.Point(313, 7);
            this.gpbColor.Name = "gpbColor";
            this.gpbColor.Size = new System.Drawing.Size(200, 142);
            this.gpbColor.TabIndex = 3;
            this.gpbColor.TabStop = false;
            this.gpbColor.Text = "Color";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 105);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(136, 26);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbtnBlue
            // 
            this.rdbtnBlue.AutoSize = true;
            this.rdbtnBlue.Location = new System.Drawing.Point(27, 73);
            this.rdbtnBlue.Name = "rdbtnBlue";
            this.rdbtnBlue.Size = new System.Drawing.Size(65, 26);
            this.rdbtnBlue.TabIndex = 1;
            this.rdbtnBlue.TabStop = true;
            this.rdbtnBlue.Text = "Blue";
            this.rdbtnBlue.UseVisualStyleBackColor = true;
            this.rdbtnBlue.CheckedChanged += new System.EventHandler(this.rdbtnBlue_CheckedChanged);
            // 
            // rdbtnRed
            // 
            this.rdbtnRed.AutoSize = true;
            this.rdbtnRed.Location = new System.Drawing.Point(27, 41);
            this.rdbtnRed.Name = "rdbtnRed";
            this.rdbtnRed.Size = new System.Drawing.Size(61, 26);
            this.rdbtnRed.TabIndex = 0;
            this.rdbtnRed.TabStop = true;
            this.rdbtnRed.Text = "Red";
            this.rdbtnRed.UseVisualStyleBackColor = true;
            this.rdbtnRed.CheckedChanged += new System.EventHandler(this.rdbtnRed_CheckedChanged);
            // 
            // gpbStyle
            // 
            this.gpbStyle.Controls.Add(this.chkboxUnderline);
            this.gpbStyle.Controls.Add(this.chkboxItalic);
            this.gpbStyle.Controls.Add(this.chkboxBold);
            this.gpbStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStyle.Location = new System.Drawing.Point(18, 7);
            this.gpbStyle.Name = "gpbStyle";
            this.gpbStyle.Size = new System.Drawing.Size(200, 142);
            this.gpbStyle.TabIndex = 4;
            this.gpbStyle.TabStop = false;
            this.gpbStyle.Text = "Style";
            // 
            // chkboxUnderline
            // 
            this.chkboxUnderline.AutoSize = true;
            this.chkboxUnderline.Location = new System.Drawing.Point(20, 105);
            this.chkboxUnderline.Name = "chkboxUnderline";
            this.chkboxUnderline.Size = new System.Drawing.Size(108, 26);
            this.chkboxUnderline.TabIndex = 2;
            this.chkboxUnderline.Text = "Underline";
            this.chkboxUnderline.UseVisualStyleBackColor = true;
            this.chkboxUnderline.CheckedChanged += new System.EventHandler(this.chkboxUnderline_CheckedChanged);
            // 
            // chkboxItalic
            // 
            this.chkboxItalic.AutoSize = true;
            this.chkboxItalic.Location = new System.Drawing.Point(20, 73);
            this.chkboxItalic.Name = "chkboxItalic";
            this.chkboxItalic.Size = new System.Drawing.Size(71, 26);
            this.chkboxItalic.TabIndex = 1;
            this.chkboxItalic.Text = "Italic";
            this.chkboxItalic.UseVisualStyleBackColor = true;
            this.chkboxItalic.CheckedChanged += new System.EventHandler(this.chkboxItalic_CheckedChanged);
            // 
            // chkboxBold
            // 
            this.chkboxBold.AutoSize = true;
            this.chkboxBold.Location = new System.Drawing.Point(20, 41);
            this.chkboxBold.Name = "chkboxBold";
            this.chkboxBold.Size = new System.Drawing.Size(67, 26);
            this.chkboxBold.TabIndex = 0;
            this.chkboxBold.Text = "Bold";
            this.chkboxBold.UseVisualStyleBackColor = true;
            this.chkboxBold.CheckedChanged += new System.EventHandler(this.chkboxBold_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(532, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.gpbColor.ResumeLayout(false);
            this.gpbColor.PerformLayout();
            this.gpbStyle.ResumeLayout(false);
            this.gpbStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbColor;
        private System.Windows.Forms.GroupBox gpbStyle;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdbtnBlue;
        private System.Windows.Forms.RadioButton rdbtnRed;
        private System.Windows.Forms.CheckBox chkboxUnderline;
        private System.Windows.Forms.CheckBox chkboxItalic;
        private System.Windows.Forms.CheckBox chkboxBold;
    }
}

