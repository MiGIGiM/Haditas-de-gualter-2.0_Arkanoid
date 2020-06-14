using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoArkanoid.Controladores;

namespace ProyectoArkanoid.Vista
{
    public partial class GameControls : UserControl
    {
        private CustomPictureBox[,] cpb;
        private PictureBox picBall;
        public GameControls()
        {
            InitializeComponent();
            
        }

        private void GameControls_Load(object sender, EventArgs e)
        {
            // Se carga al picture box la imagen que se usara como la barra del juego
            picPaddle.BackgroundImage = Image.FromFile("../../Resources/paddle.png");
            picPaddle.BackgroundImageLayout = ImageLayout.Stretch;

            // Se ajusta la posicion de la barra para que se vea de manera adecuada 
            picPaddle.Top = ((Height - picPaddle.Height) - 90);
            // Se ajusta la posicion de la barra para que inicie al centro de la pantalla 
            picPaddle.Left = (Width / 2) - (picPaddle.Width / 2);

            //Instanciacion de la pelota
            picBall = new PictureBox();
            picBall.Width = picBall.Height = 20;
            picBall.BackgroundImage = Image.FromFile("../../Resources/ball.png");
            picBall.BackgroundImageLayout = ImageLayout.Stretch;

            //Definir la posicion para que la pelota empiece encima de la barra
            picBall.Top = picPaddle.Top - picBall.Height;
            picBall.Left = picPaddle.Left + (picPaddle.Width / 2) - (picBall.Width / 2);
            //Se pone el color de fondo del picturebox a transparente
            picBall.BackColor = Color.Transparent;

            Controls.Add(picBall);


            LoadTiles();
            timer1.Start();
        }
        private void LoadTiles()
        {
            int xAxis = 10;
            int yAxis = 6;

            int pbHeight = (int)(Height * 0.4) / yAxis;
            int pbWidth = (int)(Width - (Width * 0.45) - (xAxis - 5)) / xAxis;
            int valorExtraWidth = (int)(Width *0.45) / 2;
            int valorExtraHeight = (int)(Height * 0.20) / 2;
            cpb = new CustomPictureBox[yAxis, xAxis];

            for (int i = 0; i< yAxis; i++)
            {
                for(int j = 0; j< xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();

                    if (i == 0)
                    {
                        cpb[i, j].Golpes = 2;
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/0.png");
                    }
                    else
                    {
                        cpb[i, j].Golpes = 1;
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/" + GenerateRandomNumber() + ".png");
                    }


                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;
                    //Posicion de left y posicion de top

                    cpb[i, j].Left = valorExtraWidth + (j * pbWidth);
                    cpb[i, j].Top = valorExtraHeight + (i * pbHeight);

                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    cpb[i, j].Tag = "tileTag";
                    Controls.Add(cpb[i, j]);
                }
            }
        }
        private int GenerateRandomNumber()
        {
            return new Random().Next(1, 5);
        }

        private void GameControls_MouseMove(object sender, MouseEventArgs e)
        {
            if (!DatosJuego.juegoIniciado)
            {
                if (e.X < (Width - picPaddle.Width))
                {
                    picPaddle.Left = e.X;
                    picBall.Left = picPaddle.Left + (picPaddle.Width / 2) + (picBall.Width / 2);
                }


            }
            else
            {
                if (e.X < (Width - picPaddle.Width))
                    picPaddle.Left = e.X;
            }

        }

        private void GameControls_KeyDown(object sender, KeyEventArgs e)
        {
            //Al presionar la barra espaciadora, el juego comienza
            if (e.KeyCode == Keys.Space)
                DatosJuego.juegoIniciado = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Si el juego no ha iniciado, no se hace nada
            if (!DatosJuego.juegoIniciado)
                return;
            //Por otro lado, si el juego ya empezo, se aumentan los valores de left y top con
            //las variables establecidas en la clase estatica para que la pelota se mueva.
            picBall.Left += DatosJuego.dirX;
            picBall.Top += DatosJuego.dirY;
            
            RebotarPelota();
        }

        private void RebotarPelota()
        {
            //Si la pelota toca la parte inferior del control, el usuario ha perdido
            if (picBall.Bottom > Height)
                Application.Exit();

            //Si la pelota toca los bordes izq o der, rebota
            if (picBall.Left < 0 || picBall.Right > Width)
            {
                DatosJuego.dirX = -DatosJuego.dirX;
                return;
            }

            //Rebotar la pelota cuando choca con la barra del jugador
            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds) || picBall.Top < 0)
            {
                DatosJuego.dirY = -DatosJuego.dirY;
            }
            //la variable i se disminuye ya que se esta iniciando desde la fila mas cercana a la pelota
            //esto se hace para hacer el menor numero de verificaciones posible
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    //Cuando la pelota choca con un bloque, este se elimina y la pelota rebota
                    // y se mueve hacia el otro lado
                    if (picBall.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {
                        if(i == 0)
                            cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/" + GenerateRandomNumber() + ".png");

                        cpb[i, j].Golpes--;
                        if (cpb[i, j].Golpes == 0)
                            Controls.Remove(cpb[i, j]);

                        DatosJuego.dirY = -DatosJuego.dirY;

                        return;

                    }
                }
            }
        }
    }
}
