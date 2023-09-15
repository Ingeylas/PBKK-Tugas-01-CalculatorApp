namespace CalculatorApp
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
            this.textBoxDisplayResult = new System.Windows.Forms.TextBox();
            this.num7 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.Button14 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dividedBy = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.labelCurrentOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDisplayResult
            // 
            this.textBoxDisplayResult.BackColor = System.Drawing.Color.Snow;
            this.textBoxDisplayResult.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplayResult.Location = new System.Drawing.Point(12, 9);
            this.textBoxDisplayResult.Multiline = true;
            this.textBoxDisplayResult.Name = "textBoxDisplayResult";
            this.textBoxDisplayResult.Size = new System.Drawing.Size(409, 117);
            this.textBoxDisplayResult.TabIndex = 1;
            this.textBoxDisplayResult.Text = "0";
            this.textBoxDisplayResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDisplayResult.TextChanged += new System.EventHandler(this.textBoxDisplayResult_TextChanged);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.RosyBrown;
            this.num7.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.Color.OldLace;
            this.num7.Location = new System.Drawing.Point(12, 141);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(74, 69);
            this.num7.TabIndex = 2;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.button_click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.RosyBrown;
            this.num4.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.Color.OldLace;
            this.num4.Location = new System.Drawing.Point(12, 216);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(74, 69);
            this.num4.TabIndex = 3;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.button_click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.RosyBrown;
            this.num1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.Color.OldLace;
            this.num1.Location = new System.Drawing.Point(12, 291);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(74, 69);
            this.num1.TabIndex = 4;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.button_click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.RosyBrown;
            this.num0.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.Color.OldLace;
            this.num0.Location = new System.Drawing.Point(12, 366);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(154, 69);
            this.num0.TabIndex = 5;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.button_click);
            // 
            // Button14
            // 
            this.Button14.BackColor = System.Drawing.Color.Snow;
            this.Button14.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button14.ForeColor = System.Drawing.Color.RosyBrown;
            this.Button14.Location = new System.Drawing.Point(347, 216);
            this.Button14.Name = "Button14";
            this.Button14.Size = new System.Drawing.Size(74, 69);
            this.Button14.TabIndex = 15;
            this.Button14.Text = "CE";
            this.Button14.UseVisualStyleBackColor = false;
            this.Button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Snow;
            this.delete.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.RosyBrown;
            this.delete.Location = new System.Drawing.Point(347, 141);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(74, 69);
            this.delete.TabIndex = 16;
            this.delete.Text = "DEL";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Snow;
            this.button17.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.RosyBrown;
            this.button17.Location = new System.Drawing.Point(347, 366);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(74, 69);
            this.button17.TabIndex = 18;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Snow;
            this.Clear.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.RosyBrown;
            this.Clear.Location = new System.Drawing.Point(347, 291);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(74, 69);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.RosyBrown;
            this.num2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.Color.OldLace;
            this.num2.Location = new System.Drawing.Point(93, 291);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(74, 69);
            this.num2.TabIndex = 8;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.button_click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.RosyBrown;
            this.num5.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.Color.OldLace;
            this.num5.Location = new System.Drawing.Point(92, 216);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(74, 69);
            this.num5.TabIndex = 9;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.button_click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.RosyBrown;
            this.point.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.ForeColor = System.Drawing.Color.OldLace;
            this.point.Location = new System.Drawing.Point(172, 366);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(74, 69);
            this.point.TabIndex = 11;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.button_click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.RosyBrown;
            this.num3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.Color.OldLace;
            this.num3.Location = new System.Drawing.Point(172, 291);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(74, 69);
            this.num3.TabIndex = 12;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.button_click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.RosyBrown;
            this.num6.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.Color.OldLace;
            this.num6.Location = new System.Drawing.Point(172, 216);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(74, 69);
            this.num6.TabIndex = 13;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.button_click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Snow;
            this.button13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.RosyBrown;
            this.button13.Location = new System.Drawing.Point(267, 216);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(74, 69);
            this.button13.TabIndex = 14;
            this.button13.Text = "x";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.operator_click);
            // 
            // dividedBy
            // 
            this.dividedBy.BackColor = System.Drawing.Color.Snow;
            this.dividedBy.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedBy.ForeColor = System.Drawing.Color.RosyBrown;
            this.dividedBy.Location = new System.Drawing.Point(267, 142);
            this.dividedBy.Name = "dividedBy";
            this.dividedBy.Size = new System.Drawing.Size(74, 69);
            this.dividedBy.TabIndex = 17;
            this.dividedBy.Text = "/";
            this.dividedBy.UseVisualStyleBackColor = false;
            this.dividedBy.Click += new System.EventHandler(this.operator_click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Snow;
            this.plus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.Color.RosyBrown;
            this.plus.Location = new System.Drawing.Point(267, 366);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(74, 69);
            this.plus.TabIndex = 19;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.operator_click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Snow;
            this.minus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.Color.RosyBrown;
            this.minus.Location = new System.Drawing.Point(267, 291);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(74, 69);
            this.minus.TabIndex = 20;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.operator_click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.RosyBrown;
            this.num9.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.Color.OldLace;
            this.num9.Location = new System.Drawing.Point(172, 141);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(74, 69);
            this.num9.TabIndex = 6;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.button_click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.RosyBrown;
            this.num8.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.Color.OldLace;
            this.num8.Location = new System.Drawing.Point(92, 141);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(74, 69);
            this.num8.TabIndex = 10;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.button_click);
            // 
            // labelCurrentOp
            // 
            this.labelCurrentOp.AutoSize = true;
            this.labelCurrentOp.BackColor = System.Drawing.Color.RosyBrown;
            this.labelCurrentOp.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOp.Location = new System.Drawing.Point(14, 9);
            this.labelCurrentOp.Name = "labelCurrentOp";
            this.labelCurrentOp.Size = new System.Drawing.Size(0, 26);
            this.labelCurrentOp.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(432, 447);
            this.Controls.Add(this.labelCurrentOp);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.dividedBy);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.point);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.textBoxDisplayResult);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplayResult;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button Button14;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button dividedBy;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Label labelCurrentOp;
    }
}

