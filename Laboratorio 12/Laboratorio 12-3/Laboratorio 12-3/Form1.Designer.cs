﻿namespace Laboratorio_12_3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 38);
            label1.Name = "label1";
            label1.Size = new Size(212, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingresa la longitud del lado A";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 83);
            label2.Name = "label2";
            label2.Size = new Size(211, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingresa la longitud del lado B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 132);
            label3.Name = "label3";
            label3.Size = new Size(258, 21);
            label3.TabIndex = 2;
            label3.Text = "Ingresa la longitud del lado C (base)";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(322, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(322, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(42, 187);
            button1.Name = "button1";
            button1.Size = new Size(111, 32);
            button1.TabIndex = 6;
            button1.Text = "Semiperimetro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(179, 187);
            button2.Name = "button2";
            button2.Size = new Size(111, 32);
            button2.TabIndex = 7;
            button2.Text = "Area";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(312, 187);
            button3.Name = "button3";
            button3.Size = new Size(111, 32);
            button3.TabIndex = 8;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(446, 187);
            button4.Name = "button4";
            button4.Size = new Size(111, 32);
            button4.TabIndex = 9;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 253);
            label4.Name = "label4";
            label4.Size = new Size(174, 21);
            label4.TabIndex = 10;
            label4.Text = "Calcular Semiperimetro";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 307);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 11;
            label5.Text = "Area del Triangulo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(322, 251);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(322, 309);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(137, 23);
            textBox5.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(602, 408);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
