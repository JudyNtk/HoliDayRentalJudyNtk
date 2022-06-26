using System.Collections.Generic;

namespace HoliDayRental.Common.Repositories
{
    public interface IBienEchangeRepository<TBienEchange> : IRepository<TBienEchange, int> 
    {
        IEnumerable<TBienEchange> CinqDernierBiens();
    }
}