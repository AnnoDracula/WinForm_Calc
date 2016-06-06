namespace CalcWinForm
{
    partial class Calculator
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
            this.input = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.diff = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.summ = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(13, 38);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ReadOnly = true;
            this.input.Size = new System.Drawing.Size(174, 37);
            this.input.TabIndex = 0;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(13, 81);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(39, 37);
            this.delete.TabIndex = 1;
            this.delete.Text = "del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(58, 81);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(39, 37);
            this.zero.TabIndex = 2;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(103, 81);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(39, 37);
            this.div.TabIndex = 3;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(148, 81);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(39, 37);
            this.mult.TabIndex = 4;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(13, 124);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(39, 37);
            this.one.TabIndex = 5;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(58, 124);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(39, 37);
            this.two.TabIndex = 6;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(103, 124);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(39, 37);
            this.three.TabIndex = 7;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // diff
            // 
            this.diff.Location = new System.Drawing.Point(148, 124);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(39, 37);
            this.diff.TabIndex = 8;
            this.diff.Text = "-";
            this.diff.UseVisualStyleBackColor = true;
            this.diff.Click += new System.EventHandler(this.diff_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(13, 167);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(39, 37);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(58, 167);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(39, 37);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(103, 167);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(39, 37);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // summ
            // 
            this.summ.Location = new System.Drawing.Point(148, 167);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(39, 37);
            this.summ.TabIndex = 12;
            this.summ.Text = "+";
            this.summ.UseVisualStyleBackColor = true;
            this.summ.Click += new System.EventHandler(this.summ_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 210);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(39, 37);
            this.seven.TabIndex = 13;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(58, 210);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(39, 37);
            this.eight.TabIndex = 14;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(103, 210);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(39, 37);
            this.nine.TabIndex = 15;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(148, 210);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(39, 37);
            this.result.TabIndex = 16;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_result.Location = new System.Drawing.Point(13, 13);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(174, 23);
            this.textBox_result.TabIndex = 17;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 262);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.result);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.summ);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.diff);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.input);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button diff;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button summ;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

