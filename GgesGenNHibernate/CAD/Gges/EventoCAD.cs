
using System;
using System.Text;
using GgesGenNHibernate.CEN.Gges;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using GgesGenNHibernate.EN.Gges;
using GgesGenNHibernate.Exceptions;


/*
 * Clase Evento:
 *
 */

namespace GgesGenNHibernate.CAD.Gges
{
public partial class EventoCAD : BasicCAD, IEventoCAD
{
public EventoCAD() : base ()
{
}

public EventoCAD(ISession sessionAux) : base (sessionAux)
{
}



public EventoEN ReadOIDDefault (int id
                                )
{
        EventoEN eventoEN = null;

        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Get (typeof(EventoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventoEN;
}

public System.Collections.Generic.IList<EventoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EventoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EventoEN>();
                        else
                                result = session.CreateCriteria (typeof(EventoEN)).List<EventoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                EventoEN eventoEN = (EventoEN)session.Load (typeof(EventoEN), evento.Id);

                eventoEN.Lugar = evento.Lugar;

                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearEvento (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                if (evento.Usuario != null) {
                        // Argumento OID y no colección.
                        evento.Usuario = (GgesGenNHibernate.EN.Gges.UsuarioEN)session.Load (typeof(GgesGenNHibernate.EN.Gges.UsuarioEN), evento.Usuario.Nick);

                        evento.Usuario.Publicacion
                        .Add (evento);
                }

                session.Save (evento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return evento.Id;
}

public void CambiarEvento (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                EventoEN eventoEN = (EventoEN)session.Load (typeof(EventoEN), evento.Id);

                eventoEN.Titulo = evento.Titulo;


                eventoEN.Etiquetas = evento.Etiquetas;


                eventoEN.FechaCrea = evento.FechaCrea;


                eventoEN.Contenido = evento.Contenido;


                eventoEN.Likes = evento.Likes;


                eventoEN.Visualizaciones = evento.Visualizaciones;


                eventoEN.Lugar = evento.Lugar;

                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarEvento (int id
                          )
{
        try
        {
                SessionInitializeTransaction ();
                EventoEN eventoEN = (EventoEN)session.Load (typeof(EventoEN), id);
                session.Delete (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.EventoEN> EventosOrdenInverso ()
{
        System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.EventoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EventoEN self where FROM EventoEN ORDER BY  fechaCrea ASC";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EventoENEventosOrdenInversoHQL");

                result = query.List<GgesGenNHibernate.EN.Gges.EventoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
