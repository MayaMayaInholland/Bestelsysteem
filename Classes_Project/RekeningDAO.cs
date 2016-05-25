using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Project
{
    class RekeningDAO
    {
        private List<Rekening> rekeningen;
        // dit is allemaal fake!!

        public RekeningDAO(TafelDAO tafeldao, MedewerkerDAO medewerkerDAO)
        {
            rekeningen = new List<Rekening>();
            rekeningen.Add(new Rekening(1, tafeldao.GetForId(1), medewerkerDAO.GetByID(1)));
            rekeningen.Add(new Rekening(2, tafeldao.GetForId(2), medewerkerDAO.GetByID(2)));
            rekeningen.Add(new Rekening(3, tafeldao.GetForId(3), medewerkerDAO.GetByID(3)));
            rekeningen.Add(new Rekening(4, tafeldao.GetForId(4), medewerkerDAO.GetByID(4)));
            rekeningen.Add(new Rekening(5, tafeldao.GetForId(5), medewerkerDAO.GetByID(5)));
            rekeningen.Add(new Rekening(6, tafeldao.GetForId(6), medewerkerDAO.GetByID(6)));
        }

        public List<Rekening> GetAll()
        {
            return rekeningen;
        }
    }
}
