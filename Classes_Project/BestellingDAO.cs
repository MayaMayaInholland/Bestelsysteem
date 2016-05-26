using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes_Project
{
    class BestellingDAO
    {
        SqlConnection conn;

        public BestellingDAO()
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
        }

        //1. Haal bestellingen  op => ID
        //Bestellingen worden bij een 'bezette' tafel opgehaald.
        public Bestelling GetByTafelId(int tafel_id)
        {
            //De aangeklikte tafel geeft de tafel_id mee.
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Bestelling WHERE tafel_id = {0} ", tafel_id), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //List waarin de al bestelde producten in komen.
            List<Product> bestellingen = new List<Product>();

            while (reader.Read())
            {
                int Id = (int)reader["id"];
                int Tafel_id = (int)reader["tafel_id"];
                int Medewerker_id = (int)reader["medewerker_id"];
                int Tijd = (int)reader["tijd"];
                int totaalbedrag = (int)reader["totaalbedrag"];
                string opmerkingen = (string)reader["opmerkingen"];
                BestellingStatus status = (BestellingStatus)reader["status"]; 
                int fooi = (int)reader["fooi"];

                //Roept GetByBestellingeId aan --> zie hieronder.
                bestellingen = GetByBestellingId(Id);

                //Overload van class bestelling voor al bestaande bestellingen.... ( opgezet zodat code runt )
                Bestelling bestelling = new  Bestelling(Tafel_id, bestellingen);

                return bestelling;
            }
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
                int id = (int)reader["id"];
                int categorie_id = (int)reader["categorie_id"];
                string omschrijving = (string)reader["omschrijving"];
                int prijs = (int)reader["prijs"];
                int voorraad = (int)reader["voorraad"];
                int btw = (int)reader["btw"];

                Product = new Product(id, categorie_id, prijs, voorraad, btw);

                Besteld_producten.Add(Product); // Toevoegen product aan Besteld_product list.
            }

            return Besteld_producten;

        }

    }
}
