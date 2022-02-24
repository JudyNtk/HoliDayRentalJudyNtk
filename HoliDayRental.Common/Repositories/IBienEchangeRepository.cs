using System.Collections.Generic;

namespace HoliDayRental.Common.Repositories
{
    public interface IBienEchangeRepository<TBienEchange> : IRepository<TBienEchange, int> ,
        IGetByBienEchangeRepository<TBienEchange>
    {
        public IEnumerable<TBienEchange> GetByPays(int pays);
    }
}