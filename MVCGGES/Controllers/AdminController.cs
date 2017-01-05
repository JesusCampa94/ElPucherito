using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.EN.Gges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGGES.Controllers
{
    public class AdminController : BasicController
    {
        // GET: Admin
        public ActionResult Index()
        {
            SessionInitialize();
            AdministradorCAD admin = new AdministradorCAD(session);
            IList<AdministradorEN> lista = admin.ReadAllDefault(0, -1).ToList();
            session.Close();

            return View(lista);
        }

        // GET: Admin/Details/5
        public ActionResult Details(String id)
        {
            AdministradorCAD cad = new AdministradorCAD();
            AdministradorEN en = cad.ReadOIDDefault(id);

            return View(en);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            AdministradorEN en = new AdministradorEN();
            en.Sexo = 0;
            return View(en);
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(AdministradorEN en)
        {
            try
            {
                AdministradorCAD cad = new AdministradorCAD();
                en.Baneado = false;
                cad.CrearAdministrador(en);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(String id)
        {
            AdministradorCAD cad = new AdministradorCAD();
            AdministradorEN en = cad.ReadOIDDefault(id);

            return View(en);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(AdministradorEN en)
        {
            try
            {
                AdministradorCAD cad = new AdministradorCAD();
                cad.ModificarAdmin(en);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(String id)
        {
            AdministradorCAD cad = new AdministradorCAD();
            AdministradorEN en = cad.ReadOIDDefault(id);

            return View(en);
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(AdministradorEN en)
        {
            try
            {

                AdministradorCAD cad = new AdministradorCAD();
                cad.BorrarAdmin(en.Nick);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
