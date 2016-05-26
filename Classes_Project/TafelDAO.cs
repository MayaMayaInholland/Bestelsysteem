<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Project
{
    class TafelDAO
    {
        private List<Tafel> tafels;
        // faked

        public TafelDAO()
        {
            tafels = new List<Tafel>();
            tafels.Add(new Tafel(1, TafelStatus.VRIJ));
            tafels.Add(new Tafel(2, TafelStatus.BEZET));
            tafels.Add(new Tafel(3, TafelStatus.VRIJ));
            tafels.Add(new Tafel(4, TafelStatus.VRIJ));
            tafels.Add(new Tafel(5, TafelStatus.VRIJ));
            tafels.Add(new Tafel(6, TafelStatus.VRIJ));
            tafels.Add(new Tafel(7, TafelStatus.VRIJ));
            tafels.Add(new Tafel(8, TafelStatus.VRIJ));
        }

        public List<Tafel> GetAll()
        {
            return tafels;
        }

        public Tafel GetForId(int id)
        {
            Tafel select = tafels[1];
            foreach (Tafel tafel in tafels)
            {
                if (tafel.Nummer == id)
                    select = tafel ;
            }

            return select;
        }
    }
}
=======
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
>>>>>>> origin/master
