
using System;
// Definición clase NoticiaEN
namespace GgesGenNHibernate.EN.Gges
{
public partial class NoticiaEN                                                                      : GgesGenNHibernate.EN.Gges.PublicacionEN


{
public NoticiaEN() : base ()
{
}



public NoticiaEN(int id,
                 string titulo, System.Collections.Generic.IList<string> etiquetas, Nullable<DateTime> fechaCrea, string contenido, int likes, int visualizaciones, GgesGenNHibernate.EN.Gges.UsuarioEN usuario, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario
                 )
{
        this.init (Id, titulo, etiquetas, fechaCrea, contenido, likes, visualizaciones, usuario, comentario);
}


public NoticiaEN(NoticiaEN noticia)
{
        this.init (Id, noticia.Titulo, noticia.Etiquetas, noticia.FechaCrea, noticia.Contenido, noticia.Likes, noticia.Visualizaciones, noticia.Usuario, noticia.Comentario);
}

private void init (int id
                   , string titulo, System.Collections.Generic.IList<string> etiquetas, Nullable<DateTime> fechaCrea, string contenido, int likes, int visualizaciones, GgesGenNHibernate.EN.Gges.UsuarioEN usuario, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario)
{
        this.Id = id;


        this.Titulo = titulo;

        this.Etiquetas = etiquetas;

        this.FechaCrea = fechaCrea;

        this.Contenido = contenido;

        this.Likes = likes;

        this.Visualizaciones = visualizaciones;

        this.Usuario = usuario;

        this.Comentario = comentario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NoticiaEN t = obj as NoticiaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
