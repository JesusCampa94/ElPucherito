using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.EN.Gges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGGES.Controllers
{
    public class ComentarioController : BasicController
    {
        // GET: Comentario
        public ActionResult Index()
        {
            SessionInitialize();
            ComentarioCAD cad = new ComentarioCAD(session);

            IList<ComentarioEN> lista = cad.ReadAllDefault(0,-1).ToList();
            session.Close();

            return View(lista);
        }

        // GET: Comentario/Details/5
        public ActionResult Details(int id)
        {
            ComentarioCAD cad = new ComentarioCAD();
            ComentarioEN en = cad.ReadOIDDefault(id);

            return View(en);
        }

        // GET: Comentario/Create
        public ActionResult Create()
        {

            ComentarioEN comentario = new ComentarioEN();



            return View(comentario);
        }

        // POST: Comentario/Create
        [HttpPost]
        public ActionResult Create(ComentarioEN comentario)
        {
            try
            {
                ComentarioCAD cad = new ComentarioCAD();

                comentario.FechaCom = System.DateTime.Now;

                cad.CrearComentario(comentario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comentario/Edit/5
        public ActionResult Edit(int id)
        {
            ComentarioCAD cad = new ComentarioCAD();
            ComentarioEN en = cad.ReadOIDDefault(id);
            return View(en);
        }

        // POST: Comentario/Edit/5
        [HttpPost]
        public ActionResult Edit(ComentarioEN en)
        {
            try
            {
                ComentarioCAD cad = new ComentarioCAD();
                cad.ModificarComentario(en);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comentario/Delete/5
        public ActionResult Delete(int id)
        {
            ComentarioCAD cad = new ComentarioCAD();
            ComentarioEN en = cad.ReadOIDDefault(id);
            return View(en);
        }

        // POST: Comentario/Delete/5
        [HttpPost]
        public ActionResult Delete(ComentarioEN en)
        {
            try
            {
                ComentarioCAD cad = new ComentarioCAD();
                cad.BorrarComentario(en.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
