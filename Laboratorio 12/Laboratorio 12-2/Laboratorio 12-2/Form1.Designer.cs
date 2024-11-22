namespace Laboratorio_12_2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 66);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 0;
            label1.Text = "NOTAS PROMEDIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 66);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 1;
            label2.Text = "📒";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(293, 66);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 2;
            label3.Text = "📒";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 130);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 3;
            label4.Text = "NOTA No. 1";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 172);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 4;
            label5.Text = "NOTA No. 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(65, 208);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 5;
            label6.Text = "NOTA No. 3";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(256, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(111, 23);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(65, 271);
            button1.Name = "button1";
            button1.Size = new Size(86, 30);
            button1.TabIndex = 9;
            button1.Text = "Promedio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(175, 271);
            button2.Name = "button2";
            button2.Size = new Size(86, 30);
            button2.TabIndex = 10;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(281, 271);
            button3.Name = "button3";
            button3.Size = new Size(86, 30);
            button3.TabIndex = 11;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(65, 341);
            label7.Name = "label7";
            label7.Size = new Size(122, 21);
            label7.TabIndex = 12;
            label7.Text = "Nota Promedio";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(273, 343);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(94, 23);
            textBox4.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(422, 458);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calcular Promedio";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox textBox4;
    }
}
