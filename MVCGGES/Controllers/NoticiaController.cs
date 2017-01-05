using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.EN.Gges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGGES.Controllers
{
    public class NoticiaController : BasicController
    {
        // GET: Noticia
        public ActionResult Index()
        {
            SessionInitialize();
            NoticiaCAD cad = new NoticiaCAD(session);

            IList<NoticiaEN> lista = cad.ReadAllDefault(0, 10).ToList();

            SessionClose();
            return View(lista);
        }

        // GET: Noticia/Details/5
        public ActionResult Details(int id)
        {
            NoticiaCAD cad = new NoticiaCAD();
            NoticiaEN noticia = cad.ReadOIDDefault(id);

            return View(noticia);
        }

        // GET: Noticia/Create
        public ActionResult Create()
        {
            NoticiaEN noticia = new NoticiaEN();

            return View(noticia);
        }

        // POST: Noticia/Create
        [HttpPost]
        public ActionResult Create(NoticiaEN noticia)
        {
            try
            {
                NoticiaCAD cad = new NoticiaCAD();

                noticia.FechaCrea = System.DateTime.Now;

                cad.CrearNoticia(noticia);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Noticia/Edit/5
        public ActionResult Edit(int id)
        {
            NoticiaCAD cad = new NoticiaCAD();
            NoticiaEN Noticia = cad.ReadOIDDefault(id);

            return View(Noticia);
        }

        // POST: Noticia/Edit/5
        [HttpPost]
        public ActionResult Edit(NoticiaEN noticia)
        {
            try
            {
                PublicacionCAD cad = new PublicacionCAD();
                cad.CambiarPublicacion(noticia);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Noticia/Delete/5
        public ActionResult Delete(int id)
        {
            NoticiaCAD cad = new NoticiaCAD();
            NoticiaEN noticia = cad.ReadOIDDefault(id);

            return View(noticia);
        }

        // POST: Noticia/Delete/5
        [HttpPost]
        public ActionResult Delete(NoticiaEN noticia)
        {
            try
            {
                PublicacionCAD cad = new PublicacionCAD();
                cad.BorrarPublicacion(noticia.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
