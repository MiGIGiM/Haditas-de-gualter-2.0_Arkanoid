using System;
using System.Windows.Forms;
using ProyectoArkanoid.Controladores;

namespace ProyectoArkanoid.Vista
{
    public partial class LoginControl : UserControl
    {
        public delegate void EventLoginControl(object sender, EventArgs e);
        public EventLoginControl OnClickButtonLogin;
        private User currentPlayer;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tb_usuarios.Text)
                {
                    case string aux when aux.Trim().Length == 0:
                        throw new EmptyNicknameException("No has ingresado un nickname");
                    case string aux when aux.Length > 15:
                        throw new ExceededMaxCharacterException("No se puede introducir un nickname mayor a 15 caracteres");
                    default:
                        // Si el usuario ya existe en la base, solo se muestra su nuevo, si no existe, entonces se agrega a la base de datos
                        var dt = ConnectionDB.ExecuteQuery("SELECT * FROM PLAYER" +
                       $" WHERE nickname = '{tb_usuarios.Text}'");

                        if (dt.Rows.Count > 0)
                        {
                            var dataUsuario = dt.Rows[0];

                            currentPlayer = new User(dataUsuario[0].ToString());

                            MessageBox.Show("Bienvenido " + currentPlayer.nickname, "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            ConnectionDB.ExecutenonQuery($"INSERT INTO PLAYER(nickname) VALUES('{tb_usuarios.Text}')");

                        OnClickButtonLogin?.Invoke(this, e);

                        GameData.newPlayer.nickname = tb_usuarios.Text;

                        break;
                }
            }
            catch (EmptyNicknameException ex)
            {
                MessageBox.Show(ex.Message, "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ExceededMaxCharacterException ex2)
            {
                MessageBox.Show(ex2.Message, "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex3)
            {
                MessageBox.Show("Ha ocurrido un error", "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
