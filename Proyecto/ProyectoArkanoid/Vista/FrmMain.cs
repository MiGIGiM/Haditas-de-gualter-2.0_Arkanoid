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
        private LoginControl lControl;

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
            lControl = new LoginControl();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Prpiedades para MainControl
            mControl.Dock = DockStyle.Fill;
            mControl.Width = Width;
            mControl.Height = Height;
            //Propiedades para GameControls
            gControl.Dock = DockStyle.Fill;
            gControl.Width = Width;
            gControl.Height = Height;
            //Propiedades para LoginControl
            lControl.Dock = DockStyle.Fill;
            lControl.Width = Width;
            lControl.Height = Height;
            //Se agrega el Login primero, pero se oculta esperando el evento click
            Controls.Add(lControl);
            lControl.Hide();
            //Se agrega el Game, pero se oculta esperando el evento click
            Controls.Add(gControl);
            gControl.Hide();
            //Add para MainControl
            Controls.Add(mControl);

            mControl.OnClickButtonPlay += OnClickToMainControl;
            lControl.OnClickButtonLogin += OnClickToLoginControl;
        }
        private void OnClickToMainControl(object sender, EventArgs e)
        {
            mControl.Hide();
            lControl.Show();

        }
        private void OnClickToLoginControl(object sender, EventArgs e)
        {
            lControl.Hide();
            gControl.Show();

        }


    }
}
