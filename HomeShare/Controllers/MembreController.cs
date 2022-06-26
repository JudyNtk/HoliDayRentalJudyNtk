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
    public class MembreController : Controller
    {
        private readonly IMembreRepository<MembreB> _membreService;


        public MembreController(IMembreRepository<MembreB> MembreService)
        {
            _membreService = MembreService;
        }
        
        public IActionResult Index()
        {
            return RedirectToAction("Membres");
        }

        public IActionResult Membres()
        {
            try
            {
                IEnumerable<MembreListItem> model = _membreService.Get().Select(c => c.ToListItem());
                return View(model);
            }
            catch (Exception e)
            {
                return Json(e);
            }
        }
        public ActionResult Details(int id)
        {
            MembreDetails model = _membreService.Get(id).ToDetails();
            return View(model);
        }

        //public IActionResult Create()
        //{
        //        MembreCreationFormulaire model = _membreService;
        //        return View(model);
        //}
        
        public IActionResult Create()
        {
            MembreCreationFormulaire model = new MembreCreationFormulaire();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(MembreCreationFormulaire collection)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();
                if (!collection.CheckCondition) throw new ArgumentException("Veuillez accepter les conditions");
                MembreB result = new MembreB(
                    0,
                    collection.Nom,
                    collection.Prenom,
                    collection.Email,
                    collection.Pays,
                    collection.Telephone,
                    collection.Login,
                    collection.Password
                );
                result.IdMembre = this._membreService.Insert(result);
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
            MembreEdit model = this._membreService.Get(id).ToEdit();
            return View();
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MembreEdit collection)
        {
            MembreB result = this._membreService.Get(id);
            try
            {
                if (result is null) throw new Exception("Identifiant non reconnu");
                if (!(ModelState.IsValid)) throw new Exception();
                result.Nom = collection.Nom;
                result.Prenom = collection.Prenom;
                result.Email = collection.Email;
                result.Pays = collection.Pays;
                result.Telephone = collection.Telephone;
                result.Login = collection.Login;
                if (collection.Password is not null) result.Password = collection.Password;
                this._membreService.Update(id, result);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                if (result is null) return RedirectToAction(nameof(Index));
                return View(result.ToEdit());
            }
        }

        public ActionResult Delete(int id)
        {
            MembreDelete model = this._membreService.Get(id).ToDelete();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MembreDelete collection)
        {
            MembreB result = this._membreService.Get(id);
            try
            {
                if (result is null) throw new Exception("Identifiant non reconnu");
                if (!ModelState.IsValid) throw new Exception();
                //if (!collection.Validate) throw new Exception("Action invalide");
                this._membreService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return RedirectToAction(nameof(Index));
            }
        }
       





        //public IActionResult Create()
        //{
        //    return View();
        //}



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(MembreCreationFormulaire collection)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid) throw new Exception();
        //        MembreB result = new MembreB(
        //        0, 
        //        collection.Nom,
        //        collection.Prenom, 
        //        collection.Email, 
        //        collection.Pays, 
        //        collection.Telephone, 
        //        collection.Login, 
        //        collection.Password

        //        ); ;
        //        this._membreService.Insert(result);
        //        return View("Confirmation");
        //    }
        //    catch (Exception e)
        //    {
        //        ViewBag.Error = e.Message;
        //        return View(collection);
        //    }
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, MembreDetails collection)
        //{
        //    HoliDayRental.BLL.Entities.MembreB result = _serviceMembre.Get(id);
        //    try
        //    {
        //        if (result is null) throw new Exception("Pas de membre avec cet identifiant.");
        //        if (!ModelState.IsValid) throw new Exception();
        //        if (!collection.isValid) throw new Exception("Il faut valider le formulair!");

        //        this._serviceM.Delete(id);
        //        return RedirectToAction(nameof(Index), "Home");
        //    }
        //    catch (Exception e)
        //    {
        //        ViewBag.Error = e.Message;
        //        return RedirectToAction(nameof(Index), "Home");
        //    }
        //}



        //public ActionResult Details(int id)
        //{
        //    MembreDetails model = _membreService.Get(id).ToDetails();
        //    return View(model);
        //}
    }
}
