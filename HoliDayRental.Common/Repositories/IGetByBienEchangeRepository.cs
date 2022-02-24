namespace HoliDayRental.Common.Repositories
{
    public interface IGetByBienEchangeRepository<TBienEchange>
    {
        public TBienEchange GetByBienEchange(int membrebienechangeId);
    }
}