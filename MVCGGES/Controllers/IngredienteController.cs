using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.EN.Gges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGGES.Controllers
{
    public class IngredienteController : BasicController
    {
        // GET: Ingrediente
        public ActionResult Index()
        {
            SessionInitialize();
            IngredientesCAD cad = new IngredientesCAD(session);

            IList<IngredientesEN> lista = cad.ReadAllDefault(0, -1).ToList();
            session.Close();
            return View(lista);
        }

        // GET: Ingrediente/Details/5
        public ActionResult Details(int id)
        {
            IngredientesCAD cad = new IngredientesCAD();
            IngredientesEN en = cad.ReadOIDDefault(id);
            return View(en);
        }

        // GET: Ingrediente/Create
        public ActionResult Create()
        {

            IngredientesEN en = new IngredientesEN();

            return View(en);
        }

        // POST: Ingrediente/Create
        [HttpPost]
        public ActionResult Create(IngredientesEN en)
        {
            try
            {
                IngredientesCAD cad = new IngredientesCAD();
                cad.CrearIngrediente(en);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ingrediente/Edit/5
        public ActionResult Edit(int id)
        {
            IngredientesCAD cad = new IngredientesCAD();
            IngredientesEN en = cad.ReadOIDDefault(id);
            return View(en);
        }

        // POST: Ingrediente/Edit/5
        [HttpPost]
        public ActionResult Edit(IngredientesEN en)
        {
            try
            {
                IngredientesCAD cad = new IngredientesCAD();
                cad.ModificarIngrediente(en);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ingrediente/Delete/5
        public ActionResult Delete(int id)
        {
            IngredientesCAD cad = new IngredientesCAD();
            IngredientesEN en = cad.ReadOIDDefault(id);
            return View(en);
        }

        // POST: Ingrediente/Delete/5
        [HttpPost]
        public ActionResult Delete(IngredientesEN en)
        {
            try
            {
                IngredientesCAD cad = new IngredientesCAD();
                cad.BorrarIngrediente(en.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
