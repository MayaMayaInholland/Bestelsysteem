﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes_Project
{
    class TafelDAO
    {

        SqlConnection conn;

        public TafelDAO()
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
        }

        public void SetTafelStatus(Tafel tafel, TafelStatus status)
        {
            SqlCommand cmd = new SqlCommand(String.Format("UPDATE Tafel SET status = {0} WHERE id = {1}", (int)status, tafel.Id), conn);
            cmd.ExecuteNonQuery();
            conn.Close();
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
            conn.Close();
            return null;
        }

        public List<Tafel> GetAllTafels()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tafel", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Tafel> tafels = new List<Tafel>();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                TafelStatus status = (TafelStatus)reader["status"];
                int nummer = (int)reader["nummer"];

                Tafel tafel = new Tafel(id, nummer, status);
                tafels.Add(tafel);

            }
            conn.Close();
            return tafels;
        }

    }
}
