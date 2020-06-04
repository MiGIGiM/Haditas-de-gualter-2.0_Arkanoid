using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoArkanoid.Controladores;
using ProyectoArkanoid.Vista;

namespace ProyectoArkanoid
{
    public partial class GameControl : UserControl
    {
        private int vSpeed, hSpeed, hSpeedA, hSpeedB, hSpeedC, lives = 3, score = 0, cont = 0;
        private const int row = 16, col = 11;
        private BlocksRemove[,] blocks;


        public GameControl()
        {
            InitializeComponent();
        }

        private void GameControl_Load(object sender, EventArgs e)
        {
            vSpeed = 3;
            hSpeedC = hSpeedB = hSpeedA = hSpeed = 3;
            setBlocks();
            lblLives.Text = lives.ToString();
            lblScore.Text = "0000";
            lblEnd.Hide();
        }
        private void GameControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Application.Restart();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            picAlien.Left += hSpeedA;
            picAlien2.Left += hSpeedB;
            picAlien3.Left += hSpeedC;

            if (picAlien.Right > this.ClientSize.Width || picAlien.Left < 0)
            {
                hSpeedA = -hSpeedA;
            }

            if (picAlien2.Right > this.ClientSize.Width || picAlien2.Left < 0)
            {
                hSpeedB = -hSpeedB;
            }

            for (int x = 5; x < row; x++)
            {
                for (int y = 3; y < col; y++)
                {
                    if (picAlien2.Bounds.IntersectsWith(blocks[x, y].Bounds) || picAlien2.Left < 0)
                    {
                        hSpeedB = -hSpeedB;
                    }

                }
            }

            if (picAlien3.Right > this.ClientSize.Width || picAlien3.Left < 0)
            {
                hSpeedC = -hSpeedC;
            }

            for (int x = 5; x < row; x++)
            {
                for (int y = 3; y < col; y++)
                {
                    if (picAlien3.Bounds.IntersectsWith(blocks[x, y].Bounds) || picAlien3.Right > this.ClientSize.Width)
                    {
                        hSpeedC = -hSpeedC;
                    }

                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            picBall.Top += vSpeed;
            picBall.Left += hSpeed;

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

            //Cuando la pelota toca a los aliens, desapareces y suman puntos
            if (picBall.Bounds.IntersectsWith(picAlien.Bounds) && picAlien.Visible)
            {
                vSpeed += 2;
                picAlien.Visible = false;
                vSpeed = -vSpeed;
                hSpeed = -hSpeed;
                score += 200;
                lblScore.Text = score.ToString();
                cont++;
            }

            if (picBall.Bounds.IntersectsWith(picAlien2.Bounds) && picAlien2.Visible)
            {
                vSpeed += 2;
                picAlien2.Visible = false;
                vSpeed = -vSpeed;
                hSpeed = -hSpeed;
                score += 200;
                lblScore.Text = score.ToString();
                cont++;
            }
            if (picBall.Bounds.IntersectsWith(picAlien3.Bounds) && picAlien3.Visible)
            {
                vSpeed += 2;
                picAlien3.Visible = false;
                vSpeed = -vSpeed;
                hSpeed = -hSpeed;
                score += 200;
                lblScore.Text = score.ToString();
                cont++;
            }

            //Si la pelota toca el limite inferior del control, el usuario pierde una vida.
            if (picBall.Bottom > this.ClientSize.Height)
            {
                if (lives == 1)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    lblEnd.Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
                    lblEnd.Show();
                }
                else
                {
                    lives -= 1;
                    lblLives.Text = lives.ToString();
                    System.Threading.Thread.Sleep(1000);
                    picBall.Location = new Point(81, 392);
                }

            }

            //eliminar los bloques que la pelota toca
            for (int x = 5; x < row; x++)
            {
                for (int y = 3; y < col; y++)
                {
                    if (picBall.Bounds.IntersectsWith(blocks[x, y].Bounds) && blocks[x, y].Visible)
                    {
                        blocks[x, y].BackgroundImage = Image.FromFile("../../Resources/Tile---violet.png");
                        blocks[x, y].BorrarBloque();
                        vSpeed = -vSpeed;
                        score += 50;
                        lblScore.Text = score.ToString();
                        cont++;
                    }
                }
            }
            //Este if sirve para "acelerar" la pelota 
            if (score > 2000)
                timer1.Interval = 1;
            //Si el contador llega a 179, significa que ya no hay mas bloques en el nivel y el jugador gana
            if(cont == 179)
            {
                lblEnd.Text = "Has ganado! \nPresione enter para regresar al menu.";
                lblEnd.Show();
                timer1.Enabled = timer2.Enabled = false;
                picPaddle.Visible = picBall.Visible = false;
            }
        }

        private void GameControl_MouseMove(object sender, MouseEventArgs e)
        {
            //Esta linea se usa para hacer que la barra siga al mouse
            //Se divide entre 2 para que el mouse se posicione al centro de la barra y sea mas facil de seguir
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }

        //Este metodo sirve para crear los bloques
        private void setBlocks()
        {
            int blockHeight = 25, blockWidth = 100;

            blocks = new BlocksRemove[row, col];

            for (int x = 5; x < row; x++)
            {
                for (int y = 3; y < col; y++)
                {
                    blocks[x, y] = new BlocksRemove(0);

                    blocks[x, y].Width = blockWidth;
                    blocks[x, y].Height = blockHeight;

                    blocks[x, y].Top = blockHeight * x;
                    blocks[x, y].Left = blockWidth * y;

                    blocks[x, y].BackgroundImage = Image.FromFile("../../Resources/Tile - pink.png");
                    blocks[x, y].BackgroundImageLayout = ImageLayout.Stretch;

                    this.Controls.Add(blocks[x, y]);
                }
            }

        }

    }
}