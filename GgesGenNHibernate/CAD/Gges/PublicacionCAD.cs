
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
 * Clase Publicacion:
 *
 */

namespace GgesGenNHibernate.CAD.Gges
{
public partial class PublicacionCAD : BasicCAD, IPublicacionCAD
{
public PublicacionCAD() : base ()
{
}

public PublicacionCAD(ISession sessionAux) : base (sessionAux)
{
}



public PublicacionEN ReadOIDDefault (int id
                                     )
{
        PublicacionEN publicacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                publicacionEN = (PublicacionEN)session.Get (typeof(PublicacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PublicacionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PublicacionEN>();
                        else
                                result = session.CreateCriteria (typeof(PublicacionEN)).List<PublicacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PublicacionEN publicacion)
{
        try
        {
                SessionInitializeTransaction ();
                PublicacionEN publicacionEN = (PublicacionEN)session.Load (typeof(PublicacionEN), publicacion.Id);

                publicacionEN.Titulo = publicacion.Titulo;


                publicacionEN.Etiquetas = publicacion.Etiquetas;


                publicacionEN.FechaCrea = publicacion.FechaCrea;


                publicacionEN.Contenido = publicacion.Contenido;


                publicacionEN.Likes = publicacion.Likes;


                publicacionEN.Visualizaciones = publicacion.Visualizaciones;



                session.Update (publicacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearPublicacion (PublicacionEN publicacion)
{
        try
        {
                SessionInitializeTransaction ();
                if (publicacion.Usuario != null) {
                        // Argumento OID y no colección.
                        publicacion.Usuario = (GgesGenNHibernate.EN.Gges.UsuarioEN)session.Load (typeof(GgesGenNHibernate.EN.Gges.UsuarioEN), publicacion.Usuario.Nick);

                        publicacion.Usuario.Publicacion
                        .Add (publicacion);
                }

                session.Save (publicacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return publicacion.Id;
}

public void CambiarPublicacion (PublicacionEN publicacion)
{
        try
        {
                SessionInitializeTransaction ();
                PublicacionEN publicacionEN = (PublicacionEN)session.Load (typeof(PublicacionEN), publicacion.Id);

                publicacionEN.Titulo = publicacion.Titulo;


                publicacionEN.Etiquetas = publicacion.Etiquetas;


                publicacionEN.FechaCrea = publicacion.FechaCrea;


                publicacionEN.Contenido = publicacion.Contenido;


                publicacionEN.Likes = publicacion.Likes;


                publicacionEN.Visualizaciones = publicacion.Visualizaciones;

                session.Update (publicacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarPublicacion (int id
                               )
{
        try
        {
                SessionInitializeTransaction ();
                PublicacionEN publicacionEN = (PublicacionEN)session.Load (typeof(PublicacionEN), id);
                session.Delete (publicacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.PublicacionEN> PublicacionesOrdenInverso ()
{
        System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.PublicacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PublicacionEN self where FROM PublicacionEN ORDER BY  fechaCrea ASC";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PublicacionENPublicacionesOrdenInversoHQL");

                result = query.List<GgesGenNHibernate.EN.Gges.PublicacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public GgesGenNHibernate.EN.Gges.PublicacionEN PublicacionPorTitulo (string p_titulo)
{
        GgesGenNHibernate.EN.Gges.PublicacionEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PublicacionEN self where FROM PublicacionEN WHERE titulo = :p_titulo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PublicacionENpublicacionPorTituloHQL");
                query.SetParameter ("p_titulo", p_titulo);


                result = query.UniqueResult<GgesGenNHibernate.EN.Gges.PublicacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
