using System.Windows.Forms;

namespace ProyectoArkanoid.Vista
{
    public partial class FrmTopTen : Form
    {
        public FrmTopTen()
        {
            InitializeComponent();
        }

        // Terminar la ejecucion del programa 
        private void FrmTopTen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
