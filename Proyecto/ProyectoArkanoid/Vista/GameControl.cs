using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoArkanoid.Vista
{
    public partial class GameControl : UserControl
    {
        private int vSpeed, hSpeed, lives = 3, score = 0;
        public GameControl()
        {
            InitializeComponent();
            vSpeed = 3;
            hSpeed = 3;
            lblLives.Text = lives.ToString();
            lblScore.Text = "0000";
        }

        private void GameControl_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picBall.Top += vSpeed;
            picBall.Left += hSpeed;
            picAlien.Left += hSpeed;

            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds) || picBall.Bounds.IntersectsWith(tableTTop.Bounds))
            {
                vSpeed = -vSpeed;
            }
            if (picBall.Right > this.ClientSize.Width || picBall.Left < 0)
            {
                hSpeed = -hSpeed;
            }

            if (picAlien.Right > this.ClientSize.Width || picAlien.Left < 0)
            {
                hSpeed = -hSpeed;
            }

            /*
            if (picBall.Bounds.IntersectsWith(picAlien.Bounds) && picAlien.Visible)
            {
                vSpeed += 2;
                picAlien.Visible = false;
                vSpeed = -vSpeed;
                hSpeed = -hSpeed;
                score += 200;
                lblScore.Text = score.ToString();
            }*/


            if (picBall.Bottom > this.ClientSize.Height)
            {
                if (lives == 0)
                {
                    Application.Exit();
                }
                else
                {
                    lives -= 1;
                    lblLives.Text = lives.ToString();
                    System.Threading.Thread.Sleep(1000);
                    picBall.Location = new Point(100, 150);

                }

            }
        }
    }
}
