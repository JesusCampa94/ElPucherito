
using System;
// Definición clase EntrevistaEN
namespace GgesGenNHibernate.EN.Gges
{
public partial class EntrevistaEN                                                                   : GgesGenNHibernate.EN.Gges.PublicacionEN


{
/**
 *	Atributo entrevistado
 */
private string entrevistado;






public virtual string Entrevistado {
        get { return entrevistado; } set { entrevistado = value;  }
}





public EntrevistaEN() : base ()
{
}



public EntrevistaEN(int id, string entrevistado
                    , string titulo, System.Collections.Generic.IList<string> etiquetas, Nullable<DateTime> fechaCrea, string contenido, int likes, int visualizaciones, GgesGenNHibernate.EN.Gges.UsuarioEN usuario, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario
                    )
{
        this.init (Id, entrevistado, titulo, etiquetas, fechaCrea, contenido, likes, visualizaciones, usuario, comentario);
}


public EntrevistaEN(EntrevistaEN entrevista)
{
        this.init (Id, entrevista.Entrevistado, entrevista.Titulo, entrevista.Etiquetas, entrevista.FechaCrea, entrevista.Contenido, entrevista.Likes, entrevista.Visualizaciones, entrevista.Usuario, entrevista.Comentario);
}

private void init (int id
                   , string entrevistado, string titulo, System.Collections.Generic.IList<string> etiquetas, Nullable<DateTime> fechaCrea, string contenido, int likes, int visualizaciones, GgesGenNHibernate.EN.Gges.UsuarioEN usuario, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario)
{
        this.Id = id;


        this.Entrevistado = entrevistado;

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
        EntrevistaEN t = obj as EntrevistaEN;
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
