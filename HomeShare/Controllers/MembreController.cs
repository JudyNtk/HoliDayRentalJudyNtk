using HoliDayRental.Common.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Controllers
{
    public class MembreController : Controller
    {
        private readonly IMembreRepository<Membre> _membreService;
        private readonly IMembreBienEchangeRepository<MembreBienEchange> _membreBienEchangeService;
        public MembreController(IMembreRepository<Cinema> membreService,
            IMembreBienEchangeRepository<MembreBienEchange> membreBienEchangeService)
        {
            _membreService = membreService;
            _membreBienEchangeService = membreBienEchangeService;
        }

        public IActionResult Index()
        {
            IEnumerable<MembreListItem> model = _membreService.Get().Select(m => m.ToListItem());
            return View(model);
        }

        public IActionResult Details(int idMembre)
        {
            MembreDetails model = _membreService.Get(idMembre).ToDetails();
            model.Diffusions = _membreBienEchangeService.GetByIdMembre(idMembre).Select(m => m.ToDetails());
            return View(model);
        }
    }

}
