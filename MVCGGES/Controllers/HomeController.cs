using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.EN.Gges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGGES.Controllers
{
    public class HomeController : BasicController
    {
        public ActionResult Index()
        {
            SessionInitialize();
            PublicacionCAD publ = new PublicacionCAD(session);
            IList<PublicacionEN> lista = publ.ReadAllDefault(0, -1).ToList();
            SessionClose();
            return View(lista);
        }

        public ActionResult Preguntas()
        {
            ViewBag.Message = "Comprueba tus dudas con las del resto de usuarios.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Conoce a El Pucherito en profundidad.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "¿Algo que decir? Contacta con El Pucherito.";

            return View();
        }

        public ActionResult Noticias()
        {
            SessionInitialize();
            NoticiaCAD noticia = new NoticiaCAD(session);
            IList<NoticiaEN> lista = noticia.ReadAllDefault(0, -1).ToList();
            SessionClose();
            return View(lista);
        }

        public ActionResult Eventos()
        {
            SessionInitialize();
            EventoCAD evento = new EventoCAD(session);
            IList<EventoEN> lista = evento.ReadAllDefault(0, -1).ToList();
            SessionClose();
            return View(lista);
        }

        public ActionResult Recetas()
        {
            SessionInitialize();
            RecetaCAD receta = new RecetaCAD(session);
            IList<RecetaEN> lista = receta.ReadAllDefault(0, -1).ToList();
            SessionClose();
            return View(lista);
        }

        public ActionResult Entrevistas()
        {
            SessionInitialize();
            EntrevistaCAD ent = new EntrevistaCAD(session);
            IList<EntrevistaEN> lista = ent.ReadAllDefault(0, -1).ToList();
            SessionClose();
            return View(lista);
        }
    }
}