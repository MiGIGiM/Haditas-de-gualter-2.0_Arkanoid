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
    public partial class MainControl : UserControl
    { 
        //conectar el user al frmMain por medio de un evento personalizado
        public delegate void EventMainControl(object sender, EventArgs e);
        public EventMainControl OnClickButtonPlay;
        public MainControl()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
