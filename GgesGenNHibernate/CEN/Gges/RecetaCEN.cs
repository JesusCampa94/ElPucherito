

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
 *      Definition of the class RecetaCEN
 *
 */
public partial class RecetaCEN
{
private IRecetaCAD _IRecetaCAD;

public RecetaCEN()
{
        this._IRecetaCAD = new RecetaCAD ();
}

public RecetaCEN(IRecetaCAD _IRecetaCAD)
{
        this._IRecetaCAD = _IRecetaCAD;
}

public IRecetaCAD get_IRecetaCAD ()
{
        return this._IRecetaCAD;
}

public int CrearReceta (string p_titulo, System.Collections.Generic.IList<string> p_etiquetas, Nullable<DateTime> p_fechaCrea, string p_contenido, int p_likes, int p_visualizaciones, string p_usuario, System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.IngredientesEN> p_ingredientes)
{
        RecetaEN recetaEN = null;
        int oid;

        //Initialized RecetaEN
        recetaEN = new RecetaEN ();
        recetaEN.Titulo = p_titulo;

        recetaEN.Etiquetas = p_etiquetas;

        recetaEN.FechaCrea = p_fechaCrea;

        recetaEN.Contenido = p_contenido;

        recetaEN.Likes = p_likes;

        recetaEN.Visualizaciones = p_visualizaciones;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                recetaEN.Usuario = new GgesGenNHibernate.EN.Gges.UsuarioEN ();
                recetaEN.Usuario.Nick = p_usuario;
        }

        recetaEN.Ingredientes = p_ingredientes;

        //Call to RecetaCAD

        oid = _IRecetaCAD.CrearReceta (recetaEN);
        return oid;
}

public void CambiarReceta (int p_Receta_OID, string p_titulo, System.Collections.Generic.IList<string> p_etiquetas, Nullable<DateTime> p_fechaCrea, string p_contenido, int p_likes, int p_visualizaciones)
{
        RecetaEN recetaEN = null;

        //Initialized RecetaEN
        recetaEN = new RecetaEN ();
        recetaEN.Id = p_Receta_OID;
        recetaEN.Titulo = p_titulo;
        recetaEN.Etiquetas = p_etiquetas;
        recetaEN.FechaCrea = p_fechaCrea;
        recetaEN.Contenido = p_contenido;
        recetaEN.Likes = p_likes;
        recetaEN.Visualizaciones = p_visualizaciones;
        //Call to RecetaCAD

        _IRecetaCAD.CambiarReceta (recetaEN);
}

public void BorrarReceta (int id
                          )
{
        _IRecetaCAD.BorrarReceta (id);
}

public System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.RecetaEN> RecetasOrdenInverso ()
{
        return _IRecetaCAD.RecetasOrdenInverso ();
}
}
}
