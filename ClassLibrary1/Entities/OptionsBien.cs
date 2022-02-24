using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    class OptionsBien
    {
        public int IdOption { get; set; }

        public int IdBien { get; set; }

        public string Valeur { get; set; }
    }
}
