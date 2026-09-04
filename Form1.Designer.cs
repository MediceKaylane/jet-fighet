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
            aviaoAmigo = new PictureBox();
            balaAmigo = new PictureBox();
            labelEscolhacenario = new Label();
            label4cenario3 = new Label();
            label3cenario2 = new Label();
            label1cenario1 = new Label();
            panel4cidade = new Panel();
            panel3mar = new Panel();
            panel2floresta = new Panel();
            label2titulo = new Label();
            panelMAR = new Panel();
            timerBalaAmigo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)enemyOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            panelprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)aviaoAmigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)balaAmigo).BeginInit();
            panelMAR.SuspendLayout();
            SuspendLayout();
            // 
            // enemyOne
            // 
            enemyOne.BackColor = Color.Transparent;
            enemyOne.Image = Properties.Resources.enemy;
            enemyOne.Location = new Point(34, 96);
            enemyOne.Margin = new Padding(5, 4, 5, 4);
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
            enemyTwo.Location = new Point(446, 96);
            enemyTwo.Margin = new Padding(5, 4, 5, 4);
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
            enemyThree.Location = new Point(886, 96);
            enemyThree.Margin = new Padding(5, 4, 5, 4);
            enemyThree.Name = "enemyThree";
            enemyThree.Size = new Size(100, 85);
            enemyThree.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyThree.TabIndex = 0;
            enemyThree.TabStop = false;
            // 
            // bullet
            // 
            bullet.Image = Properties.Resources.bullet;
            bullet.Location = new Point(631, 468);
            bullet.Margin = new Padding(5, 4, 5, 4);
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
            player.Location = new Point(446, 868);
            player.Margin = new Padding(5, 4, 5, 4);
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
            txtScore.Location = new Point(519, 12);
            txtScore.Margin = new Padding(5, 0, 5, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(53, 68);
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
            panelprincipal.Controls.Add(balaAmigo);
            panelprincipal.Controls.Add(aviaoAmigo);
            panelprincipal.Controls.Add(labelEscolhacenario);
            panelprincipal.Controls.Add(label4cenario3);
            panelprincipal.Controls.Add(label3cenario2);
            panelprincipal.Controls.Add(label1cenario1);
            panelprincipal.Controls.Add(panel4cidade);
            panelprincipal.Controls.Add(panel3mar);
            panelprincipal.Controls.Add(panel2floresta);
            panelprincipal.Controls.Add(label2titulo);
            panelprincipal.Location = new Point(41, 39);
            panelprincipal.Margin = new Padding(3, 4, 3, 4);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(998, 961);
            panelprincipal.TabIndex = 2;
            // 
            // aviaoAmigo
            // 
            aviaoAmigo.BackColor = Color.Transparent;
            aviaoAmigo.Image = Properties.Resources.player;
            aviaoAmigo.Location = new Point(579, 831);
            aviaoAmigo.Margin = new Padding(5, 4, 5, 4);
            aviaoAmigo.Name = "aviaoAmigo";
            aviaoAmigo.Size = new Size(110, 98);
            aviaoAmigo.SizeMode = PictureBoxSizeMode.AutoSize;
            aviaoAmigo.TabIndex = 8;
            aviaoAmigo.TabStop = false;
            // 
            // balaAmigo
            // 
            balaAmigo.Image = Properties.Resources.bullet;
            balaAmigo.Location = new Point(715, 471);
            balaAmigo.Margin = new Padding(5, 4, 5, 4);
            balaAmigo.Name = "balaAmigo";
            balaAmigo.Size = new Size(7, 27);
            balaAmigo.SizeMode = PictureBoxSizeMode.AutoSize;
            balaAmigo.TabIndex = 8;
            balaAmigo.TabStop = false;
            // 
            // labelEscolhacenario
            // 
            labelEscolhacenario.AutoSize = true;
            labelEscolhacenario.Font = new Font("Segoe UI", 23F);
            labelEscolhacenario.ForeColor = Color.FromArgb(192, 255, 255);
            labelEscolhacenario.Location = new Point(199, 284);
            labelEscolhacenario.Name = "labelEscolhacenario";
            labelEscolhacenario.Size = new Size(651, 52);
            labelEscolhacenario.TabIndex = 6;
            labelEscolhacenario.Text = "Escolha um cenário para sua batalha";
            // 
            // label4cenario3
            // 
            label4cenario3.AutoSize = true;
            label4cenario3.Font = new Font("Segoe UI", 15F);
            label4cenario3.ForeColor = Color.FromArgb(255, 255, 192);
            label4cenario3.Location = new Point(687, 429);
            label4cenario3.Name = "label4cenario3";
            label4cenario3.Size = new Size(139, 35);
            label4cenario3.TabIndex = 5;
            label4cenario3.Text = "CENÁRIO 3";
            // 
            // label3cenario2
            // 
            label3cenario2.AutoSize = true;
            label3cenario2.Font = new Font("Segoe UI", 15F);
            label3cenario2.ForeColor = Color.FromArgb(255, 255, 192);
            label3cenario2.Location = new Point(415, 429);
            label3cenario2.Name = "label3cenario2";
            label3cenario2.Size = new Size(139, 35);
            label3cenario2.TabIndex = 4;
            label3cenario2.Text = "CENÁRIO 2";
            // 
            // label1cenario1
            // 
            label1cenario1.AutoSize = true;
            label1cenario1.Font = new Font("Segoe UI", 15F);
            label1cenario1.ForeColor = Color.FromArgb(255, 255, 192);
            label1cenario1.Location = new Point(153, 429);
            label1cenario1.Name = "label1cenario1";
            label1cenario1.Size = new Size(139, 35);
            label1cenario1.TabIndex = 0;
            label1cenario1.Text = "CENÁRIO 1";
            label1cenario1.Click += l;
            // 
            // panel4cidade
            // 
            panel4cidade.BackgroundImage = (Image)resources.GetObject("panel4cidade.BackgroundImage");
            panel4cidade.BorderStyle = BorderStyle.Fixed3D;
            panel4cidade.Location = new Point(650, 487);
            panel4cidade.Margin = new Padding(3, 4, 3, 4);
            panel4cidade.Name = "panel4cidade";
            panel4cidade.Size = new Size(202, 347);
            panel4cidade.TabIndex = 3;
            panel4cidade.Click += cenario3click;
            // 
            // panel3mar
            // 
            panel3mar.BackgroundImage = (Image)resources.GetObject("panel3mar.BackgroundImage");
            panel3mar.BorderStyle = BorderStyle.Fixed3D;
            panel3mar.Location = new Point(107, 487);
            panel3mar.Margin = new Padding(3, 4, 3, 4);
            panel3mar.Name = "panel3mar";
            panel3mar.Size = new Size(226, 347);
            panel3mar.TabIndex = 3;
            panel3mar.Click += cenario1click;
            panel3mar.Paint += panel3_Paint;
            // 
            // panel2floresta
            // 
            panel2floresta.BackgroundImage = (Image)resources.GetObject("panel2floresta.BackgroundImage");
            panel2floresta.BorderStyle = BorderStyle.Fixed3D;
            panel2floresta.Location = new Point(382, 487);
            panel2floresta.Margin = new Padding(3, 4, 3, 4);
            panel2floresta.Name = "panel2floresta";
            panel2floresta.Size = new Size(209, 347);
            panel2floresta.TabIndex = 2;
            panel2floresta.Click += cenario2click;
            // 
            // label2titulo
            // 
            label2titulo.AutoSize = true;
            label2titulo.Font = new Font("Stencil", 39.12F);
            label2titulo.ForeColor = Color.FromArgb(255, 255, 192);
            label2titulo.Location = new Point(138, 128);
            label2titulo.Name = "label2titulo";
            label2titulo.Size = new Size(779, 78);
            label2titulo.TabIndex = 1;
            label2titulo.Text = "FIGHTER JET SHOOTING";
            // 
            // panelMAR
            // 
            panelMAR.BackColor = Color.Transparent;
            panelMAR.Controls.Add(panelprincipal);
            panelMAR.Location = new Point(-7, -1);
            panelMAR.Margin = new Padding(3, 4, 3, 4);
            panelMAR.Name = "panelMAR";
            panelMAR.Size = new Size(1083, 1036);
            panelMAR.TabIndex = 7;
            // 
            // timerBalaAmigo
            // 
            timerBalaAmigo.Interval = 2000;
            timerBalaAmigo.Tick += timerBalaAmigo_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1066, 1037);
            Controls.Add(player);
            Controls.Add(bullet);
            Controls.Add(enemyThree);
            Controls.Add(enemyTwo);
            Controls.Add(txtScore);
            Controls.Add(enemyOne);
            Controls.Add(panelMAR);
            Margin = new Padding(5, 4, 5, 4);
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
            ((System.ComponentModel.ISupportInitialize)aviaoAmigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)balaAmigo).EndInit();
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
        private PictureBox aviaoAmigo;
        private PictureBox balaAmigo;
        private System.Windows.Forms.Timer timerBalaAmigo;
    }
}
