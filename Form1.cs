using System.Numerics;

namespace Fighter_Jet_Shooting_Game_MOO_ICT
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, shooting, isGameOver;
        bool atirandoAmigo;
        bool cenario2Ativo = false;

        int score;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        int velocidadeBalaAmigo = 20;

        Random rnd = new Random();




        public Form1()
        {
            InitializeComponent();

            player.Visible = false;
            enemyOne.Visible = false;
            enemyTwo.Visible = false;
            enemyThree.Visible = false;
            bullet.Visible = false;
            txtScore.Visible = false;

            aviaoAmigo.Visible = false;
            balaAmigo.Visible = false;





            resetGame();
        }



        private void mainGameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = score.ToString();


            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;


            if (enemyOne.Top > 710 || enemyTwo.Top > 710 || enemyThree.Top > 710)
            {
                gameOver();
            }


            // player movement logic starts

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true && player.Left < 688)
            {
                player.Left += playerSpeed;
            }

            // player movement logic ends


            // Tiro do jogador

            if (shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top < -30)
            {
                shooting = false;
            }

            // Tiro do avião amigo

            if (atirandoAmigo == true)
            {
                balaAmigo.Top -= velocidadeBalaAmigo;
            }

            if (balaAmigo.Top < -30)
            {
                atirandoAmigo = false;
            }



            // Colisão da bala do jogador com os inimigos

            if (bullet.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rnd.Next(20, 600);
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                score += 1;
                enemyTwo.Top = -650;
                enemyTwo.Left = rnd.Next(20, 600);
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                score += 1;
                enemyThree.Top = -750;
                enemyThree.Left = rnd.Next(20, 600);
                shooting = false;
            }


            // AUMENTO DA VELOCIDADE DOS INIMIGOS

            if (score == 5)
            {
                enemySpeed = 10;
            }

            if (score == 10)
            {
                enemySpeed = 15;
            }


        }




        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }


        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Width / 2);
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }


        private void resetGame()
        {
            gameTimer.Start();

            enemySpeed = 6;


            enemyOne.Left = rnd.Next(20, 600);
            enemyTwo.Left = rnd.Next(20, 600);
            enemyThree.Left = rnd.Next(20, 600);


            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTwo.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0, 900) * -1;


            score = 0;

            bulletSpeed = 0;

            bullet.Left = -300;

            shooting = false;


            txtScore.Text = score.ToString();
        }


        private void gameOver()
        {
            isGameOver = true;

            gameTimer.Stop();



            txtScore.Text += Environment.NewLine +
                "Você perdeu!" +
                Environment.NewLine +
                "Pressione Enter para tentar de novo";
        }


        private void l(object sender, EventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void cenario1click(object sender, EventArgs e)
        {
            label2titulo.Visible = false;
            labelEscolhacenario.Visible = false;
            label1cenario1.Visible = false;
            panel3mar.Visible = false;
            panel2floresta.Visible = false;
            panel4cidade.Visible = false;
            panelprincipal.Visible = false;


            this.BackgroundImage = Properties.Resources.mar;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            player.Visible = true;
            enemyOne.Visible = true;
            enemyTwo.Visible = true;
            enemyThree.Visible = true;
            bullet.Visible = true;
            txtScore.Visible = true;






            resetGame();
        }




        private void cenario2click(object sender, EventArgs e)
        {
            label2titulo.Visible = false;
            labelEscolhacenario.Visible = false;
            label1cenario1.Visible = false;
            panel3mar.Visible = false;
            panel2floresta.Visible = false;
            panel4cidade.Visible = false;
            panelprincipal.Visible = false;

            this.BackgroundImage = Properties.Resources.floresta;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            player.Visible = true;
            enemyOne.Visible = true;
            enemyTwo.Visible = true;
            enemyThree.Visible = true;
            bullet.Visible = true;
            txtScore.Visible = true;

            // ATIVA O AVIÃO AMIGO
            cenario2Ativo = true;

            this.Controls.Add(aviaoAmigo);

            aviaoAmigo.Visible = true;
            aviaoAmigo.Left = 700;
            aviaoAmigo.Top = 600;
            aviaoAmigo.BringToFront();

            this.Controls.Add(balaAmigo);
            balaAmigo.Visible = true;
            balaAmigo.Left = aviaoAmigo.Left + (aviaoAmigo.Width / 2);
            balaAmigo.Top = aviaoAmigo.Top - 20;

            timerBalaAmigo.Start();
            resetGame();
        }





        private void panel2floresta_Click(object sender, EventArgs e)
        {
            cenario2click(sender, e);
            panelMAR.SendToBack();
        }



        private void cenario3click(object sender, EventArgs e)
        {
            label2titulo.Visible = false;
            labelEscolhacenario.Visible = false;
            label1cenario1.Visible = false;
            panel3mar.Visible = false;
            panel2floresta.Visible = false;
            panel4cidade.Visible = false;
            panelprincipal.Visible = false;


            this.BackgroundImage = Properties.Resources.cidade3;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            player.Visible = true;
            enemyOne.Visible = true;
            enemyTwo.Visible = true;
            enemyThree.Visible = true;
            bullet.Visible = true;
            txtScore.Visible = true;


            // Desativa avião amigo

            cenario2Ativo = false;

            aviaoAmigo.Visible = false;
            balaAmigo.Visible = false;
            timerBalaAmigo.Stop();




            resetGame();
        }

        private void timerBalaAmigo_Tick(object sender, EventArgs e)
        {
            balaAmigo.Left = aviaoAmigo.Left + (aviaoAmigo.Width / 2);
            balaAmigo.Top = aviaoAmigo.Top - 20;

            balaAmigo.BringToFront();

            atirandoAmigo = true;
           
        }
    }
}