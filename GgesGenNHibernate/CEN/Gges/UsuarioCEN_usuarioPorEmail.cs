
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


/*PROTECTED REGION ID(usingGgesGenNHibernate.CEN.Gges_Usuario_usuarioPorEmail) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace GgesGenNHibernate.CEN.Gges
{
public partial class UsuarioCEN
{
public GgesGenNHibernate.EN.Gges.UsuarioEN UsuarioPorEmail (string p_email)
{
        /*PROTECTED REGION ID(GgesGenNHibernate.CEN.Gges_Usuario_usuarioPorEmail_customized) START*/

        return _IUsuarioCAD.UsuarioPorEmail (p_email);
        /*PROTECTED REGION END*/
}
}
}
