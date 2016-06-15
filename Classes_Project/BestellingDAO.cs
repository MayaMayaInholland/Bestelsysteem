using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace Classes_Project
{
    class BestellingDAO
    {
        SqlConnection conn;

        public BestellingDAO()
        {

        }

        //DATA RETRIEVAL________________________________________________________>-----------------------------------------------

        //Als Tafel bezet is zal de lopende bestelling en lijst met lopende bestellingen opgehaald worden van de database.
        public Bestelling GetLopendeBestellingByTafelID(int tafelID)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            //De aangeklikte tafel geeft de tafel_id mee.
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Bestelling WHERE tafel_id = {0} AND status = 1", tafelID), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //List waarin de al bestelde producten in komen.
            List<Product> lijst_BesteldeProducten = new List<Product>();

            while (reader.Read())
            {
                int Id = (int)reader["id"];
                int Tafel_id = (int)reader["tafel_id"];
                int Medewerker_id = (int)reader["medewerker_id"];
                DateTime Tijd = (DateTime)reader["tijd"];
                int totaalbedrag = (int)reader["totaalbedrag"];
                string opmerkingen = "";
                if (reader["opmerkingen"] != DBNull.Value)
                {
                    opmerkingen = (string)reader["opmerkingen"];
                }

                BestellingStatus status = (BestellingStatus)reader["status"];
                int fooi = (int)reader["fooi"];

                //Roept GetByBestellingeId aan --> zie hieronder.
                lijst_BesteldeProducten = GetProductenByBestellingId(Id);

                //Bestelling Lopende_bestelling = new Bestelling(Id, Tafel_id, Medewerker_id, Tijd, totaalbedrag, opmerkingen, (int)status, fooi, lijst_Producten);
                Bestelling Lopende_bestelling = new Bestelling(Id, tafelID, Medewerker_id, Tijd, status, opmerkingen, lijst_BesteldeProducten);
                return Lopende_bestelling;
            }
            reader.Close();
            conn.Close();
            return null;
        }

        //2. Haalt list met al bestelde producten op met bestelling_Id
        public List<Product> GetProductenByBestellingId(int Bestelling_Id)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Besteld_product INNER JOIN Product ON Besteld_product.product_id = Product.id WHERE Besteld_product.bestelling_id = {0}", Bestelling_Id), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //List dat bestelde producten op vangt.
            List<Product> Besteld_producten = new List<Product>();

            // 2.1 Maken van elk besteld product om in een product object.
            Product Product;

            while (reader.Read())
            {
                int id = (int)reader["id"]; // welke id zal de reader readen ?
                int categorie_id = (int)reader["categorie_id"];
                string omschrijving = (string)reader["omschrijving"];
                int prijs = (int)reader["prijs"]; 
                int voorraad = (int)reader["voorraad"];
                int btw = (int)reader["btw"];
                int bestelling_id = (int)reader["bestelling_id"];
                int product_id = (int)reader["product_id"];
                int aantal = (int)reader["aantal"];
                string opmerking = "";
                if (reader["opmerking"] != DBNull.Value)
                {
                    opmerking = (string)reader["opmerking"];
                }
                ProductStatus status = (ProductStatus)reader["status"];
       
                Product = new Product(id, categorie_id, prijs, btw, omschrijving, aantal, status);
                               
                Besteld_producten.Add(Product); // Toevoegen product aan Besteld_product list.          
            }
            reader.Close();
            return Besteld_producten;
        }

        // DATA INSERT & UPDATE --------------------------------->---------------------------------------->------------------------

        //Veranderd status besteld_product in database van meegegeven lijst bestelde producten.
        //Veranderd de tafel image.
        public void ServeerProducten(List<Product> producten)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
            foreach(Product product in producten)
            {
                SqlCommand cmd = new SqlCommand(String.Format("UPDATE Besteld_product SET status = {0} WHERE id = {1}", (int)ProductStatus.Geserveerd, product.Id), conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }


        //tafel-bestelling wordt naar Database gezet. 
        //Aangeroepen bij btn_bevestig_Click
        public void Nieuwe_bestelling(Bestelling bestelling)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            SqlCommand command = new SqlCommand(string.Format("INSERT INTO Bestelling (tafel_id, medewerker_id, tijd, totaalbedrag, opmerkingen, status, fooi)" +
                "VALUES(@tafel_id, @medewerker_id, @tijd, @totaalbedrag, @opmerkingen, @status, @fooi)"), conn);

            command.Parameters.AddWithValue("@tafel_id", bestelling.Tafel_id);
            command.Parameters.AddWithValue("@medewerker_id", bestelling.Medewerker_id);
            command.Parameters.AddWithValue("@tijd", bestelling.Tijd);
            command.Parameters.AddWithValue("@totaalbedrag", bestelling.Totaalbedrag);
            command.Parameters.AddWithValue("@opmerkingen", bestelling.Opmerking);
            command.Parameters.AddWithValue("@status", bestelling.Status);
            command.Parameters.AddWithValue("@fooi", bestelling.Fooi);


            int rowseffected = command.ExecuteNonQuery();

            //Achterhalen van de automatische incremented Bestelling Id uit Database.
            //Wordt gebruikt voor het toevoegen van Besteld_product.
            if (rowseffected > 0)
            {
                command.CommandText = " SELECT @@Identity";
                bestelling.Id = Convert.ToInt32(command.ExecuteScalar());
            }

            //Toevoegen van producten in bestelde_producten lijst in Database.
            for (int i = 0; i < bestelling.Bestelde_producten.Count(); i++)
            {
                SqlCommand Command = new SqlCommand("INSERT INTO Besteld_product (bestelling_id, product_id, status, aantal, opmerking)" +
                "VALUES(@bestelling_id, @product_id, @status, @aantal, @opmerkingen)", conn);

                Command.Parameters.AddWithValue("@bestelling_id", bestelling.Id);
                Command.Parameters.AddWithValue("@product_id", bestelling.Bestelde_producten[i].Id);
                Command.Parameters.AddWithValue("@status", bestelling.Status);
                Command.Parameters.AddWithValue("@aantal", bestelling.Bestelde_producten[i].Aantal);
                Command.Parameters.AddWithValue("@opmerkingen", bestelling.Bestelde_producten[i].Opmerking);

                Command.ExecuteNonQuery();
            }
            conn.Close();
        }

       
    }

}

