using System.Collections.Generic;

namespace HoliDayRental.Common.Repositories
{
    public interface IGetRepository<TMembre, TId>
    {
        TMembre Get(TId id);
        IEnumerable<TMembre> Get();
    }
}