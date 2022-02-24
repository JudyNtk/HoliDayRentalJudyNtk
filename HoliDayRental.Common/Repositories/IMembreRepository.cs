using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoliDayRental.Common.Repositories;

namespace HoliDayRental.Common.Repositories
{
    public interface IMembreRepository<TMembre> : IRepository<TMembre, int>,
        IGetByMembreBienEchangeRepository<TMembre>
    {
        IEnumerable<TMembre> GetByMembreBienEchange(int idBien, int idMembre);
        IEnumerable<TMembre> GetByBienEchange(int idBien);
    }
}
