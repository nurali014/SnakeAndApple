namespace SnakeAndApple
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
            components = new System.ComponentModel.Container();
            snake = new PictureBox();
            apple = new PictureBox();
            bomb = new PictureBox();
            lblScore = new Label();
            lblTime = new Label();
            lblSpeed = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)snake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)apple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bomb).BeginInit();
            SuspendLayout();
            //
            // snake
            //
            snake.BackColor = Color.Transparent;
            snake.Location = new Point(420, 380);
            snake.Name = "snake";
            snake.Size = new Size(90, 90);
            snake.SizeMode = PictureBoxSizeMode.StretchImage;
            snake.TabIndex = 0;
            snake.TabStop = false;
            //
            // apple
            //
            apple.BackColor = Color.Transparent;
            apple.Location = new Point(100, 60);
            apple.Name = "apple";
            apple.Size = new Size(70, 70);
            apple.SizeMode = PictureBoxSizeMode.StretchImage;
            apple.TabIndex = 1;
            apple.TabStop = false;
            //
            // bomb
            //
            bomb.BackColor = Color.Transparent;
            bomb.Location = new Point(100, 60);
            bomb.Name = "bomb";
            bomb.Size = new Size(70, 70);
            bomb.SizeMode = PictureBoxSizeMode.StretchImage;
            bomb.TabIndex = 2;
            bomb.TabStop = false;
            bomb.Visible = false;
            //
            // lblScore
            //
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblScore.ForeColor = Color.ForestGreen;
            lblScore.Location = new Point(12, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(64, 28);
            lblScore.TabIndex = 3;
            lblScore.Text = "Xal: 0";
            //
            // lblTime
            //
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTime.ForeColor = Color.Firebrick;
            lblTime.Location = new Point(140, 9);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(85, 28);
            lblTime.TabIndex = 4;
            lblTime.Text = "Vaxt: 5";
            //
            // lblSpeed
            //
            lblSpeed.AutoSize = true;
            lblSpeed.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSpeed.ForeColor = Color.SteelBlue;
            lblSpeed.Location = new Point(280, 9);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(95, 28);
            lblSpeed.TabIndex = 5;
            lblSpeed.Text = "Sürət: 5";
            //
            // timer1
            //
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            //
            // timer2
            //
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 520);
            Controls.Add(snake);
            Controls.Add(apple);
            Controls.Add(bomb);
            Controls.Add(lblScore);
            Controls.Add(lblTime);
            Controls.Add(lblSpeed);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake and apple";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)snake).EndInit();
            ((System.ComponentModel.ISupportInitialize)apple).EndInit();
            ((System.ComponentModel.ISupportInitialize)bomb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox snake;
        private PictureBox apple;
        private PictureBox bomb;
        private Label lblScore;
        private Label lblTime;
        private Label lblSpeed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
