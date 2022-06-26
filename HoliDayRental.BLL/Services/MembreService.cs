using HoliDayRental.BLL.Handlers;
using HoliDayRental.BLL.Entities;
using HoliDayRental.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HoliDayRental.BLL.Services
{
    public class MembreService : IMembreRepository<Membre>
    {
        private readonly IMembreRepository<DAL.Entities.Membre> _membreRepository;

        public MembreService(IMembreRepository<DAL.Entities.Membre> repository)
        {
            _membreRepository = repository;
        }
        public void Delete(int id)
        {
            _membreRepository.Delete(id);
        }

        public Membre Get(int id)
        {
            return _membreRepository.Get(id).ToBLL();
        }

        public IEnumerable<Membre> Get()
        {
            return _membreRepository.Get().Select(m => m.ToBLL());
        }

        public IEnumerable<Membre> GetByMembreBienEchange(int idBien, DateTime DateDebEchange, DateTime DateFinEchange)
        {
            return _membreRepository.GetByMembreBienEchange(idBien, DateDebEchange, DateFinEchange).Select(m => m.ToBLL());
        }

        public Membre GetByMembreBienEchangeId(int membrebienechangeId)
        {
            return _membreRepository.GetByMembreBienEchangeId(membrebienechangeId).ToBLL();
        }

        public IEnumerable<Membre> GetByBienEchange(int idBien)
        {
            return _membreRepository.GetByBienEchange(idBien).Select(m => m.ToBLL();
        }

        public int Insert(Membre entity)
        {
            return _membreRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Membre entity)
        {
            _membreRepository.Update(id, entity.ToDAL());
        }

        public IEnumerable<Membre> GetByMembreBienEchange(int idBien, int idMembre)
        {
            throw new NotImplementedException();
        }
    }
}