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
    public class MembreBienEchangeService : IMembreBienEchangeRepository<MembreBienEchangeB>
    {
        private readonly IMembreBienEchangeRepository<MembreBienEchangeD> _membreBienEchangeRepository;
        private readonly IMembreRepository<MembreD> _membreRepository;
        private readonly IBienEchangeRepository<BienEchangeD> _bienEchangeRepository;
    
        public MembreBienEchangeService(
            IMembreBienEchangeRepository<MembreBienEchangeD> membreBienEchangeRepository,
            IMembreRepository<MembreD> membreRepository,
            IBienEchangeRepository<BienEchangeD> bienEchangeRepository)
        {
            _membreBienEchangeRepository = membreBienEchangeRepository;
            _membreRepository = membreRepository;
            _bienEchangeRepository = bienEchangeRepository;
        }
        // Crud : 
        public void Delete(int id) // id aka idMembre et idBien
        {
            _membreBienEchangeRepository.Delete(id);
        }

        public IEnumerable<MembreBienEchangeB> Get(DateTime date)
        {
            return _membreBienEchangeRepository.Get().Select(d =>       //Pourquoi pas Get(date) ???
            {
                MembreBienEchangeB result = d.ToBLL();
                result.Membre = _membreRepository.Get(result.IdMembre).ToBLL();
                result.BienEchange = _bienEchangeRepository.Get(result.IdBien).ToBLL();
                return result;
            });
        }

        public MembreBienEchangeB Get(int id)
        {
            MembreBienEchangeB result = _membreBienEchangeRepository.Get(id).ToBLL();
            result.Membre = _membreRepository.Get(result.IdMembre).ToBLL();
            result.BienEchange = _bienEchangeRepository.Get(result.IdBien).ToBLL();
            return result;
        }

        public IEnumerable<MembreBienEchangeB> Get()
        {
            return _membreBienEchangeRepository.Get().Select(d =>
            {
                MembreBienEchangeB result = d.ToBLL();
                result.Membre = _membreRepository.Get(result.IdMembre).ToBLL();
                result.BienEchange = _bienEchangeRepository.Get(result.IdBien).ToBLL();
                return result;
            });
        }

        //public IEnumerable<MembreBienEchangeB> GetByIdMembre(int idMembre)
        //{
        //    return _membreBienEchangeRepository.GetByIdMembre(idMembre).Select(d =>
        //    {
        //        MembreBienEchangeB result = d.ToBLL();
        //        result.Membre = _membreRepository.Get(result.IdMembre).ToBLL();
        //        result.BienEchange = _bienEchangeRepository.Get(result.IdBien).ToBLL();
        //        return result;
        //    });
        //}

        //public IEnumerable<MembreBienEchangeB> GetByIdBien(int idBien)
        //{
        //    return _membreBienEchangeRepository.GetByIdBien(idBien).Select(d =>
        //    {
        //        MembreBienEchangeB result = d.ToBLL();
        //        result.Membre = _membreRepository.Get(result.IdMembre).ToBLL();
        //        result.BienEchange = _bienEchangeRepository.Get(result.IdBien).ToBLL();
        //        return result;
        //    });
        //}

        public int Insert(MembreBienEchangeB entity)
        {
            return _membreBienEchangeRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, MembreBienEchangeB entity)
        {
            _membreBienEchangeRepository.Update(id, entity.ToDAL());
        }
    }    
}
