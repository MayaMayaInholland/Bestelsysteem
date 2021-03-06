﻿using System.Collections.Generic;
using System.Data.SqlClient;

namespace Classes_Project
{
    public class MedewerkerDAO
    {
        SqlConnection conn;

        public MedewerkerDAO()
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
        }

        public Medewerker GetByID(int id)
        {
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Medewerker WHERE id = {0} ", id), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string voornaam = (string)reader["voornaam"];
                string achternaam = (string)reader["achternaam"];
                string rol = (string)reader["rol"];
                int pincode = (int)reader["pincode"];

                switch (rol)
                {
                    case "Keuken":
                        Keuken keuken = new Keuken(id, pincode, voornaam, achternaam, MedewerkerRol.Keuken);
                        return keuken;

                    case "Bar":
                        Bar bar = new Bar(id, pincode, voornaam, achternaam, MedewerkerRol.Bar);
                        return bar;

                    case "Bediening":
                        Bediening bediening = new Bediening(id, pincode, voornaam, achternaam, MedewerkerRol.Bediening);
                        return bediening;

                    case "Manager":
                        Manager manager = new Manager(id, pincode, voornaam, achternaam, MedewerkerRol.Manager);
                        return manager;
                }
            }
            return null;
        }
        public List<Medewerker> GetAll()
        {
            List<Medewerker> medewerkers = new List<Medewerker>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Medewerker", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string voornaam = (string)reader["voornaam"];
                string achternaam = (string)reader["achternaam"];
                string rol = (string)reader["rol"];
                int pincode = (int)reader["pincode"];

                switch (rol)
                {
                    case "Keuken":
                        Keuken keuken = new Keuken(id, pincode, voornaam, achternaam, MedewerkerRol.Keuken);
                        medewerkers.Add(keuken);
                        break;

                    case "Bar":
                        Bar bar = new Bar(id, pincode, voornaam, achternaam, MedewerkerRol.Bar);
                        medewerkers.Add(bar);
                        break;

                    case "Bediening":
                        Bediening bediening = new Bediening(id, pincode, voornaam, achternaam, MedewerkerRol.Bediening);
                        medewerkers.Add(bediening);
                        break;

                    case "Manager":
                        Manager manager = new Manager(id, pincode, voornaam, achternaam, MedewerkerRol.Manager);
                        medewerkers.Add(manager);
                        break;
                }

            }
            return medewerkers;
        }

        public Medewerker GetByPincode(string pincode)
        {
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Medewerker WHERE pincode = {0} ", pincode), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string voornaam = (string)reader["voornaam"];
                string achternaam = (string)reader["achternaam"];
                string rol = (string)reader["rol"];
                int id = (int)reader["id"];

                switch (rol)
                {
                    case "Keuken":
                        Keuken keuken = new Keuken(id, int.Parse(pincode), voornaam, achternaam, MedewerkerRol.Keuken);
                        return keuken;

                    case "Bar":
                        Bar bar = new Bar(id, int.Parse(pincode), voornaam, achternaam, MedewerkerRol.Bar);
                        return bar;


                    case "Bediening":
                        Bediening bediening = new Bediening(id, int.Parse(pincode), voornaam, achternaam, MedewerkerRol.Bediening);
                        return bediening;


                    case "Manager":
                        Manager manager = new Manager(id, int.Parse(pincode), voornaam, achternaam, MedewerkerRol.Manager);
                        return manager;
                }
            }
            return null;
        }
    }
}
