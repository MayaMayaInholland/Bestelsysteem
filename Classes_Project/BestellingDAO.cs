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

        //------------------------------------------DATA RETRIEVAL________________________________________________________
        //1. Haal bestellingen  op => ID
        //Bestellingen worden bij een 'bezette' tafel opgehaald.
        public Bestelling GetByTafelId(int tafel_id)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            //De aangeklikte tafel geeft de tafel_id mee.
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Bestelling WHERE Bestelling.status = 1 AND tafel_id = {0} ", tafel_id), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //List waarin de al bestelde producten in komen.
            List<Product> lijst_Producten = new List<Product>();

            while (reader.Read())
            {
                int Id = (int)reader["id"];
                int Tafel_id = (int)reader["tafel_id"];
                int Medewerker_id = (int)reader["medewerker_id"];
                DateTime Tijd = (DateTime)reader["tijd"];
                int totaalbedrag = (int)reader["totaalbedrag"];
                //string opmerkingen = (string)reader["opmerkingen"];
                BestellingStatus status = (BestellingStatus)reader["status"];
                float fooi = (float)reader["fooi"];
                string opmerking = (string)reader["opmerking"];

                //Roept GetByBestellingeId aan --> zie hieronder.
                lijst_Producten = GetByBestellingId(Id);

                //Overload van class bestelling voor al bestaande bestellingen.... ( opgezet zodat code runt )
                Bestelling Lopende_bestelling = new Bestelling(lijst_Producten, Medewerker_id, status, Tijd, opmerking);

                return Lopende_bestelling;
            }
            conn.Close();
            return null;
        }

        //2. Haalt list met al bestelde producten op met bestelling_Id
        public List<Product> GetByBestellingId(int Bestelling_Id)
        {

            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Besteld_product INNER JOIN Product ON Besteld_product.product_id = Product.id WHERE Besteld_product.bestelling_id = {0}", Bestelling_Id), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //List dat bestelde producten op vangt.
            //Manier om aantal van producten bij te houden ??
            List<Product> Besteld_producten = new List<Product>();

            // 2a Maken van elk besteld product om in een product object.
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
                string opmerking = (string)reader["opmerking"];

                Product = new Product(id, categorie_id, prijs, voorraad, btw, omschrijving);

                Besteld_producten.Add(Product); // Toevoegen product aan Besteld_product list.
            }

            return Besteld_producten;

        }

        //-------------------------INSERT DATA____________________________________
        //tafel-bestelling kan worden opgenomen...

        public void INSERT_Besteld_producten(Bestelling bestelling)
        {

            int bestelling_id = bestelling.Id;

            //krijgen van de totaalbedrag van het bestelling...

            //for (int i = 0; i < bestelling.Bestelde_producten.Count(); i++)
            //{
            //    totaalbedrag += bestelling.Bestelde_producten[i].Prijs;
            //}

            //Count aantal van geselecteerde producten in bestelling.
            for (int i = 0; i < bestelling.Bestelde_producten.Count(); i++)
            {
                for (int j = 0; j < bestelling.Bestelde_producten.Count(); i++)
                {
                    if (bestelling.Bestelde_producten[i].Id == bestelling.Bestelde_producten[j].Id)
                    {
                        bestelling.Bestelde_producten[i].Aantal++;
                    }

                }
            }

            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            //Maak het SQL command en voer het uit
            for (int i = 0; i <= bestelling.Bestelde_producten.Count(); i++)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Bestelde_producten (bestelling_id, product_id, aantal, opmerking)" +
                "VALUES(@bestelling_id, @product_id, @aantal, @opmerkingen)", conn);

                command.Parameters.AddWithValue("@bestelling_id", bestelling.Id);
                command.Parameters.AddWithValue("@product_id", bestelling.Bestelde_producten[i].Id);
                command.Parameters.AddWithValue("@aantal", bestelling.Bestelde_producten[i].Aantal);
                command.Parameters.AddWithValue("@opmerkingen", bestelling.opmerking);

            }
        }

        //Bestelde Producten verzamelen



    }

}

