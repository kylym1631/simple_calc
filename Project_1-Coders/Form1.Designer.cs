
namespace Project_1_Coders
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
            this.add = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.exponent = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.add.FlatAppearance.BorderSize = 2;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.add.Location = new System.Drawing.Point(19, 39);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(74, 72);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.mainLabel.Location = new System.Drawing.Point(41, 20);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(582, 70);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Simple Calculator";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(19, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 53);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.number1.Location = new System.Drawing.Point(14, 38);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(126, 30);
            this.number1.TabIndex = 3;
            this.number1.Text = "Number 1";
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.number2.Location = new System.Drawing.Point(374, 38);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(126, 30);
            this.number2.TabIndex = 4;
            this.number2.Text = "Number 2";
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox2.Location = new System.Drawing.Point(379, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 53);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // subtract
            // 
            this.subtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtract.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.subtract.FlatAppearance.BorderSize = 2;
            this.subtract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.subtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.subtract.Location = new System.Drawing.Point(93, 117);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(74, 72);
            this.subtract.TabIndex = 6;
            this.subtract.Text = "-";
            this.subtract.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // multiply
            // 
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.multiply.FlatAppearance.BorderSize = 2;
            this.multiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.multiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.multiply.Location = new System.Drawing.Point(170, 39);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(74, 72);
            this.multiply.TabIndex = 7;
            this.multiply.Text = "x";
            this.multiply.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.divide.FlatAppearance.BorderSize = 2;
            this.divide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.divide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.divide.Location = new System.Drawing.Point(250, 117);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(74, 72);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // factorial
            // 
            this.factorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.factorial.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.factorial.FlatAppearance.BorderSize = 2;
            this.factorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.factorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.factorial.Location = new System.Drawing.Point(327, 39);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(74, 72);
            this.factorial.TabIndex = 9;
            this.factorial.Text = "!";
            this.factorial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // exponent
            // 
            this.exponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exponent.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.exponent.FlatAppearance.BorderSize = 2;
            this.exponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.exponent.Location = new System.Drawing.Point(406, 117);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(74, 72);
            this.exponent.TabIndex = 10;
            this.exponent.Text = "^";
            this.exponent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exponent.UseVisualStyleBackColor = true;
            this.exponent.Click += new System.EventHandler(this.exponent_Click);
            // 
            // percent
            // 
            this.percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percent.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.percent.FlatAppearance.BorderSize = 2;
            this.percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.percent.Location = new System.Drawing.Point(485, 39);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(74, 72);
            this.percent.TabIndex = 11;
            this.percent.Text = "%";
            this.percent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.result.Location = new System.Drawing.Point(0, 55);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(582, 143);
            this.result.TabIndex = 12;
            this.result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.result.Click += new System.EventHandler(this.label1_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit.FlatAppearance.BorderSize = 2;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.exit.Location = new System.Drawing.Point(41, 691);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(167, 59);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clear.FlatAppearance.BorderSize = 2;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.clear.Location = new System.Drawing.Point(434, 691);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(189, 59);
            this.clear.TabIndex = 14;
            this.clear.Text = "Clear";
            this.clear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.number2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.number1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 153);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numbers";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exponent);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Controls.Add(this.subtract);
            this.groupBox2.Controls.Add(this.multiply);
            this.groupBox2.Controls.Add(this.percent);
            this.groupBox2.Controls.Add(this.factorial);
            this.groupBox2.Controls.Add(this.divide);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(41, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 205);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // resText
            // 
            this.resText.AutoSize = true;
            this.resText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resText.Location = new System.Drawing.Point(221, 16);
            this.resText.Name = "resText";
            this.resText.Size = new System.Drawing.Size(116, 39);
            this.resText.TabIndex = 17;
            this.resText.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 775);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Programmed by \"Coders\"";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resText);
            this.groupBox3.Controls.Add(this.result);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(41, 484);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 201);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 825);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.mainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project1: Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label resText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

