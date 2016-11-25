

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
 *      Definition of the class IngredientesCEN
 *
 */
public partial class IngredientesCEN
{
private IIngredientesCAD _IIngredientesCAD;

public IngredientesCEN()
{
        this._IIngredientesCAD = new IngredientesCAD ();
}

public IngredientesCEN(IIngredientesCAD _IIngredientesCAD)
{
        this._IIngredientesCAD = _IIngredientesCAD;
}

public IIngredientesCAD get_IIngredientesCAD ()
{
        return this._IIngredientesCAD;
}

public int CrearIngrediente (string p_nombre, GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum p_tipo)
{
        IngredientesEN ingredientesEN = null;
        int oid;

        //Initialized IngredientesEN
        ingredientesEN = new IngredientesEN ();
        ingredientesEN.Nombre = p_nombre;

        ingredientesEN.Tipo = p_tipo;

        //Call to IngredientesCAD

        oid = _IIngredientesCAD.CrearIngrediente (ingredientesEN);
        return oid;
}

public void ModificarIngrediente (int p_Ingredientes_OID, string p_nombre, GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum p_tipo)
{
        IngredientesEN ingredientesEN = null;

        //Initialized IngredientesEN
        ingredientesEN = new IngredientesEN ();
        ingredientesEN.Id = p_Ingredientes_OID;
        ingredientesEN.Nombre = p_nombre;
        ingredientesEN.Tipo = p_tipo;
        //Call to IngredientesCAD

        _IIngredientesCAD.ModificarIngrediente (ingredientesEN);
}

public void BorrarIngrediente (int id
                               )
{
        _IIngredientesCAD.BorrarIngrediente (id);
}
}
}
