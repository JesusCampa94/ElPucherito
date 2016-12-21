using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.EN.Gges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGGES.Controllers
{
    public class RecetaController : BasicController
    {
        // GET: Receta
        public ActionResult Index()
        {
            SessionInitialize();
            RecetaCAD cad = new RecetaCAD(session);

            IList<RecetaEN> lista = cad.ReadAllDefault(0, 10).ToList();

            SessionClose();
            return View(lista);
        }

        // GET: Receta/Details/5
        public ActionResult Details(int id)
        {

            RecetaCAD cad = new RecetaCAD();
            RecetaEN receta = cad.ReadOIDDefault(id);

            return View(receta);
        }

        // GET: Receta/Create
        public ActionResult Create()
        {
            RecetaEN receta = new RecetaEN();

            return View(receta);
        }

        // POST: Receta/Create
        [HttpPost]
        public ActionResult Create(RecetaEN receta)
        {
            try
            {

                RecetaCAD cad = new RecetaCAD();

                receta.FechaCrea = System.DateTime.Now;

                cad.CrearReceta(receta);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Receta/Edit/5
        public ActionResult Edit(int id)
        {
            RecetaCAD cad = new RecetaCAD();
            RecetaEN receta = cad.ReadOIDDefault(id);

            return View(receta);
        }

        // POST: Receta/Edit/5
        [HttpPost]
        public ActionResult Edit(RecetaEN receta)
        {
            try
            {
                RecetaCAD cad = new RecetaCAD();
                cad.CambiarReceta(receta);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Receta/Delete/5
        public ActionResult Delete(int id)
        {
            RecetaCAD cad = new RecetaCAD();
            RecetaEN receta = cad.ReadOIDDefault(id);
            
            return View(receta);
        }

        // POST: Receta/Delete/5
        [HttpPost]
        public ActionResult Delete(RecetaEN receta)
        {
            try
            {
                PublicacionCAD cad = new PublicacionCAD();
                cad.BorrarPublicacion(receta.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
