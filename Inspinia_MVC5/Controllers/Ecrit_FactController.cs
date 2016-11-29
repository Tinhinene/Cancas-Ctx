


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

using System.Net;
using System.Web;
using System.Web.Mvc;

using Inspinia_MVC5.Models;
using Inspinia_MVC5.Service;

namespace Inspinia_MVC5.Controllers
{

    public class Ecrit_FactController : Controller
    {
        private CacobatphEntities db = new CacobatphEntities();

        // GET: /Ecrit_Fact/
        Mise_en_demeureAuto Service = new Mise_en_demeureAuto();
        public ActionResult Index()

        {


           var info = Service.CalculeCreance();

            return View(info);

        }

        // GET: /Ecrit_Fact/Details/5

        public ActionResult Details(int? id)

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Ecrit_Fact ecrit_Fact = db.Ecrit_Fact.Find(id);

            if (ecrit_Fact == null)
            {
                return HttpNotFound();
            }
            return View(ecrit_Fact);
        }

        // GET: /Ecrit_Fact/Create
        public ActionResult Create()
        {

            ViewBag.N_Cotisant = new SelectList(db.Cotisants, "Numero", "Rais_Soc_Fr");

            ViewBag.C_Nature = new SelectList(db.Natures, "Code", "Libelle_Fr");

            ViewBag.C_Periode = new SelectList(db.Periodes, "Code", "DAC_Envoye");

            return View();
        }

        // POST: /Ecrit_Fact/Create

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include="N_DAC,N_Encaiss,N_Cotisant,C_Periode,C_Operation,Date_Op,Libelle,C_Nature,Etat,Type_Cotis,Assiette,Taux,Debit,Credit,Nb_Salarie,Solde,Mont_Vent,Code_Usager,Id_Agence")] Ecrit_Fact ecrit_Fact)

        {
            if (ModelState.IsValid)
            {

                db.Ecrit_Fact.Add(ecrit_Fact);

                db.SaveChanges();

                return RedirectToAction("Index");
            }


            ViewBag.N_Cotisant = new SelectList(db.Cotisants, "Numero", "Rais_Soc_Fr", ecrit_Fact.N_Cotisant);

            ViewBag.C_Nature = new SelectList(db.Natures, "Code", "Libelle_Fr", ecrit_Fact.C_Nature);

            ViewBag.C_Periode = new SelectList(db.Periodes, "Code", "DAC_Envoye", ecrit_Fact.C_Periode);

            return View(ecrit_Fact);
        }

        // GET: /Ecrit_Fact/Edit/5

        public ActionResult Edit(int? id)

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Ecrit_Fact ecrit_Fact = db.Ecrit_Fact.Find(id);

            if (ecrit_Fact == null)
            {
                return HttpNotFound();
            }

            ViewBag.N_Cotisant = new SelectList(db.Cotisants, "Numero", "Rais_Soc_Fr", ecrit_Fact.N_Cotisant);

            ViewBag.C_Nature = new SelectList(db.Natures, "Code", "Libelle_Fr", ecrit_Fact.C_Nature);

            ViewBag.C_Periode = new SelectList(db.Periodes, "Code", "DAC_Envoye", ecrit_Fact.C_Periode);

            return View(ecrit_Fact);
        }

        // POST: /Ecrit_Fact/Edit/5

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit([Bind(Include="N_DAC,N_Encaiss,N_Cotisant,C_Periode,C_Operation,Date_Op,Libelle,C_Nature,Etat,Type_Cotis,Assiette,Taux,Debit,Credit,Nb_Salarie,Solde,Mont_Vent,Code_Usager,Id_Agence")] Ecrit_Fact ecrit_Fact)

        {
            if (ModelState.IsValid)
            {
                db.Entry(ecrit_Fact).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.N_Cotisant = new SelectList(db.Cotisants, "Numero", "Rais_Soc_Fr", ecrit_Fact.N_Cotisant);

            ViewBag.C_Nature = new SelectList(db.Natures, "Code", "Libelle_Fr", ecrit_Fact.C_Nature);

            ViewBag.C_Periode = new SelectList(db.Periodes, "Code", "DAC_Envoye", ecrit_Fact.C_Periode);

            return View(ecrit_Fact);
        }

        // GET: /Ecrit_Fact/Delete/5

        public ActionResult Delete(int? id)

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Ecrit_Fact ecrit_Fact = db.Ecrit_Fact.Find(id);

            if (ecrit_Fact == null)
            {
                return HttpNotFound();
            }
            return View(ecrit_Fact);
        }

        // POST: /Ecrit_Fact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)

        {

            Ecrit_Fact ecrit_Fact = db.Ecrit_Fact.Find(id);

            db.Ecrit_Fact.Remove(ecrit_Fact);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
