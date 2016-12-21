
using System;
using GgesGenNHibernate.EN.Gges;

namespace GgesGenNHibernate.CAD.Gges
{
public partial interface IEntrevistaCAD
{
EntrevistaEN ReadOIDDefault (int id
                             );

void ModifyDefault (EntrevistaEN entrevista);



int CrearEntrevista (EntrevistaEN entrevista);

void CambiarEntrevista (EntrevistaEN entrevista);


System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.EntrevistaEN> EntrevistasOrdenInverso ();
}
}
