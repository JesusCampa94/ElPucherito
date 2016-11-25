
using System;
// Definición clase IngredientesEN
namespace GgesGenNHibernate.EN.Gges
{
public partial class IngredientesEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo tipo
 */
private GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum tipo;



/**
 *	Atributo receta
 */
private System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.RecetaEN> receta;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.RecetaEN> Receta {
        get { return receta; } set { receta = value;  }
}





public IngredientesEN()
{
        receta = new System.Collections.Generic.List<GgesGenNHibernate.EN.Gges.RecetaEN>();
}



public IngredientesEN(int id, string nombre, GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum tipo, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.RecetaEN> receta
                      )
{
        this.init (Id, nombre, tipo, receta);
}


public IngredientesEN(IngredientesEN ingredientes)
{
        this.init (Id, ingredientes.Nombre, ingredientes.Tipo, ingredientes.Receta);
}

private void init (int id
                   , string nombre, GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum tipo, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.RecetaEN> receta)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Tipo = tipo;

        this.Receta = receta;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IngredientesEN t = obj as IngredientesEN;
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
