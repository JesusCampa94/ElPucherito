
using System;
using GgesGenNHibernate.EN.Gges;

namespace GgesGenNHibernate.CAD.Gges
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (int id
                             );

void ModifyDefault (ComentarioEN comentario);



int CrearComentario (ComentarioEN comentario);

void ModificarComentario (ComentarioEN comentario);


void BorrarComentario (int id
                       );
}
}
