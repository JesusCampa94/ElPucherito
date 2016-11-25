
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
public partial class IngredientesCP : BasicCP
{
public IngredientesCP() : base ()
{
}

public IngredientesCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
