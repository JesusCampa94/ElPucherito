
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
 * Clase Noticia:
 *
 */

namespace GgesGenNHibernate.CAD.Gges
{
public partial class NoticiaCAD : BasicCAD, INoticiaCAD
{
public NoticiaCAD() : base ()
{
}

public NoticiaCAD(ISession sessionAux) : base (sessionAux)
{
}



public NoticiaEN ReadOIDDefault (int id
                                 )
{
        NoticiaEN noticiaEN = null;

        try
        {
                SessionInitializeTransaction ();
                noticiaEN = (NoticiaEN)session.Get (typeof(NoticiaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in NoticiaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return noticiaEN;
}

public System.Collections.Generic.IList<NoticiaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<NoticiaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(NoticiaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<NoticiaEN>();
                        else
                                result = session.CreateCriteria (typeof(NoticiaEN)).List<NoticiaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in NoticiaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (NoticiaEN noticia)
{
        try
        {
                SessionInitializeTransaction ();
                NoticiaEN noticiaEN = (NoticiaEN)session.Load (typeof(NoticiaEN), noticia.Id);
                session.Update (noticiaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in NoticiaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearNoticia (NoticiaEN noticia)
{
        try
        {
                SessionInitializeTransaction ();
                if (noticia.Usuario != null) {
                        // Argumento OID y no colección.
                        noticia.Usuario = (GgesGenNHibernate.EN.Gges.UsuarioEN)session.Load (typeof(GgesGenNHibernate.EN.Gges.UsuarioEN), noticia.Usuario.Nick);

                        noticia.Usuario.Publicacion
                        .Add (noticia);
                }

                session.Save (noticia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in NoticiaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return noticia.Id;
}

public System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.NoticiaEN> NoticiasOrdenInverso ()
{
        System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.NoticiaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM NoticiaEN self where FROM NoticiaEN ORDER BY  fechaCrea ASC";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("NoticiaENNoticiasOrdenInversoHQL");

                result = query.List<GgesGenNHibernate.EN.Gges.NoticiaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in NoticiaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
