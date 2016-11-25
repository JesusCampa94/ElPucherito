
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


/*PROTECTED REGION ID(usingGgesGenNHibernate.CEN.Gges_Usuario_nickPorEmail) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace GgesGenNHibernate.CEN.Gges
{
public partial class UsuarioCEN
{
public GgesGenNHibernate.EN.Gges.UsuarioEN NickPorEmail (string p_email)
{
        /*PROTECTED REGION ID(GgesGenNHibernate.CEN.Gges_Usuario_nickPorEmail_customized) START*/

        return _IUsuarioCAD.NickPorEmail (p_email);
        /*PROTECTED REGION END*/
}
}
}
