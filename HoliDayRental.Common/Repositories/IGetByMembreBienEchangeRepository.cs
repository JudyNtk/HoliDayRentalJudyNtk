using System;
using System.Collections.Generic;
using System.Text;


namespace HoliDayRental.Common.Repositories
{

    public interface IGetByMembreBienEchangeRepository<TMembre>
    {
        public TMembre GetByMembreBienEchangeId(int membrebienechangeId);
    }
}