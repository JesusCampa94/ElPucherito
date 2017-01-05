using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.EN.Gges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGGES.Controllers
{
    public class EventoController : BasicController
    {
        // GET: Evento
        public ActionResult Index()
        {
            SessionInitialize();
            EventoCAD cad = new EventoCAD(session);

            IList<EventoEN> lista = cad.ReadAllDefault(0, 10).ToList();

            SessionClose();
            return View(lista);
        }

        // GET: Evento/Details/5
        public ActionResult Details(int id)
        {
            EventoCAD cad = new EventoCAD();
            EventoEN Evento = cad.ReadOIDDefault(id);

            return View(Evento);
        }

        // GET: Evento/Create
        public ActionResult Create()
        {
            EventoEN Evento = new EventoEN();

            return View(Evento);
        }

        // POST: Evento/Create
        [HttpPost]
        public ActionResult Create(EventoEN Evento)
        {
            try
            {
                EventoCAD cad = new EventoCAD();

                Evento.FechaCrea = System.DateTime.Now;

                cad.CrearEvento(Evento);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evento/Edit/5
        public ActionResult Edit(int id)
        {
            EventoCAD cad = new EventoCAD();
            EventoEN Evento = cad.ReadOIDDefault(id);

            return View(Evento);
        }

        // POST: Evento/Edit/5
        [HttpPost]
        public ActionResult Edit(EventoEN Evento)
        {
            try
            {
                EventoCAD cad = new EventoCAD();
                cad.CambiarEvento(Evento);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evento/Delete/5
        public ActionResult Delete(int id)
        {
            EventoCAD cad = new EventoCAD();
            EventoEN Evento = cad.ReadOIDDefault(id);

            return View(Evento);
        }

        // POST: Evento/Delete/5
        [HttpPost]
        public ActionResult Delete(EventoEN Evento)
        {
            try
            {
                PublicacionCAD cad = new PublicacionCAD();
                cad.BorrarPublicacion(Evento.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
