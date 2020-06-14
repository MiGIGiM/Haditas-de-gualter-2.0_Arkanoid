using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ProyectoArkanoid.Controladores
{
    class ConnectionDB
    {
        //Cambien a sus crendenciales
        private static string host = "127.0.0.1",
            database = "Project",
            userId = "postgres",
            password = "uca";
        private static string sConnection =
            $"Server={host};Port=5432; User Id={userId}; Password={password}; Database={database}";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            return ds.Tables[0];
        }

        public static void ExecutenonQuery(string act)
        {
            Console.WriteLine(sConnection);
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
