

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using GgesGenNHibernate.Exceptions;

using GgesGenNHibernate.EN.Gges;
using GgesGenNHibernate.CAD.Gges;


namespace GgesGenNHibernate.CEN.Gges
{
/*
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int CrearComentario (string p_contenido, Nullable<DateTime> p_fechaCom, int p_publicacion, int p_likes, string p_usuario)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Contenido = p_contenido;

        comentarioEN.FechaCom = p_fechaCom;


        if (p_publicacion != -1) {
                // El argumento p_publicacion -> Property publicacion es oid = false
                // Lista de oids id
                comentarioEN.Publicacion = new GgesGenNHibernate.EN.Gges.PublicacionEN ();
                comentarioEN.Publicacion.Id = p_publicacion;
        }

        comentarioEN.Likes = p_likes;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                comentarioEN.Usuario = new GgesGenNHibernate.EN.Gges.UsuarioEN ();
                comentarioEN.Usuario.Nick = p_usuario;
        }

        //Call to ComentarioCAD

        oid = _IComentarioCAD.CrearComentario (comentarioEN);
        return oid;
}

public void ModificarComentario (int p_Comentario_OID, string p_contenido, Nullable<DateTime> p_fechaCom, int p_likes)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id = p_Comentario_OID;
        comentarioEN.Contenido = p_contenido;
        comentarioEN.FechaCom = p_fechaCom;
        comentarioEN.Likes = p_likes;
        //Call to ComentarioCAD

        _IComentarioCAD.ModificarComentario (comentarioEN);
}

public void BorrarComentario (int id
                              )
{
        _IComentarioCAD.BorrarComentario (id);
}
}
}
