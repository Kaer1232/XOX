namespace XOX
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
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            SuspendLayout();
            // 
            // button10
            // 
            button10.Location = new Point(330, 98);
            button10.Name = "button10";
            button10.Size = new Size(80, 80);
            button10.TabIndex = 0;
            button10.Text = "button1";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Restart;
            // 
            // button11
            // 
            button11.Location = new Point(324, 69);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 1;
            button11.Text = "Заново";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Restart;
            // 
            // button12
            // 
            button12.Location = new Point(324, 155);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 1;
            button12.Text = "Выход";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 267);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 2;
            label1.Text = "Дроздов Евгений Евгениевич";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(67, 66);
            panel1.TabIndex = 5;
            panel1.Click += panel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(101, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(67, 66);
            panel2.TabIndex = 5;
            panel2.Click += panel_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(190, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(67, 66);
            panel3.TabIndex = 5;
            panel3.Click += panel_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(12, 84);
            panel4.Name = "panel4";
            panel4.Size = new Size(67, 66);
            panel4.TabIndex = 5;
            panel4.Click += panel_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonShadow;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(101, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(67, 66);
            panel5.TabIndex = 5;
            panel5.Click += panel_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonShadow;
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Location = new Point(190, 84);
            panel6.Name = "panel6";
            panel6.Size = new Size(67, 66);
            panel6.TabIndex = 5;
            panel6.Click += panel_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonShadow;
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(12, 156);
            panel7.Name = "panel7";
            panel7.Size = new Size(67, 66);
            panel7.TabIndex = 5;
            panel7.Click += panel_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonShadow;
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Location = new Point(101, 156);
            panel8.Name = "panel8";
            panel8.Size = new Size(67, 66);
            panel8.TabIndex = 5;
            panel8.Click += panel_Click;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonShadow;
            panel9.BackgroundImageLayout = ImageLayout.Zoom;
            panel9.Location = new Point(190, 156);
            panel9.Name = "panel9";
            panel9.Size = new Size(67, 66);
            panel9.TabIndex = 5;
            panel9.Click += panel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 291);
            Controls.Add(panel9);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button12);
            Controls.Add(button11);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button10;
        private Button button11;
        private Button button12;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
    }
}
