using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    public class OptionsBienD
    {
        public int IdOption { get; set; }

        public int IdBien { get; set; }

        public string Valeur { get; set; }
    }
}
