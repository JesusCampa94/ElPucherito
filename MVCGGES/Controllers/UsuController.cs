using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.CEN.Gges;
using GgesGenNHibernate.EN.Gges;
using MVCGGES.Controllers;
using MVCGGES.Models;
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
           SessionInitialize();

            UsuarioCAD cad = new UsuarioCAD(session);
            IList<UsuarioEN> listaUsuarios = cad.ReadAllDefault(0, -1).ToList();

            SessionClose();

            return View(listaUsuarios);
        }

        // GET: Usu/Details/5
        public ActionResult Details(String nick)
        {
            UsuarioCAD cad = new UsuarioCAD();
            UsuarioEN usuario = cad.ReadOIDDefault(nick);

            return View(usuario);
        }

        // GET: Usu/Create
        public ActionResult Create()
        {
            RegisterViewModel datosRegistro = new RegisterViewModel();
            return View(datosRegistro);
        }

        // POST: Usu/Create
        [HttpPost]
        public ActionResult Create(RegisterViewModel datosRegistro)
        {
            try
            {
                UsuarioCAD cad = new UsuarioCAD();
                UsuarioEN usuario = new UsuarioEN();

                //Creamos el nuevo usuario con los datos obtenidos
                usuario.Nick = datosRegistro.Nick;
                usuario.Pass = datosRegistro.Password;
                usuario.Nombre = datosRegistro.Nombre;
                usuario.Apellidos = datosRegistro.Apellidos;
                usuario.Correo = datosRegistro.Email;
                usuario.Sexo = datosRegistro.Sexo;
                //usuario.Sexo = 0;
                usuario.Pais = datosRegistro.Pais;
                usuario.Provincia = datosRegistro.Provincia;
                usuario.Imagen = datosRegistro.Imagen;

                //Valores por defecto de campos opcionales
                if (datosRegistro.Imagen == "")
                    usuario.Imagen = "imagen.jpg";

                if (datosRegistro.Pais == "")
                    usuario.Pais = "No especificado";

                if (datosRegistro.Provincia == "")
                    usuario.Provincia = "No especificada";
                
                //Valores que no introduce el usuario
                usuario.Baneado = false;

                cad.CrearUsuario(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usu/Edit/5
        public ActionResult Edit(string nick)
        {
            UsuarioCAD cad = new UsuarioCAD();
            UsuarioEN usuario = cad.ReadOIDDefault(nick);

            return View(usuario);
        }

        // POST: Usu/Edit/5
        [HttpPost]
        public ActionResult Edit(UsuarioEN usuario)
        {
            try
            {
                UsuarioCAD cad = new UsuarioCAD();

                //Valores por defecto de campos opcionales
                if (usuario.Imagen == "")
                    usuario.Imagen = "imagen.jpg";

                cad.CambiarDatos(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usu/EditPass/5
        public ActionResult EditPass(string nick)
        {
            ChangePasswordViewModel cambioPass = new ChangePasswordViewModel();

            return View(cambioPass);
        }

        // POST: Usu/EditPass/5
        [HttpPost]
        public ActionResult EditPass(string nick, ChangePasswordViewModel cambioPass)
        {
            try
            {
                UsuarioCAD cad = new UsuarioCAD();
                UsuarioEN usuario = cad.ReadOIDDefault(nick);

                usuario.Pass = cambioPass.NewPassword;
                cad.CambiarDatos(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usu/Delete/5
        public ActionResult Delete(string nick)
        {
            UsuarioCAD cad = new UsuarioCAD();
            UsuarioEN usuario = cad.ReadOIDDefault(nick);

            return View(usuario);
        }

        // POST: Usu/Delete/5
        [HttpPost]
        public ActionResult Delete(UsuarioEN usuario)
        {
            try
            {
                UsuarioCAD cad = new UsuarioCAD();
                cad.BorrarUsuario(usuario.Nick);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
