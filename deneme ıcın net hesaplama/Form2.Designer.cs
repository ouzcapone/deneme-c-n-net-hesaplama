﻿namespace deneme_ıcın_net_hesaplama
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblDakika = new Label();
            label3 = new Label();
            lblSaniye = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 23);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Dakika:";
            // 
            // lblDakika
            // 
            lblDakika.AutoSize = true;
            lblDakika.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblDakika.Location = new Point(87, 80);
            lblDakika.Name = "lblDakika";
            lblDakika.Size = new Size(68, 65);
            lblDakika.TabIndex = 1;
            lblDakika.Text = "__";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(174, 80);
            label3.Name = "label3";
            label3.Size = new Size(38, 65);
            label3.TabIndex = 2;
            label3.Text = ":";
            // 
            // lblSaniye
            // 
            lblSaniye.AutoSize = true;
            lblSaniye.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaniye.Location = new Point(246, 80);
            lblSaniye.Name = "lblSaniye";
            lblSaniye.Size = new Size(68, 65);
            lblSaniye.TabIndex = 3;
            lblSaniye.Text = "__";
            lblSaniye.Click += lblSaniye_Click;
            // 
            // button1
            // 
            button1.Location = new Point(306, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "BAŞLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(44, 221);
            button2.Name = "button2";
            button2.Size = new Size(99, 78);
            button2.TabIndex = 7;
            button2.Text = "SAYISAL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(295, 221);
            button3.Name = "button3";
            button3.Size = new Size(99, 78);
            button3.TabIndex = 8;
            button3.Text = "SÖZEL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 362);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(lblSaniye);
            Controls.Add(label3);
            Controls.Add(lblDakika);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDakika;
        private Label label3;
        private Label lblSaniye;
        private Button button1;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Button button3;
    }
}