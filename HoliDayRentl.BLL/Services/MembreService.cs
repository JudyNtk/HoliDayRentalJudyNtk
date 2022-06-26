using HoliDayRental.BLL.Entities;
using HoliDayRental.BLL.Handlers;
using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Services
{
    public class MembreService : IMembreRepository<MembreB>
    {
        private readonly IMembreRepository<MembreD> _membreRepository;

        public MembreService(IMembreRepository<MembreD> repository)
        {
            _membreRepository = repository;
        }

        // Crud (salade tout) :
        public void Delete(int idMembre)
        {
            _membreRepository.Delete(idMembre);
        }

        public MembreB Get(int idMembre)
        {
            return _membreRepository.Get(idMembre).ToBLL();
        }

        public IEnumerable<MembreB> Get()
        {
            return _membreRepository.Get().Select(d =>
            {
                MembreB result = d.ToBLL();
                return result; // return _membreRepository.Get().Select(m => m.ToBLL()); ????
            });
        }

        public int Insert(MembreB entity)
        {
            return _membreRepository.Insert(entity.ToDAL());
        }

        public void Update(int idMembre, MembreB entity)
        {
            _membreRepository.Update(idMembre, entity.ToDAL());
        }
    }
}
