
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using GgesGenNHibernate.Exceptions;
using GgesGenNHibernate.EN.Gges;
using GgesGenNHibernate.CAD.Gges;


/*PROTECTED REGION ID(usingGgesGenNHibernate.CEN.Gges_Comentario_darLikes) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace GgesGenNHibernate.CEN.Gges
{
public partial class ComentarioCEN
{
public void DarLikes (int p_oid)
{
        /*PROTECTED REGION ID(GgesGenNHibernate.CEN.Gges_Comentario_darLikes) ENABLED START*/

        ComentarioCAD comentarioCAD = new ComentarioCAD ();
        ComentarioEN comentarioEN = null;

        //obtenemos la publicacion con el oid pasado por parametro
        comentarioEN = _IComentarioCAD.ReadOIDDefault (p_oid);

        //subimos un like a la publicacion
        comentarioEN.Likes = comentarioEN.Likes + 1;

        comentarioCAD.ModificarComentario (comentarioEN);


        /*PROTECTED REGION END*/
}
}
}
