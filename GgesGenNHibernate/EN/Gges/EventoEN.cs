
using System;
// Definición clase EventoEN
namespace GgesGenNHibernate.EN.Gges
{
public partial class EventoEN                                                                       : GgesGenNHibernate.EN.Gges.PublicacionEN


{
/**
 *	Atributo lugar
 */
private string lugar;






public virtual string Lugar {
        get { return lugar; } set { lugar = value;  }
}





public EventoEN() : base ()
{
}



public EventoEN(int id, string lugar
                , string titulo, System.Collections.Generic.IList<string> etiquetas, Nullable<DateTime> fechaCrea, string contenido, int likes, int visualizaciones, GgesGenNHibernate.EN.Gges.UsuarioEN usuario, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario
                )
{
        this.init (Id, lugar, titulo, etiquetas, fechaCrea, contenido, likes, visualizaciones, usuario, comentario);
}


public EventoEN(EventoEN evento)
{
        this.init (Id, evento.Lugar, evento.Titulo, evento.Etiquetas, evento.FechaCrea, evento.Contenido, evento.Likes, evento.Visualizaciones, evento.Usuario, evento.Comentario);
}

private void init (int id
                   , string lugar, string titulo, System.Collections.Generic.IList<string> etiquetas, Nullable<DateTime> fechaCrea, string contenido, int likes, int visualizaciones, GgesGenNHibernate.EN.Gges.UsuarioEN usuario, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario)
{
        this.Id = id;


        this.Lugar = lugar;

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
        EventoEN t = obj as EventoEN;
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
