using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.EN.Gges;
using MVCGGES.Models;
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
            RegisterViewModel datosRegistro = new RegisterViewModel();
            return View(datosRegistro);
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(RegisterViewModel datosRegistro)
        {
            try
            {
                AdministradorCAD cad = new AdministradorCAD();
                AdministradorEN admin = new AdministradorEN();

                //Creamos el nuevo administrador con los datos obtenidos
                admin.Nick = datosRegistro.Nick;
                admin.Pass = datosRegistro.Password;
                admin.Nombre = datosRegistro.Nombre;
                admin.Apellidos = datosRegistro.Apellidos;
                admin.Correo = datosRegistro.Email;
                admin.FechaNa = datosRegistro.FechaNa;
                admin.Sexo = datosRegistro.Sexo;
                admin.Pais = datosRegistro.Pais;
                admin.Provincia = datosRegistro.Provincia;
                admin.Imagen = datosRegistro.Imagen;

                //Valores por defecto de campos opcionales
                if (datosRegistro.Imagen == "")
                    admin.Imagen = "imagen.jpg";

                if (datosRegistro.Pais == "")
                    admin.Pais = "No especificado";

                if (datosRegistro.Provincia == "")
                    admin.Provincia = "No especificada";

                //Valores que no introduce el admin
                admin.Baneado = false;

                cad.CrearAdministrador(admin);

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
