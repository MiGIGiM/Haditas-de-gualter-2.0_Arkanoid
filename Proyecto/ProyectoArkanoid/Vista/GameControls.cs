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
    public partial class GameControls : UserControl
    {
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

        }
    }
}
