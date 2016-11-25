
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
public partial class ComentarioCP : BasicCP
{
public ComentarioCP() : base ()
{
}

public ComentarioCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
