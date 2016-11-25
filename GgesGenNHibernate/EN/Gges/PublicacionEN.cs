
using System;
// Definición clase PublicacionEN
namespace GgesGenNHibernate.EN.Gges
{
public partial class PublicacionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo etiquetas
 */
private System.Collections.Generic.IList<string> etiquetas;



/**
 *	Atributo fechaCrea
 */
private Nullable<DateTime> fechaCrea;



/**
 *	Atributo contenido
 */
private string contenido;



/**
 *	Atributo likes
 */
private int likes;



/**
 *	Atributo visualizaciones
 */
private int visualizaciones;



/**
 *	Atributo usuario
 */
private GgesGenNHibernate.EN.Gges.UsuarioEN usuario;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual System.Collections.Generic.IList<string> Etiquetas {
        get { return etiquetas; } set { etiquetas = value;  }
}



public virtual Nullable<DateTime> FechaCrea {
        get { return fechaCrea; } set { fechaCrea = value;  }
}



public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual int Likes {
        get { return likes; } set { likes = value;  }
}



public virtual int Visualizaciones {
        get { return visualizaciones; } set { visualizaciones = value;  }
}



public virtual GgesGenNHibernate.EN.Gges.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}





public PublicacionEN()
{
        comentario = new System.Collections.Generic.List<GgesGenNHibernate.EN.Gges.ComentarioEN>();
}



public PublicacionEN(int id, string titulo, System.Collections.Generic.IList<string> etiquetas, Nullable<DateTime> fechaCrea, string contenido, int likes, int visualizaciones, GgesGenNHibernate.EN.Gges.UsuarioEN usuario, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario
                     )
{
        this.init (Id, titulo, etiquetas, fechaCrea, contenido, likes, visualizaciones, usuario, comentario);
}


public PublicacionEN(PublicacionEN publicacion)
{
        this.init (Id, publicacion.Titulo, publicacion.Etiquetas, publicacion.FechaCrea, publicacion.Contenido, publicacion.Likes, publicacion.Visualizaciones, publicacion.Usuario, publicacion.Comentario);
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
        PublicacionEN t = obj as PublicacionEN;
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
