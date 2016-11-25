
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using GgesGenNHibernate.Exceptions;
using GgesGenNHibernate.EN.Gges;
using GgesGenNHibernate.CAD.Gges;


/*PROTECTED REGION ID(usingGgesGenNHibernate.CEN.Gges_Usuario_login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace GgesGenNHibernate.CEN.Gges
{
public partial class UsuarioCEN
{
public bool Login (string usuario, String pass)
{
        /*PROTECTED REGION ID(GgesGenNHibernate.CEN.Gges_Usuario_login) ENABLED START*/

        UsuarioEN usuarioEN = null;
        bool login = false;

        if (usuario != null && pass != null) {
                //si usuario es el email, por lo que el string usuario tiene una @
                if (usuario.IndexOf ("@") != -1) {
                        //devuelve el objeto usuario que tenga ese email, usamos la hql
                        usuarioEN = _IUsuarioCAD.UsuarioPorEmail (usuario);
                }
                //si es el nick
                else{
                        //leemos por oid
                        usuarioEN = _IUsuarioCAD.ReadOIDDefault (usuario);
                }

                if (usuarioEN.Pass == pass)
                        login = true;
        }
        return login;

        /*PROTECTED REGION END*/
}
}
}
