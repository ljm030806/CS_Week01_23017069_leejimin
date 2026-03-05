namespace MyBusinessCard
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(433, 58);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 0;
            label1.Text = "이지민";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Chocolate;
            label2.Location = new Point(433, 110);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 1;
            label2.Text = "컴퓨터SW학과";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.FromArgb(192, 0, 192);
            label3.Location = new Point(433, 158);
            label3.Name = "label3";
            label3.Size = new Size(276, 32);
            label3.TabIndex = 2;
            label3.Text = "ljm030806@gmail.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(433, 209);
            label4.Name = "label4";
            label4.Size = new Size(188, 32);
            label4.TabIndex = 3;
            label4.Text = "010-4071-9766";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._20260305_230554;
            pictureBox1.Location = new Point(50, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 307);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 이벤트 연결: 마우스 진입/이탈 시 경계선 변경
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(433, 256);
            button1.Name = "button1";
            button1.Size = new Size(119, 50);
            button1.TabIndex = 5;
            button1.Text = "GitHub";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(90, 388);
            button2.Name = "button2";
            button2.Size = new Size(170, 50);
            button2.TabIndex = 6;
            button2.Text = "사진 변경";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.Location = new Point(546, 375);
            button3.Name = "button3";
            button3.Size = new Size(190, 39);
            button3.TabIndex = 7;
            button3.Text = "배경색상 변경";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
