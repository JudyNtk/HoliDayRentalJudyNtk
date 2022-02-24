namespace HoliDayRental.Common.Repositories
{
    public interface IRepository<TMembre, TId> : IGetRepository<TMembre, TId>
    {
        TId Insert(TMembre entity);

        void Delete(TId id);

        void Update(TId id, TMembre entity);
    }
}