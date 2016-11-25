
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using GgesGenNHibernate.EN.Gges;
using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.CEN.Gges;



/*PROTECTED REGION ID(usingGgesGenNHibernate.CP.Gges_Administrador_banearUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace GgesGenNHibernate.CP.Gges
{
public partial class AdministradorCP : BasicCP
{
public void BanearUsuario (string usuario)
{
        /*PROTECTED REGION ID(GgesGenNHibernate.CP.Gges_Administrador_banearUsuario) ENABLED START*/

        UsuarioCAD _IUsuarioCAD = null;
        UsuarioCEN usuarioCEN = null;
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();

                _IUsuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new UsuarioCEN (_IUsuarioCAD);
                usuarioEN = _IUsuarioCAD.ReadOIDDefault (usuario);

                if (usuarioEN != null) {
                        if (usuarioEN.Baneado == false) {
                                usuarioCEN.CambiarDatos (usuarioEN.Nick, usuarioEN.Pass, usuarioEN.Nombre, usuarioEN.Apellidos, usuarioEN.Correo, usuarioEN.FechaNa, usuarioEN.Sexo, usuarioEN.Pais, usuarioEN.Provincia, usuarioEN.Imagen, true);
                        }
                        else{
                                usuarioCEN.CambiarDatos (usuarioEN.Nick, usuarioEN.Pass, usuarioEN.Nombre, usuarioEN.Apellidos, usuarioEN.Correo, usuarioEN.FechaNa, usuarioEN.Sexo, usuarioEN.Pais, usuarioEN.Provincia, usuarioEN.Imagen, false);
                        }
                }

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
