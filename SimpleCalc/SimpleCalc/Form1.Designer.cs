namespace SimpleCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.opr = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstNumber";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(148, 57);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(209, 22);
            this.first.TabIndex = 1;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(148, 108);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(209, 22);
            this.second.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "SecondNumber";
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(148, 197);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(209, 22);
            this.res.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // opr
            // 
            this.opr.FormattingEnabled = true;
            this.opr.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.opr.Location = new System.Drawing.Point(148, 149);
            this.opr.Name = "opr";
            this.opr.Size = new System.Drawing.Size(209, 24);
            this.opr.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "operator";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(65, 257);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(292, 53);
            this.calc.TabIndex = 8;
            this.calc.Text = "calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.opr);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.second);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox opr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calc;
    }
}

