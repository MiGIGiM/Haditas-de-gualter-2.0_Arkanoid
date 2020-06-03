using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoArkanoid.Controladores
{
    public static class TopTenController
    {
        // Metodo que devuelve en forma de tabla el puntaje de usuario
        public static DataTable GetScoreTable()
        {
            DataTable tableScore = null;

            try
            {
                // Consulta para obtener los primeros 10 puntajes 
                tableScore = ConnectionDB.ExecuteQuery("SELECT * " +
                    "FROM SCORE " +
                    "ORDER BY score DESC " +
                    "FETCH FIRST 10 ROWS ONLY ");
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return tableScore;
        }
    }
}
