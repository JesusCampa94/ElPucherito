
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using GgesGenNHibernate.Exceptions;
using GgesGenNHibernate.EN.Gges;
using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.CEN.Gges;


namespace GgesGenNHibernate.CP.Gges
{
public partial class AdministradorCP : BasicCP
{
public AdministradorCP() : base ()
{
}

public AdministradorCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
