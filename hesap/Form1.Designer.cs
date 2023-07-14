namespace hesap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 42);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "SAYİ1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(178, 123);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 79);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "SAYİ2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 219);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "FARK:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 187);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 5;
            label4.Text = "TOPLAM:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 274);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "BÖLÜM:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 246);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 7;
            label6.Text = "ÇARPİM:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(219, 186);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 9;
            label7.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(219, 216);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 10;
            label8.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(224, 249);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 11;
            label9.Text = "00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(222, 272);
            label10.Name = "label10";
            label10.Size = new Size(19, 15);
            label10.TabIndex = 12;
            label10.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}