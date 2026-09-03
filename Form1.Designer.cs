namespace Fighter_Jet_Shooting_Game_MOO_ICT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            enemyOne = new PictureBox();
            enemyTwo = new PictureBox();
            enemyThree = new PictureBox();
            bullet = new PictureBox();
            player = new PictureBox();
            txtScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)enemyOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // enemyOne
            // 
            enemyOne.Image = Properties.Resources.enemy;
            enemyOne.Location = new Point(30, 72);
            enemyOne.Margin = new Padding(4, 3, 4, 3);
            enemyOne.Name = "enemyOne";
            enemyOne.Size = new Size(100, 85);
            enemyOne.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyOne.TabIndex = 0;
            enemyOne.TabStop = false;
            // 
            // enemyTwo
            // 
            enemyTwo.Image = Properties.Resources.enemy;
            enemyTwo.Location = new Point(390, 72);
            enemyTwo.Margin = new Padding(4, 3, 4, 3);
            enemyTwo.Name = "enemyTwo";
            enemyTwo.Size = new Size(100, 85);
            enemyTwo.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyTwo.TabIndex = 0;
            enemyTwo.TabStop = false;
            // 
            // enemyThree
            // 
            enemyThree.Image = Properties.Resources.enemy;
            enemyThree.Location = new Point(775, 72);
            enemyThree.Margin = new Padding(4, 3, 4, 3);
            enemyThree.Name = "enemyThree";
            enemyThree.Size = new Size(100, 85);
            enemyThree.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyThree.TabIndex = 0;
            enemyThree.TabStop = false;
            // 
            // bullet
            // 
            bullet.Image = Properties.Resources.bullet;
            bullet.Location = new Point(552, 351);
            bullet.Margin = new Padding(4, 3, 4, 3);
            bullet.Name = "bullet";
            bullet.Size = new Size(7, 27);
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.TabIndex = 0;
            bullet.TabStop = false;
            // 
            // player
            // 
            player.Image = Properties.Resources.player;
            player.Location = new Point(390, 651);
            player.Margin = new Padding(4, 3, 4, 3);
            player.Name = "player";
            player.Size = new Size(110, 98);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.Location = new Point(13, 314);
            txtScore.Margin = new Padding(4, 0, 4, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(931, 173);
            txtScore.TabIndex = 1;
            txtScore.Text = "0";
            txtScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(59, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 660);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 23F);
            label5.ForeColor = Color.FromArgb(192, 255, 255);
            label5.Location = new Point(126, 176);
            label5.Name = "label5";
            label5.Size = new Size(518, 42);
            label5.TabIndex = 6;
            label5.Text = "Escolha um cenário para sua batalha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(584, 278);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 5;
            label4.Text = "CENÁRIO 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(346, 278);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 4;
            label3.Text = "CENÁRIO 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(117, 278);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "CENÁRIO 1";
            label1.Click += l;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Location = new Point(552, 321);
            panel4.Name = "panel4";
            panel4.Size = new Size(177, 261);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(77, 321);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 261);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(317, 321);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 261);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 39.12F);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(78, 56);
            label2.Name = "label2";
            label2.Size = new Size(625, 63);
            label2.TabIndex = 1;
            label2.Text = "FIGHTER JET SHOOTING";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(933, 778);
            Controls.Add(panel1);
            Controls.Add(player);
            Controls.Add(bullet);
            Controls.Add(enemyThree);
            Controls.Add(enemyTwo);
            Controls.Add(enemyOne);
            Controls.Add(txtScore);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Fighet Jet Shooting Game MOOI CT";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)enemyOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label5;
    }
}
