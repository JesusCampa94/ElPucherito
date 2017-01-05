
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
 * Clase Entrevista:
 *
 */

namespace GgesGenNHibernate.CAD.Gges
{
public partial class EntrevistaCAD : BasicCAD, IEntrevistaCAD
{
public EntrevistaCAD() : base ()
{
}

public EntrevistaCAD(ISession sessionAux) : base (sessionAux)
{
}



public EntrevistaEN ReadOIDDefault (int id
                                    )
{
        EntrevistaEN entrevistaEN = null;

        try
        {
                SessionInitializeTransaction ();
                entrevistaEN = (EntrevistaEN)session.Get (typeof(EntrevistaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EntrevistaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entrevistaEN;
}

public System.Collections.Generic.IList<EntrevistaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EntrevistaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EntrevistaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EntrevistaEN>();
                        else
                                result = session.CreateCriteria (typeof(EntrevistaEN)).List<EntrevistaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EntrevistaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EntrevistaEN entrevista)
{
        try
        {
                SessionInitializeTransaction ();
                EntrevistaEN entrevistaEN = (EntrevistaEN)session.Load (typeof(EntrevistaEN), entrevista.Id);

                entrevistaEN.Entrevistado = entrevista.Entrevistado;

                session.Update (entrevistaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EntrevistaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearEntrevista (EntrevistaEN entrevista)
{
        try
        {
                SessionInitializeTransaction ();
                if (entrevista.Usuario != null) {
                        // Argumento OID y no colección.
                        entrevista.Usuario = (GgesGenNHibernate.EN.Gges.UsuarioEN)session.Load (typeof(GgesGenNHibernate.EN.Gges.UsuarioEN), entrevista.Usuario.Nick);

                        entrevista.Usuario.Publicacion
                        .Add (entrevista);
                }

                session.Save (entrevista);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EntrevistaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entrevista.Id;
}

public void CambiarEntrevista (EntrevistaEN entrevista)
{
        try
        {
                SessionInitializeTransaction ();
                EntrevistaEN entrevistaEN = (EntrevistaEN)session.Load (typeof(EntrevistaEN), entrevista.Id);

                entrevistaEN.Titulo = entrevista.Titulo;


                entrevistaEN.Etiquetas = entrevista.Etiquetas;


                entrevistaEN.FechaCrea = entrevista.FechaCrea;


                entrevistaEN.Contenido = entrevista.Contenido;


                entrevistaEN.Likes = entrevista.Likes;


                entrevistaEN.Visualizaciones = entrevista.Visualizaciones;


                entrevistaEN.Entrevistado = entrevista.Entrevistado;

                session.Update (entrevistaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EntrevistaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.EntrevistaEN> EntrevistasOrdenInverso ()
{
        System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.EntrevistaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EntrevistaEN self where FROM EntrevistaEN ORDER BY  fechaCrea ASC";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EntrevistaENEntrevistasOrdenInversoHQL");

                result = query.List<GgesGenNHibernate.EN.Gges.EntrevistaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in EntrevistaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
