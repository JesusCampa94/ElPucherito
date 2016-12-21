

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
 *      Definition of the class EventoCEN
 *
 */
public partial class EventoCEN
{
private IEventoCAD _IEventoCAD;

public EventoCEN()
{
        this._IEventoCAD = new EventoCAD ();
}

public EventoCEN(IEventoCAD _IEventoCAD)
{
        this._IEventoCAD = _IEventoCAD;
}

public IEventoCAD get_IEventoCAD ()
{
        return this._IEventoCAD;
}

public int CrearEvento (string p_titulo, System.Collections.Generic.IList<string> p_etiquetas, Nullable<DateTime> p_fechaCrea, string p_contenido, int p_likes, int p_visualizaciones, string p_usuario, string p_lugar)
{
        EventoEN eventoEN = null;
        int oid;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Titulo = p_titulo;

        eventoEN.Etiquetas = p_etiquetas;

        eventoEN.FechaCrea = p_fechaCrea;

        eventoEN.Contenido = p_contenido;

        eventoEN.Likes = p_likes;

        eventoEN.Visualizaciones = p_visualizaciones;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                eventoEN.Usuario = new GgesGenNHibernate.EN.Gges.UsuarioEN ();
                eventoEN.Usuario.Nick = p_usuario;
        }

        eventoEN.Lugar = p_lugar;

        //Call to EventoCAD

        oid = _IEventoCAD.CrearEvento (eventoEN);
        return oid;
}

public void CambiarEvento (int p_Evento_OID, string p_titulo, System.Collections.Generic.IList<string> p_etiquetas, Nullable<DateTime> p_fechaCrea, string p_contenido, int p_likes, int p_visualizaciones, string p_lugar)
{
        EventoEN eventoEN = null;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Id = p_Evento_OID;
        eventoEN.Titulo = p_titulo;
        eventoEN.Etiquetas = p_etiquetas;
        eventoEN.FechaCrea = p_fechaCrea;
        eventoEN.Contenido = p_contenido;
        eventoEN.Likes = p_likes;
        eventoEN.Visualizaciones = p_visualizaciones;
        eventoEN.Lugar = p_lugar;
        //Call to EventoCAD

        _IEventoCAD.CambiarEvento (eventoEN);
}

public System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.EventoEN> EventosOrdenInverso ()
{
        return _IEventoCAD.EventosOrdenInverso ();
}
}
}
