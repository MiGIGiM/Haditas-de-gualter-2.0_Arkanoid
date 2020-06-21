using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoArkanoid.Controladores
{
    public static class PlayerController
    {
        // Metodo que devuelve en forma de tabla el puntaje de usuario
        public static DataTable GetScoreTable()
        {
            DataTable tableScore = null;

            try
            {
                // Consulta para obtener los primeros 10 puntajes 
                tableScore = ConnectionDB.ExecuteQuery("SELECT sc.nickname, sc.score " +
                    "FROM SCORE sc " +
                    "ORDER BY sc.score DESC " +
                    "LIMIT 10 ");
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return tableScore;
        }

        public static void CreateNewScore(string nickname, int score)
        {
            ConnectionDB.ExecutenonQuery("INSERT INTO SCORE(nickname, score) VALUES" +
                $"('{nickname}', {score})");
        }
    }
}