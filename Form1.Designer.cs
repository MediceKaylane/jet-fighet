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
            panelprincipal = new Panel();
            labelEscolhacenario = new Label();
            label4cenario3 = new Label();
            label3cenario2 = new Label();
            label1cenario1 = new Label();
            panel4cidade = new Panel();
            panel3mar = new Panel();
            panel2floresta = new Panel();
            label2titulo = new Label();
            panelMAR = new Panel();
            ((System.ComponentModel.ISupportInitialize)enemyOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            panelprincipal.SuspendLayout();
            panelMAR.SuspendLayout();
            SuspendLayout();
            // 
            // enemyOne
            // 
            enemyOne.BackColor = Color.Transparent;
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
            enemyTwo.BackColor = Color.Transparent;
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
            enemyThree.BackColor = Color.Transparent;
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
            player.BackColor = Color.Transparent;
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
            txtScore.BackColor = Color.Transparent;
            txtScore.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = Color.Teal;
            txtScore.Location = new Point(454, 9);
            txtScore.Margin = new Padding(4, 0, 4, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(46, 51);
            txtScore.TabIndex = 1;
            txtScore.Text = "0";
            txtScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.DarkCyan;
            panelprincipal.Controls.Add(labelEscolhacenario);
            panelprincipal.Controls.Add(label4cenario3);
            panelprincipal.Controls.Add(label3cenario2);
            panelprincipal.Controls.Add(label1cenario1);
            panelprincipal.Controls.Add(panel4cidade);
            panelprincipal.Controls.Add(panel3mar);
            panelprincipal.Controls.Add(panel2floresta);
            panelprincipal.Controls.Add(label2titulo);
            panelprincipal.Location = new Point(36, 29);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(873, 721);
            panelprincipal.TabIndex = 2;
            // 
            // labelEscolhacenario
            // 
            labelEscolhacenario.AutoSize = true;
            labelEscolhacenario.Font = new Font("Segoe UI", 23F);
            labelEscolhacenario.ForeColor = Color.FromArgb(192, 255, 255);
            labelEscolhacenario.Location = new Point(174, 213);
            labelEscolhacenario.Name = "labelEscolhacenario";
            labelEscolhacenario.Size = new Size(518, 42);
            labelEscolhacenario.TabIndex = 6;
            labelEscolhacenario.Text = "Escolha um cenário para sua batalha";
            // 
            // label4cenario3
            // 
            label4cenario3.AutoSize = true;
            label4cenario3.Font = new Font("Segoe UI", 15F);
            label4cenario3.ForeColor = Color.FromArgb(255, 255, 192);
            label4cenario3.Location = new Point(601, 322);
            label4cenario3.Name = "label4cenario3";
            label4cenario3.Size = new Size(110, 28);
            label4cenario3.TabIndex = 5;
            label4cenario3.Text = "CENÁRIO 3";
            // 
            // label3cenario2
            // 
            label3cenario2.AutoSize = true;
            label3cenario2.Font = new Font("Segoe UI", 15F);
            label3cenario2.ForeColor = Color.FromArgb(255, 255, 192);
            label3cenario2.Location = new Point(363, 322);
            label3cenario2.Name = "label3cenario2";
            label3cenario2.Size = new Size(110, 28);
            label3cenario2.TabIndex = 4;
            label3cenario2.Text = "CENÁRIO 2";
            // 
            // label1cenario1
            // 
            label1cenario1.AutoSize = true;
            label1cenario1.Font = new Font("Segoe UI", 15F);
            label1cenario1.ForeColor = Color.FromArgb(255, 255, 192);
            label1cenario1.Location = new Point(134, 322);
            label1cenario1.Name = "label1cenario1";
            label1cenario1.Size = new Size(110, 28);
            label1cenario1.TabIndex = 0;
            label1cenario1.Text = "CENÁRIO 1";
            label1cenario1.Click += l;
            // 
            // panel4cidade
            // 
            panel4cidade.BackgroundImage = (Image)resources.GetObject("panel4cidade.BackgroundImage");
            panel4cidade.BorderStyle = BorderStyle.Fixed3D;
            panel4cidade.Location = new Point(569, 365);
            panel4cidade.Name = "panel4cidade";
            panel4cidade.Size = new Size(177, 261);
            panel4cidade.TabIndex = 3;
            panel4cidade.Click += cenario3click;
            // 
            // panel3mar
            // 
            panel3mar.BackgroundImage = (Image)resources.GetObject("panel3mar.BackgroundImage");
            panel3mar.BorderStyle = BorderStyle.Fixed3D;
            panel3mar.Location = new Point(94, 365);
            panel3mar.Name = "panel3mar";
            panel3mar.Size = new Size(198, 261);
            panel3mar.TabIndex = 3;
            panel3mar.Click += cenario1click;
            panel3mar.Paint += panel3_Paint;
            // 
            // panel2floresta
            // 
            panel2floresta.BackgroundImage = (Image)resources.GetObject("panel2floresta.BackgroundImage");
            panel2floresta.BorderStyle = BorderStyle.Fixed3D;
            panel2floresta.Location = new Point(334, 365);
            panel2floresta.Name = "panel2floresta";
            panel2floresta.Size = new Size(183, 261);
            panel2floresta.TabIndex = 2;
            panel2floresta.Click += cenario2click;
            // 
            // label2titulo
            // 
            label2titulo.AutoSize = true;
            label2titulo.Font = new Font("Stencil", 39.12F);
            label2titulo.ForeColor = Color.FromArgb(255, 255, 192);
            label2titulo.Location = new Point(121, 96);
            label2titulo.Name = "label2titulo";
            label2titulo.Size = new Size(625, 63);
            label2titulo.TabIndex = 1;
            label2titulo.Text = "FIGHTER JET SHOOTING";
            // 
            // panelMAR
            // 
            panelMAR.BackColor = Color.Transparent;
            panelMAR.Controls.Add(panelprincipal);
            panelMAR.Location = new Point(-6, -1);
            panelMAR.Name = "panelMAR";
            panelMAR.Size = new Size(948, 777);
            panelMAR.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 778);
            Controls.Add(player);
            Controls.Add(bullet);
            Controls.Add(enemyThree);
            Controls.Add(enemyTwo);
            Controls.Add(txtScore);
            Controls.Add(enemyOne);
            Controls.Add(panelMAR);
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
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            panelMAR.ResumeLayout(false);
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
        private Panel panelprincipal;
        private Label labelEscolhacenario;
        private Label label4cenario3;
        private Label label3cenario2;
        private Label label1cenario1;
        private Panel panel4cidade;
        private Panel panel3mar;
        private Panel panel2floresta;
        private Label label2titulo;
        private Panel panelMAR;
    }
}
