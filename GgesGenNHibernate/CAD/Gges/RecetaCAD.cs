
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
 * Clase Receta:
 *
 */

namespace GgesGenNHibernate.CAD.Gges
{
public partial class RecetaCAD : BasicCAD, IRecetaCAD
{
public RecetaCAD() : base ()
{
}

public RecetaCAD(ISession sessionAux) : base (sessionAux)
{
}



public RecetaEN ReadOIDDefault (int id
                                )
{
        RecetaEN recetaEN = null;

        try
        {
                SessionInitializeTransaction ();
                recetaEN = (RecetaEN)session.Get (typeof(RecetaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in RecetaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recetaEN;
}

public System.Collections.Generic.IList<RecetaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RecetaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RecetaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RecetaEN>();
                        else
                                result = session.CreateCriteria (typeof(RecetaEN)).List<RecetaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in RecetaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RecetaEN receta)
{
        try
        {
                SessionInitializeTransaction ();
                RecetaEN recetaEN = (RecetaEN)session.Load (typeof(RecetaEN), receta.Id);

                session.Update (recetaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in RecetaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearReceta (RecetaEN receta)
{
        try
        {
                SessionInitializeTransaction ();
                if (receta.Usuario != null) {
                        // Argumento OID y no colección.
                        receta.Usuario = (GgesGenNHibernate.EN.Gges.UsuarioEN)session.Load (typeof(GgesGenNHibernate.EN.Gges.UsuarioEN), receta.Usuario.Nick);

                        receta.Usuario.Publicacion
                        .Add (receta);
                }
                if (receta.Ingredientes != null) {
                        foreach (GgesGenNHibernate.EN.Gges.IngredientesEN item in receta.Ingredientes) {
                                item.Receta.Add (receta);
                                session.Save (item);
                        }
                }

                session.Save (receta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in RecetaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return receta.Id;
}

public void CambiarReceta (RecetaEN receta)
{
        try
        {
                SessionInitializeTransaction ();
                RecetaEN recetaEN = (RecetaEN)session.Load (typeof(RecetaEN), receta.Id);

                recetaEN.Titulo = receta.Titulo;


                recetaEN.Etiquetas = receta.Etiquetas;


                recetaEN.FechaCrea = receta.FechaCrea;


                recetaEN.Contenido = receta.Contenido;


                recetaEN.Likes = receta.Likes;


                recetaEN.Visualizaciones = receta.Visualizaciones;

                session.Update (recetaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in RecetaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarReceta (int id
                          )
{
        try
        {
                SessionInitializeTransaction ();
                RecetaEN recetaEN = (RecetaEN)session.Load (typeof(RecetaEN), id);
                session.Delete (recetaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in RecetaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.RecetaEN> RecetasOrdenInverso ()
{
        System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.RecetaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RecetaEN self where FROM RecetaEN ORDER BY  fechaCrea ASC";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RecetaENRecetasOrdenInversoHQL");

                result = query.List<GgesGenNHibernate.EN.Gges.RecetaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in RecetaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
