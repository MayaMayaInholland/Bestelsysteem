using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes_Project
{
    class TafelDAO
    {
        private int Id;
        private int nummer;
        private TafelStatus tafelStatus;

        SqlConnection conn;

        public TafelDAO()
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
        }

        public Tafel GetByTafelNummer(int TafelNummer)
        {
            SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM Tafel WHERE nummer = {0} ", TafelNummer), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                TafelStatus status = (TafelStatus)reader["status"];
                int nummer = (int)reader["nummer"];

                Tafel tafel = new Tafel(id, nummer, status);
                return tafel;
            }

            return null;
        }





    }
}
