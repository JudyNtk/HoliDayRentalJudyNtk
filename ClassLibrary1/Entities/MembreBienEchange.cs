using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    class MembreBienEchange
    {
        public int IdMembre { get; set; }

        public int IdBien { get; set; }

        public DateTime DateDebEchange { get; set; }

        public DateTime DateFinEchange { get; set; }

        public bool Assurance { get; set; }

        public bool Valide { get; set; }
    }
}
