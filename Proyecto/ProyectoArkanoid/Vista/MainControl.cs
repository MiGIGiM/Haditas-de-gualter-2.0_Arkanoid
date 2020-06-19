using System;
using System.Windows.Forms;

namespace ProyectoArkanoid.Vista
{
    public partial class MainControl : UserControl
    { 
        // Conectar el user al frmMain por medio de un evento personalizado
        public delegate void EventMainControl(object sender, EventArgs e);
        public Action hideForm, showForm;
        public EventMainControl OnClickButtonPlay;

        public MainControl()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            OnClickButtonPlay?.Invoke(this, e);
        }

        private void BtnGoOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?",
                "Arkanoid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void BtnLeaderboards_Click(object sender, EventArgs e)
        {
            FrmTopTen ft = new FrmTopTen();

            ft.CloseAction = () =>
            {
                showForm?.Invoke();
            };

            hideForm?.Invoke();
            ft.Show();
        }
    }
}

