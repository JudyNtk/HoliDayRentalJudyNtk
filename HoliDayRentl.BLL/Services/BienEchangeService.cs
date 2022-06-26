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
    public class BienEchangeService : IBienEchangeRepository<BienEchangeB>
    {
        private readonly IBienEchangeRepository<BienEchangeD> _bienEchangeRepository;
        private readonly IMembreRepository<MembreD> _membreRepository;

        public BienEchangeService(IBienEchangeRepository<BienEchangeD> repository, IMembreRepository<MembreD> membreRepository)
        {
            _bienEchangeRepository = repository;
            _membreRepository = membreRepository;
        }

        // Crud :
        public void Delete(int idBien)
        {
            _bienEchangeRepository.Delete(idBien);
        }

        public BienEchangeB Get(int idBien)
        {
            BienEchangeB result = _bienEchangeRepository.Get(idBien).ToBLL();
            result.Membre = _membreRepository.Get(result.IdMembre).ToBLL();
            return result;
        }

        public IEnumerable<BienEchangeB> Get()
        {
            return _bienEchangeRepository.Get().Select(d =>
            {
                BienEchangeB result = d.ToBLL();
                result.Membre = _membreRepository.Get(result.IdMembre).ToBLL();
                return result;
            });
        }

        public int Insert(BienEchangeB entity)
        {
            return _bienEchangeRepository.Insert(entity.ToDAL());
        }

        public IEnumerable<BienEchangeB> CinqDernierBiens()
        {
            return _bienEchangeRepository.CinqDernierBiens().Select(d =>
            {
                BienEchangeB result = d.ToBLL();
                result.Membre = _membreRepository.Get(result.IdMembre).ToBLL();
                return result;
            });
        }

        public void Update(int idBien, BienEchangeB entity)
        {
            _bienEchangeRepository.Update(idBien, entity.ToDAL());
        }
    }
}
