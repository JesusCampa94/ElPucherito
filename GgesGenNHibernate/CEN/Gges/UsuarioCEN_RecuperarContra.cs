
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


/*PROTECTED REGION ID(usingGgesGenNHibernate.CEN.Gges_Usuario_recuperarContra) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace GgesGenNHibernate.CEN.Gges
{
public partial class UsuarioCEN
{
public string RecuperarContra (string p_oid, string p_correo)
{
        /*PROTECTED REGION ID(GgesGenNHibernate.CEN.Gges_Usuario_recuperarContra) ENABLED START*/

        string auxiliar = "Usuario no registrado";

        if (p_oid != null && p_correo != null) {
                UsuarioEN usuarioEN = _IUsuarioCAD.ReadOIDDefault (p_oid);
                if (usuarioEN != null) {
                        if (usuarioEN.Correo.Equals (p_correo)) //comprobar que el correo es el correcto
                                auxiliar = usuarioEN.Pass;
                }
        }
        return auxiliar;


        /*PROTECTED REGION END*/
}
}
}
