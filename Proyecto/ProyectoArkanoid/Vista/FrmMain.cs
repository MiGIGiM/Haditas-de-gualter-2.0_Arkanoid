﻿using ProyectoArkanoid.Vista;
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
            // Sirve para que la pantalla se adapte a cualquier resolucion y siempre este maximizada
            //Mcontrol = new MainControl();
            
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
           

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
           
            current = new GameControls(); //se debe cambiar a MainControl despues
             current.Dock = DockStyle.Fill;
             current.Width = Width;
             current.Height = Height;
             tableLayoutPanel1.Controls.Add(current, 0, 0);
             tableLayoutPanel1.SetRowSpan(current, 2);
             tableLayoutPanel1.SetColumnSpan(current, 2);
        }
        


    }
}
