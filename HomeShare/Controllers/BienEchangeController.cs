using HoliDayRental.ASP.Handlers;
using HoliDayRental.ASP.Models;
using HoliDayRental.BLL.Entities;
using HoliDayRental.Common.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Controllers
{
    public class BienEchangeController : Controller
    {
        private readonly IBienEchangeRepository<BienEchangeB> _bienEchangeService;

        public BienEchangeController(IBienEchangeRepository<BienEchangeB> bienEchangeService)
        {
            _bienEchangeService = bienEchangeService;
        }

        [Route("BienEchange")]

        public IActionResult Index()
        {
            try
            {
                IEnumerable<BienEchangeListItem> model = _bienEchangeService.Get().Select(c => c.ToListItem());
                return View(model);
            }
            catch (Exception e)
            {
                return Json(e);
            }
        }

        public ActionResult Details(int id)
        {
            BienEchangeDetails model = _bienEchangeService.Get(id).ToDetails();
            return View(model);
        }

        public IActionResult Create() // voir mb
        {
            BienEchangeCreation model = new BienEchangeCreation();
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Create(BienEchangeCreation collection)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();
                BienEchangeB result = new BienEchangeB(
                    0,
                    collection.Titre,
                    collection.DescCourte,
                    collection.DescLong,
                    collection.NombrePerson,
                    collection.Pays,
                    collection.Ville,
                    collection.Rue,
                    collection.Numero,
                    collection.CodePostal,
                    collection.Photo,
                    collection.AssuranceObligatoire,
                    collection.Latitude,
                    collection.Longitude,
                    collection.IdMembre
                );
                result.IdBien = this._bienEchangeService.Insert(result);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View(collection);
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            BienEchangeB result = this._bienEchangeService.Get(id);
            try
            {
                if (result is null) throw new Exception("Inconnu au bataillon");
                if (!ModelState.IsValid) throw new Exception();
                //if (!CollectionExtensions.Validate) throw new Exception("Invalide");
                this._bienEchangeService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return RedirectToAction(nameof(Index));
            }


        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}





        //pour tous les controller, si tu as besoin d'un service de la bll, tu devras faire ces manip au niveau du constructeur
  
        //IBienEchangeRepository<BLL.Entities.BienEchangeB> _service;
        //public BienEchangeController( IBienEchangeRepository<BLL.Entities.BienEchangeB> service)
        //{
        //    _service = service;
        //}
        //public IActionResult Index()
            //je dois récupérer Bll.BienEchangeService
        //{
            //BLL.Services.BienEchangeService monservice = new BLL.Services.BienEchangeService(_repository, _membreRepository);
       //     IEnumerable<BLL.Entities.BienEchangeB> mesbiens = _service.Get();
            //mapping vers le model asp
      //      IEnumerable<ASP.Models.BienEchangeDetails> pourlavue = mesbiens.Select(m => m.ToDetails());
     //       return View(pourlavue);
     //   }
        
        
    }


}
