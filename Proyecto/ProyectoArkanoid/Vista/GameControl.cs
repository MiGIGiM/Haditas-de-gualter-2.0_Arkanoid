using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoArkanoid
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            picBall.Top += vSpeed;
            picBall.Left += hSpeed;
            picAlien.Left += hSpeed;

            //Este if se utiliza para hacer que la pelota cambie el sentido de su 
            //movimiento cuando "choca" con los controles en la parte superior
            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds) || picBall.Bounds.IntersectsWith(tableTTop.Bounds))
            {
                vSpeed = -vSpeed;
            }
            //Este if se utiliza para hacer que la pelota cambie el sentido de su 
            //movimiento cuando "choca" con los bordes a los lados
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

            //Si la pelota toca el limite superior del forms, el usuario pierde una vida.
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

        private void GameControl_MouseMove(object sender, MouseEventArgs e)
        {
            //Esta linea se usa para hacer que la barra siga al mouse
            //Se divide entre 2 para que el mouse se posicione al centro de la barra y sea mas facil de seguir
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }

    }
}
