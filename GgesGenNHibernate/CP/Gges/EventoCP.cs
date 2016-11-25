
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
public partial class EventoCP : BasicCP
{
public EventoCP() : base ()
{
}

public EventoCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
