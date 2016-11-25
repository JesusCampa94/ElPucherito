
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
 * Clase Comentario:
 *
 */

namespace GgesGenNHibernate.CAD.Gges
{
public partial class ComentarioCAD : BasicCAD, IComentarioCAD
{
public ComentarioCAD() : base ()
{
}

public ComentarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public ComentarioEN ReadOIDDefault (int id
                                    )
{
        ComentarioEN comentarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Get (typeof(ComentarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comentarioEN;
}

public System.Collections.Generic.IList<ComentarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ComentarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ComentarioEN>();
                        else
                                result = session.CreateCriteria (typeof(ComentarioEN)).List<ComentarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ComentarioEN comentario)
{
        try
        {
                SessionInitializeTransaction ();
                ComentarioEN comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), comentario.Id);

                comentarioEN.Contenido = comentario.Contenido;


                comentarioEN.FechaCom = comentario.FechaCom;



                comentarioEN.Likes = comentario.Likes;




                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearComentario (ComentarioEN comentario)
{
        try
        {
                SessionInitializeTransaction ();
                if (comentario.Publicacion != null) {
                        // Argumento OID y no colección.
                        comentario.Publicacion = (GgesGenNHibernate.EN.Gges.PublicacionEN)session.Load (typeof(GgesGenNHibernate.EN.Gges.PublicacionEN), comentario.Publicacion.Id);

                        comentario.Publicacion.Comentario
                        .Add (comentario);
                }
                if (comentario.Usuario != null) {
                        // Argumento OID y no colección.
                        comentario.Usuario = (GgesGenNHibernate.EN.Gges.UsuarioEN)session.Load (typeof(GgesGenNHibernate.EN.Gges.UsuarioEN), comentario.Usuario.Nick);

                        comentario.Usuario.Comentario
                        .Add (comentario);
                }

                session.Save (comentario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comentario.Id;
}

public void ModificarComentario (ComentarioEN comentario)
{
        try
        {
                SessionInitializeTransaction ();
                ComentarioEN comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), comentario.Id);

                comentarioEN.Contenido = comentario.Contenido;


                comentarioEN.FechaCom = comentario.FechaCom;


                comentarioEN.Likes = comentario.Likes;

                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarComentario (int id
                              )
{
        try
        {
                SessionInitializeTransaction ();
                ComentarioEN comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), id);
                session.Delete (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
