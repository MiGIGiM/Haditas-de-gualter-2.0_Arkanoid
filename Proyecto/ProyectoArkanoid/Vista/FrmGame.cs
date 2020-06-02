using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoArkanoid.Vista
{
    public partial class FrmGame : Form
    {
        private int vSpeed, hSpeed;
        public FrmGame()
        {
            InitializeComponent();
            vSpeed = 5;
            hSpeed = 5;
        }

        private void picPaddle_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }

        private void FrmGame_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //mover la pelota
            picBall.Top += vSpeed;
            picBall.Left += hSpeed;

            //hacer que no se salga de la pantalla
            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds) || picBall.Bounds.IntersectsWith(picTop.Bounds))
            {
                vSpeed = -vSpeed;
            }
            if (picBall.Right > this.ClientSize.Width || picBall.Left < 0)
            {
                hSpeed = -hSpeed;
            }


            

            if (picBall.Bottom > this.ClientSize.Height)
            {

                System.Threading.Thread.Sleep(1000);
                picBall.Location = new Point(100, 150);

            }
        }
    }
}
