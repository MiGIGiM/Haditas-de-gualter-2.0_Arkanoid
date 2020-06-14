using ProyectoArkanoid.Vista;
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
    public partial class FrmMain : Form
    {
        private MainControl mControl;
        private GameControls gControl;
        //private UserControl current;
        public FrmMain()
        {
            InitializeComponent();
            // Sirve para que la pantalla se adapte a cualquier resolucion y siempre este maximizada
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            
            mControl = new MainControl();
            gControl = new GameControls();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

            mControl.Dock = DockStyle.Fill;
            mControl.Width = Width;
            mControl.Height = Height;

            gControl.Dock = DockStyle.Fill;
            gControl.Width = Width;
            gControl.Height = Height;

            Controls.Add(gControl);
            gControl.Hide();

            Controls.Add(mControl);

            mControl.OnClickButtonPlay += OnClickToMainControl;
        }
        private void OnClickToMainControl(object sender, EventArgs e)
        {
            mControl.Hide();
            gControl.Show();

        }

    }
}
