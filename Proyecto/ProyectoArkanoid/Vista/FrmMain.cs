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
        private UserControl current;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            current = new MainControl();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current, 0, 0);
           tableLayoutPanel1.SetRowSpan(current, 2);
            tableLayoutPanel1.SetColumnSpan(current, 2);
        }

       
    }
}
