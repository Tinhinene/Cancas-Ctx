using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inspinia_MVC5.Service;
using Inspinia_MVC5.Models;

namespace Inspinia_MVC5.Controllers
{
    public class CreanceController : Controller
    {
        private CacobatphEntities db = new CacobatphEntities();
        Mise_en_demeureAuto Service = new Mise_en_demeureAuto();
        public ActionResult Index()

        {


            var info = Service.CalculeCreance();

            return View(info);

        }

        // GET: Creance/Details/5
        public ActionResult Details(string numcotisant)
        {
            ViewBag.cotisant = numcotisant;
            var info = Service.CalculeCreancePeriode(numcotisant);
            var MD = Service.MiseEnDemeure(numcotisant);
            return View(Tuple.Create(info, MD));


        }
        public ActionResult DetailsMD(string numcotisant, int piece)
        {
           
                    ViewBag.cotisant = numcotisant;
                    ViewBag.piece = piece;
                    var info = Service.CalculeCreancePeriode(numcotisant);
                    var MD = Service.MiseEnDemeure(numcotisant);
                    var pc = Service.LignesMD(piece);
                    return View(Tuple.Create(info, MD, pc));

           


        }
         
    // GET: Creance/Create
    public ActionResult Create()
        {
            return View();
        }

        // POST: Creance/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Creance/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Creance/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Creance/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Creance/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
