using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Entities
{
    public class MembreBienEchangeB
    {
        public MembreB Membre { get; set; }
        public BienEchangeB BienEchange { get; set; }
        public int IdMembre { get; set; }
        public int IdBien { get; set; }
        public DateTime DateDebEchange { get; set; }
        public DateTime DateFinEchange { get; set; }
        public bool Assurance { get; set; }
        public bool Valide { get; set; }

        public MembreBienEchangeB(DateTime dateDebEchange, DateTime dateFinEchange, bool assurance, bool valide, MembreB membre, BienEchangeB bienEchange)
        {
            Membre = membre;
            if (membre == null) throw new ArgumentNullException(nameof(IdMembre));
            BienEchange = bienEchange;
            if (bienEchange == null) throw new ArgumentNullException(nameof(IdBien));
            DateDebEchange = dateDebEchange;
            DateFinEchange = dateFinEchange;
            Assurance = assurance;
            Valide = valide;
         
        }

        public MembreBienEchangeB(DateTime dateDebEchange, DateTime dateFinEchange, bool assurance, bool valide, int idMembre, int idBien)
        {
            IdMembre = idMembre;
            IdBien = idBien;
            DateDebEchange = dateDebEchange;
            DateFinEchange = dateFinEchange;
            Membre = null;
            BienEchange = null;
        }
    }
}
