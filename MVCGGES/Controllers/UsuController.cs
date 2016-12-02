using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.CEN.Gges;
using GgesGenNHibernate.EN.Gges;
using MVCGGES.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGGES.Controllers
{
    public class UsuController : BasicController
    {
        // GET: Usu
        public ActionResult Index()
        {
            UsuarioCAD cad = new UsuarioCAD();
            UsuarioCEN cen = new UsuarioCEN();

            SessionInitialize();

            IList<UsuarioEN> lista = cad;

            return View();
        }

        // GET: Usu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usu/Create
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

        // GET: Usu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usu/Edit/5
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

        // GET: Usu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usu/Delete/5
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
