using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.EN.Gges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGGES.Controllers
{
    public class EntrevistaController : BasicController
    {
        // GET: Entrevista
        public ActionResult Index()
        {
            SessionInitialize();
            EntrevistaCAD cad = new EntrevistaCAD(session);

            IList<EntrevistaEN> lista = cad.ReadAllDefault(0, 10).ToList();

            SessionClose();
            return View(lista);
        }

        // GET: Entrevista/Details/5
        public ActionResult Details(int id)
        {
            EntrevistaCAD cad = new EntrevistaCAD();
            EntrevistaEN Entrevista = cad.ReadOIDDefault(id);

            return View(Entrevista);
        }

        // GET: Entrevista/Create
        public ActionResult Create()
        {
            EntrevistaEN Entrevista = new EntrevistaEN();

            return View(Entrevista);
        }

        // POST: Entrevista/Create
        [HttpPost]
        public ActionResult Create(EntrevistaEN Entrevista)
        {
            try
            {
                EntrevistaCAD cad = new EntrevistaCAD();

                Entrevista.FechaCrea = System.DateTime.Now;

                cad.CrearEntrevista(Entrevista);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Entrevista/Edit/5
        public ActionResult Edit(int id)
        {
            EntrevistaCAD cad = new EntrevistaCAD();
            EntrevistaEN Entrevista = cad.ReadOIDDefault(id);

            return View(Entrevista);
        }

        // POST: Entrevista/Edit/5
        [HttpPost]
        public ActionResult Edit(EntrevistaEN Entrevista)
        {
            try
            {
                EntrevistaCAD cad = new EntrevistaCAD();
                cad.CambiarEntrevista(Entrevista);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Entrevista/Delete/5
        public ActionResult Delete(int id)
        {
            EntrevistaCAD cad = new EntrevistaCAD();
            EntrevistaEN Entrevista = cad.ReadOIDDefault(id);

            return View(Entrevista);
        }

        // POST: Entrevista/Delete/5
        [HttpPost]
        public ActionResult Delete(EntrevistaEN Entrevista)
        {
            try
            {
                PublicacionCAD cad = new PublicacionCAD();
                cad.BorrarPublicacion(Entrevista.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
