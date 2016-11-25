
using System;
// Definición clase ComentarioEN
namespace GgesGenNHibernate.EN.Gges
{
public partial class ComentarioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo contenido
 */
private string contenido;



/**
 *	Atributo fechaCom
 */
private Nullable<DateTime> fechaCom;



/**
 *	Atributo publicacion
 */
private GgesGenNHibernate.EN.Gges.PublicacionEN publicacion;



/**
 *	Atributo likes
 */
private int likes;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario;



/**
 *	Atributo comentario_0
 */
private GgesGenNHibernate.EN.Gges.ComentarioEN comentario_0;



/**
 *	Atributo usuario
 */
private GgesGenNHibernate.EN.Gges.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual Nullable<DateTime> FechaCom {
        get { return fechaCom; } set { fechaCom = value;  }
}



public virtual GgesGenNHibernate.EN.Gges.PublicacionEN Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual int Likes {
        get { return likes; } set { likes = value;  }
}



public virtual System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual GgesGenNHibernate.EN.Gges.ComentarioEN Comentario_0 {
        get { return comentario_0; } set { comentario_0 = value;  }
}



public virtual GgesGenNHibernate.EN.Gges.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public ComentarioEN()
{
        comentario = new System.Collections.Generic.List<GgesGenNHibernate.EN.Gges.ComentarioEN>();
}



public ComentarioEN(int id, string contenido, Nullable<DateTime> fechaCom, GgesGenNHibernate.EN.Gges.PublicacionEN publicacion, int likes, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario, GgesGenNHibernate.EN.Gges.ComentarioEN comentario_0, GgesGenNHibernate.EN.Gges.UsuarioEN usuario
                    )
{
        this.init (Id, contenido, fechaCom, publicacion, likes, comentario, comentario_0, usuario);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Id, comentario.Contenido, comentario.FechaCom, comentario.Publicacion, comentario.Likes, comentario.Comentario, comentario.Comentario_0, comentario.Usuario);
}

private void init (int id
                   , string contenido, Nullable<DateTime> fechaCom, GgesGenNHibernate.EN.Gges.PublicacionEN publicacion, int likes, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario, GgesGenNHibernate.EN.Gges.ComentarioEN comentario_0, GgesGenNHibernate.EN.Gges.UsuarioEN usuario)
{
        this.Id = id;


        this.Contenido = contenido;

        this.FechaCom = fechaCom;

        this.Publicacion = publicacion;

        this.Likes = likes;

        this.Comentario = comentario;

        this.Comentario_0 = comentario_0;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
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
