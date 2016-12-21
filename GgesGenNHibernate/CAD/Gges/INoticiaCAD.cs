
using System;
using GgesGenNHibernate.EN.Gges;

namespace GgesGenNHibernate.CAD.Gges
{
public partial interface INoticiaCAD
{
NoticiaEN ReadOIDDefault (int id
                          );

void ModifyDefault (NoticiaEN noticia);



int CrearNoticia (NoticiaEN noticia);

System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.NoticiaEN> NoticiasOrdenInverso ();
}
}
