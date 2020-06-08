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

namespace ProyectoArkanoid.Vista
{
    public partial class GameControls : UserControl
    {
        private CustomPictureBox[,] cpb;
        public GameControls()
        {
            InitializeComponent();
            
        }

        private void GameControls_Load(object sender, EventArgs e)
        {
            // Se carga al picture box la imagen que se usara como la barra del juego
            pictureBox1.BackgroundImage = Image.FromFile("../../Resources/paddle.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            // Se ajusta la posicion de la barra para que se vea de manera adecuada 
            pictureBox1.Top = ((Height - pictureBox1.Height) - 90);

            LoadTiles();

        }
        private void LoadTiles()
        {
            int xAxis = 10;
            int yAxis = 7;

            int pbHeight = (int)(Height * 0.3) / yAxis;
            int pbWidth = (Width - (xAxis - 5))/ xAxis;
            cpb = new CustomPictureBox[yAxis, xAxis];

            for (int i = 0; i< yAxis; i++)
            {
                for(int j = 0; j< xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();

                    if (i == 0)
                        cpb[i, j].Golpes = 2;
                    else
                        cpb[i, j].Golpes = 1;

                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;
                    //Posicion de left y posicion de top
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight;

                    cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/" + GenerateRandomNumber() + ".png");
                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    cpb[i, j].Tag = "tileTag";
                    Controls.Add(cpb[i, j]);
                }
            }
        }
        private int GenerateRandomNumber()
        {
            return new Random().Next(1, 7);
        }

        private void GameControls_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.X < (Width - pictureBox1.Width))
            pictureBox1.Left = e.X;
        }
    }
}
