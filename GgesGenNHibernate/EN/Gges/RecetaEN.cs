
using System;
// Definición clase RecetaEN
namespace GgesGenNHibernate.EN.Gges
{
public partial class RecetaEN                                                                       : GgesGenNHibernate.EN.Gges.PublicacionEN


{
/**
 *	Atributo ingredientes
 */
private System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.IngredientesEN> ingredientes;






public virtual System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.IngredientesEN> Ingredientes {
        get { return ingredientes; } set { ingredientes = value;  }
}





public RecetaEN() : base ()
{
        ingredientes = new System.Collections.Generic.List<GgesGenNHibernate.EN.Gges.IngredientesEN>();
}



public RecetaEN(int id, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.IngredientesEN> ingredientes
                , string titulo, System.Collections.Generic.IList<string> etiquetas, Nullable<DateTime> fechaCrea, string contenido, int likes, int visualizaciones, GgesGenNHibernate.EN.Gges.UsuarioEN usuario, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario
                )
{
        this.init (Id, ingredientes, titulo, etiquetas, fechaCrea, contenido, likes, visualizaciones, usuario, comentario);
}


public RecetaEN(RecetaEN receta)
{
        this.init (Id, receta.Ingredientes, receta.Titulo, receta.Etiquetas, receta.FechaCrea, receta.Contenido, receta.Likes, receta.Visualizaciones, receta.Usuario, receta.Comentario);
}

private void init (int id
                   , System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.IngredientesEN> ingredientes, string titulo, System.Collections.Generic.IList<string> etiquetas, Nullable<DateTime> fechaCrea, string contenido, int likes, int visualizaciones, GgesGenNHibernate.EN.Gges.UsuarioEN usuario, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.ComentarioEN> comentario)
{
        this.Id = id;


        this.Ingredientes = ingredientes;

        this.Titulo = titulo;

        this.Etiquetas = etiquetas;

        this.FechaCrea = fechaCrea;

        this.Contenido = contenido;

        this.Likes = likes;

        this.Visualizaciones = visualizaciones;

        this.Usuario = usuario;

        this.Comentario = comentario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RecetaEN t = obj as RecetaEN;
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
