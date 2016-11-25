
using System;
// Definición clase UsuarioEN
namespace GgesGenNHibernate.EN.Gges
{
public partial class UsuarioEN
{
/**
 *	Atributo nick
 */
private string nick;



/**
 *	Atributo pass
 */
private string pass;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo correo
 */
private string correo;



/**
 *	Atributo fechaNa
 */
private Nullable<DateTime> fechaNa;



/**
 *	Atributo sexo
 */
private int sexo;



/**
 *	Atributo pais
 */
private string pais;



/**
 *	Atributo provincia
 */
private string provincia;



/**
 *	Atributo imagen
 */
private string imagen;



/**
 *	Atributo baneado
 */
private bool baneado;



/**
 *	Atributo publicacion
 */
private System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.PublicacionEN> publicacion;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario;






public virtual string Nick {
        get { return nick; } set { nick = value;  }
}



public virtual string Pass {
        get { return pass; } set { pass = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual string Correo {
        get { return correo; } set { correo = value;  }
}



public virtual Nullable<DateTime> FechaNa {
        get { return fechaNa; } set { fechaNa = value;  }
}



public virtual int Sexo {
        get { return sexo; } set { sexo = value;  }
}



public virtual string Pais {
        get { return pais; } set { pais = value;  }
}



public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}



public virtual bool Baneado {
        get { return baneado; } set { baneado = value;  }
}



public virtual System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.PublicacionEN> Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}





public UsuarioEN()
{
        publicacion = new System.Collections.Generic.List<GgesGenNHibernate.EN.Gges.PublicacionEN>();
        comentario = new System.Collections.Generic.List<GgesGenNHibernate.EN.Gges.ComentarioEN>();
}



public UsuarioEN(string nick, string pass, string nombre, string apellidos, string correo, Nullable<DateTime> fechaNa, int sexo, string pais, string provincia, string imagen, bool baneado, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.PublicacionEN> publicacion, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario
                 )
{
        this.init (Nick, pass, nombre, apellidos, correo, fechaNa, sexo, pais, provincia, imagen, baneado, publicacion, comentario);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Nick, usuario.Pass, usuario.Nombre, usuario.Apellidos, usuario.Correo, usuario.FechaNa, usuario.Sexo, usuario.Pais, usuario.Provincia, usuario.Imagen, usuario.Baneado, usuario.Publicacion, usuario.Comentario);
}

private void init (string nick
                   , string pass, string nombre, string apellidos, string correo, Nullable<DateTime> fechaNa, int sexo, string pais, string provincia, string imagen, bool baneado, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.PublicacionEN> publicacion, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario)
{
        this.Nick = nick;


        this.Pass = pass;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Correo = correo;

        this.FechaNa = fechaNa;

        this.Sexo = sexo;

        this.Pais = pais;

        this.Provincia = provincia;

        this.Imagen = imagen;

        this.Baneado = baneado;

        this.Publicacion = publicacion;

        this.Comentario = comentario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Nick.Equals (t.Nick))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nick.GetHashCode ();
        return hash;
}
}
}
