
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using GgesGenNHibernate.EN.Gges;
using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.CEN.Gges;



/*PROTECTED REGION ID(usingGgesGenNHibernate.CP.Gges_Usuario_hacerAdmin) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace GgesGenNHibernate.CP.Gges
{
public partial class UsuarioCP : BasicCP
{
public void HacerAdmin (string p_oid)
{
        /*PROTECTED REGION ID(GgesGenNHibernate.CP.Gges_Usuario_hacerAdmin) ENABLED START*/

        UsuarioCAD _IUsuarioCAD = null;
        UsuarioCEN usuarioCEN = null;
        UsuarioEN usuarioEN = null;

        AdministradorCAD _IAdministradorCAD = null;
        AdministradorCEN administradorCEN = null;

        try
        {
                SessionInitializeTransaction ();
                _IUsuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new UsuarioCEN (_IUsuarioCAD);
                usuarioEN = _IUsuarioCAD.ReadOIDDefault (p_oid);

                //si ha encontrado al usuario cuyo oid es el pasado por parametro
                if (usuarioEN != null) {
                        //ahora creamos un administrador a partir del usuario elegido
                        _IAdministradorCAD = new AdministradorCAD (session);
                        administradorCEN = new AdministradorCEN (_IAdministradorCAD);

                        UsuarioEN copia = usuarioEN;

                        usuarioCEN.BorrarUsuario (usuarioEN.Nick);
                        administradorCEN.CrearAdministrador (copia.Nick, copia.Pass, copia.Nombre, copia.Apellidos, copia.Correo, copia.FechaNa, copia.Sexo, copia.Pais, copia.Provincia, copia.Imagen, copia.Baneado);

                        Console.WriteLine ("El usuario ya es un administrador");
                }
                //si no lo encuentra se lo comunica al usuario
                else
                        Console.WriteLine ("El usuario elegido no existe en nuestra base de datos");



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
