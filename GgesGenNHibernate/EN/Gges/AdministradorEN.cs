
using System;
// Definición clase AdministradorEN
namespace GgesGenNHibernate.EN.Gges
{
public partial class AdministradorEN                                                                        : GgesGenNHibernate.EN.Gges.UsuarioEN


{
public AdministradorEN() : base ()
{
}



public AdministradorEN(string nick,
                       string pass, string nombre, string apellidos, string correo, Nullable<DateTime> fechaNa, int sexo, string pais, string provincia, string imagen, bool baneado, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.PublicacionEN> publicacion, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario
                       )
{
        this.init (Nick, pass, nombre, apellidos, correo, fechaNa, sexo, pais, provincia, imagen, baneado, publicacion, comentario);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (Nick, administrador.Pass, administrador.Nombre, administrador.Apellidos, administrador.Correo, administrador.FechaNa, administrador.Sexo, administrador.Pais, administrador.Provincia, administrador.Imagen, administrador.Baneado, administrador.Publicacion, administrador.Comentario);
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
        AdministradorEN t = obj as AdministradorEN;
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
