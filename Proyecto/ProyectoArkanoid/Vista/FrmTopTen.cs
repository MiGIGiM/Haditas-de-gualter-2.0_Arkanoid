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
