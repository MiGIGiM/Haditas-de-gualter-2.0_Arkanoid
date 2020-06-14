using System;
using System.Windows.Forms;
using ProyectoArkanoid.Controladores;

namespace ProyectoArkanoid.Vista
{
    public partial class LoginControl : UserControl
    {
        public delegate void EventLoginControl(object sender, EventArgs e);
        public EventLoginControl OnClickButtonLogin;
        private User u;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (tb_usuarios.Text.Equals(""))
            {
                MessageBox.Show("No has ingresado tu nickname");
            }
            else
            {
                try
                {
                    var dt = ConnectionDB.ExecuteQuery("SELECT * FROM PLAYER" +
                        $" WHERE nickname = '{tb_usuarios.Text}'");

                    if (dt.Rows.Count > 0)
                    {
                        var dataUsuario = dt.Rows[0];

                        u = new User(dataUsuario[0].ToString());

                        MessageBox.Show("Bienvenido " + u.nickname, "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ConnectionDB.ExecutenonQuery($"INSERT INTO PLAYER(nickname) VALUES('{tb_usuarios.Text}')");
                    }

                    OnClickButtonLogin?.Invoke(this, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }                
            }
        }
    }
}
