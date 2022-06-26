using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    public class AvisMembreBienD
    {
        public int IdAvis { get; set; }

        public int Note { get; set; }

        public string Message { get; set; }

        public int IdMembre { get; set; }

        public int IdBien { get; set; }

        public DateTime DateAvis { get; set; }

        public bool Approuve { get; set; }

    }
}
