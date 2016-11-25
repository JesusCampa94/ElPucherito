

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
 *      Definition of the class PublicacionCEN
 *
 */
public partial class PublicacionCEN
{
private IPublicacionCAD _IPublicacionCAD;

public PublicacionCEN()
{
        this._IPublicacionCAD = new PublicacionCAD ();
}

public PublicacionCEN(IPublicacionCAD _IPublicacionCAD)
{
        this._IPublicacionCAD = _IPublicacionCAD;
}

public IPublicacionCAD get_IPublicacionCAD ()
{
        return this._IPublicacionCAD;
}

public int CrearPublicacion (string p_titulo, System.Collections.Generic.IList<string> p_etiquetas, Nullable<DateTime> p_fechaCrea, string p_contenido, int p_likes, int p_visualizaciones, string p_usuario)
{
        PublicacionEN publicacionEN = null;
        int oid;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.Titulo = p_titulo;

        publicacionEN.Etiquetas = p_etiquetas;

        publicacionEN.FechaCrea = p_fechaCrea;

        publicacionEN.Contenido = p_contenido;

        publicacionEN.Likes = p_likes;

        publicacionEN.Visualizaciones = p_visualizaciones;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                publicacionEN.Usuario = new GgesGenNHibernate.EN.Gges.UsuarioEN ();
                publicacionEN.Usuario.Nick = p_usuario;
        }

        //Call to PublicacionCAD

        oid = _IPublicacionCAD.CrearPublicacion (publicacionEN);
        return oid;
}

public void CambiarPublicacion (int p_Publicacion_OID, string p_titulo, System.Collections.Generic.IList<string> p_etiquetas, Nullable<DateTime> p_fechaCrea, string p_contenido, int p_likes, int p_visualizaciones)
{
        PublicacionEN publicacionEN = null;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.Id = p_Publicacion_OID;
        publicacionEN.Titulo = p_titulo;
        publicacionEN.Etiquetas = p_etiquetas;
        publicacionEN.FechaCrea = p_fechaCrea;
        publicacionEN.Contenido = p_contenido;
        publicacionEN.Likes = p_likes;
        publicacionEN.Visualizaciones = p_visualizaciones;
        //Call to PublicacionCAD

        _IPublicacionCAD.CambiarPublicacion (publicacionEN);
}

public void BorrarPublicacion (int id
                               )
{
        _IPublicacionCAD.BorrarPublicacion (id);
}

public System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.PublicacionEN> PublicacionesOrdenInverso ()
{
        return _IPublicacionCAD.PublicacionesOrdenInverso ();
}
public GgesGenNHibernate.EN.Gges.PublicacionEN PublicacionPorTitulo (string p_titulo)
{
        return _IPublicacionCAD.PublicacionPorTitulo (p_titulo);
}
}
}
