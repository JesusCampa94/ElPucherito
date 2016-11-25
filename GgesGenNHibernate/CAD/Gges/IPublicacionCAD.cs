
using System;
using GgesGenNHibernate.EN.Gges;

namespace GgesGenNHibernate.CAD.Gges
{
public partial interface IPublicacionCAD
{
PublicacionEN ReadOIDDefault (int id
                              );

void ModifyDefault (PublicacionEN publicacion);



int CrearPublicacion (PublicacionEN publicacion);

void CambiarPublicacion (PublicacionEN publicacion);


void BorrarPublicacion (int id
                        );



System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.PublicacionEN> PublicacionesOrdenInverso ();


GgesGenNHibernate.EN.Gges.PublicacionEN PublicacionPorTitulo (string p_titulo);
}
}
