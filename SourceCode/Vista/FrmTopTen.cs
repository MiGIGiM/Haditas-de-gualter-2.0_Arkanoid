using ProyectoArkanoid.Controladores;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoArkanoid.Vista
{
    public partial class FrmTopTen : Form
    {
        public delegate void OnCloseWindow();
        public OnCloseWindow CloseAction;

        public FrmTopTen()
        {
            InitializeComponent();
        }

        private void FrmTopTen_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseAction?.Invoke();
        }

        private void FrmTopTen_Load(object sender, System.EventArgs e)
        {
            // Poblando el data grit con los datos obtenidos de la consulta a la base de datos
            dataGridView1.DataSource = PlayerController.GetScoreTable();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }
    }
}

