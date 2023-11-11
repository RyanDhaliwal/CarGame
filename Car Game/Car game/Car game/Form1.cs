using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_game
{
    public partial class Form1 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;
        bool goleft;
        bool goright;
        Random rnd = new Random();
        Random carPosition = new Random();

        public Form1()
        {
            InitializeComponent();
            medalImage.Visible = false;
            explosion.Visible = false;
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            scoretext.Text = "Score: " + score;
            score++;

            if (goleft == true && player.Left > 5)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 490)
            {
                player.Left += playerSpeed;
            }

            roadPic1.Top += roadSpeed;
            roadPic2.Top += roadSpeed;

            if (roadPic2.Top > 519)
            {
                roadPic2.Top = -519;
            }
            if (roadPic1.Top > 519)
            {
                roadPic1.Top = -519;
            }

            randCar1.Top += trafficSpeed;
            randCar2.Top += trafficSpeed;

            if (randCar1.Top > 530)
            {
                changeAIcars(randCar1);
            }

            if (randCar2.Top > 530)
            {
                changeAIcars(randCar2);
            }

            if (player.Bounds.IntersectsWith(randCar1.Bounds) || player.Bounds.IntersectsWith(randCar2.Bounds))
            {
                gameOver();
            }

            if (score > 40 && score < 500)
            {
                medalImage.Image = Properties.Resources.bronze;
            }

            if (score > 500 && score < 2000)
            {
                medalImage.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }

            if (score > 2000)
            {
                medalImage.Image = Properties.Resources.gold;
                trafficSpeed = 27;
                roadSpeed = 25;
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {

            carImage = rnd.Next(1, 9);

            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 400) * -1;

            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void gameOver()
        {

            timer1.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            medalImage.Visible = true;
            medalImage.BringToFront();

            startButton.Enabled = true;
        }

        private void ResetGame()
        {
            startButton.Enabled = false;
            explosion.Visible = false;
            medalImage.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            medalImage.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            randCar1.Top = carPosition.Next(200, 500) * -1;
            randCar1.Left = carPosition.Next(5, 200);

            randCar2.Top = carPosition.Next(200, 500) * -1;
            randCar2.Left = carPosition.Next(245, 422);

            timer1.Start();

        }
        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

    }
}
