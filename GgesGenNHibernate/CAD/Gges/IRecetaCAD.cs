
using System;
using GgesGenNHibernate.EN.Gges;

namespace GgesGenNHibernate.CAD.Gges
{
public partial interface IRecetaCAD
{
RecetaEN ReadOIDDefault (int id
                         );

void ModifyDefault (RecetaEN receta);



int CrearReceta (RecetaEN receta);

void CambiarReceta (RecetaEN receta);


System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.RecetaEN> RecetasOrdenInverso ();
}
}
