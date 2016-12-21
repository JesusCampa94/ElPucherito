
using System;
using GgesGenNHibernate.EN.Gges;

namespace GgesGenNHibernate.CAD.Gges
{
public partial interface IEventoCAD
{
EventoEN ReadOIDDefault (int id
                         );

void ModifyDefault (EventoEN evento);



int CrearEvento (EventoEN evento);

void CambiarEvento (EventoEN evento);


System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.EventoEN> EventosOrdenInverso ();
}
}
