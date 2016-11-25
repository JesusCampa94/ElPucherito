
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
 * Clase Ingredientes:
 *
 */

namespace GgesGenNHibernate.CAD.Gges
{
public partial class IngredientesCAD : BasicCAD, IIngredientesCAD
{
public IngredientesCAD() : base ()
{
}

public IngredientesCAD(ISession sessionAux) : base (sessionAux)
{
}



public IngredientesEN ReadOIDDefault (int id
                                      )
{
        IngredientesEN ingredientesEN = null;

        try
        {
                SessionInitializeTransaction ();
                ingredientesEN = (IngredientesEN)session.Get (typeof(IngredientesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in IngredientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ingredientesEN;
}

public System.Collections.Generic.IList<IngredientesEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IngredientesEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IngredientesEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IngredientesEN>();
                        else
                                result = session.CreateCriteria (typeof(IngredientesEN)).List<IngredientesEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in IngredientesCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IngredientesEN ingredientes)
{
        try
        {
                SessionInitializeTransaction ();
                IngredientesEN ingredientesEN = (IngredientesEN)session.Load (typeof(IngredientesEN), ingredientes.Id);

                ingredientesEN.Nombre = ingredientes.Nombre;


                ingredientesEN.Tipo = ingredientes.Tipo;


                session.Update (ingredientesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in IngredientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearIngrediente (IngredientesEN ingredientes)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (ingredientes);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in IngredientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ingredientes.Id;
}

public void ModificarIngrediente (IngredientesEN ingredientes)
{
        try
        {
                SessionInitializeTransaction ();
                IngredientesEN ingredientesEN = (IngredientesEN)session.Load (typeof(IngredientesEN), ingredientes.Id);

                ingredientesEN.Nombre = ingredientes.Nombre;


                ingredientesEN.Tipo = ingredientes.Tipo;

                session.Update (ingredientesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in IngredientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarIngrediente (int id
                               )
{
        try
        {
                SessionInitializeTransaction ();
                IngredientesEN ingredientesEN = (IngredientesEN)session.Load (typeof(IngredientesEN), id);
                session.Delete (ingredientesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GgesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GgesGenNHibernate.Exceptions.DataLayerException ("Error in IngredientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
