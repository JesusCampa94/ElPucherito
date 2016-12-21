

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
 *      Definition of the class NoticiaCEN
 *
 */
public partial class NoticiaCEN
{
private INoticiaCAD _INoticiaCAD;

public NoticiaCEN()
{
        this._INoticiaCAD = new NoticiaCAD ();
}

public NoticiaCEN(INoticiaCAD _INoticiaCAD)
{
        this._INoticiaCAD = _INoticiaCAD;
}

public INoticiaCAD get_INoticiaCAD ()
{
        return this._INoticiaCAD;
}

public int CrearNoticia (string p_titulo, System.Collections.Generic.IList<string> p_etiquetas, Nullable<DateTime> p_fechaCrea, string p_contenido, int p_likes, int p_visualizaciones, string p_usuario)
{
        NoticiaEN noticiaEN = null;
        int oid;

        //Initialized NoticiaEN
        noticiaEN = new NoticiaEN ();
        noticiaEN.Titulo = p_titulo;

        noticiaEN.Etiquetas = p_etiquetas;

        noticiaEN.FechaCrea = p_fechaCrea;

        noticiaEN.Contenido = p_contenido;

        noticiaEN.Likes = p_likes;

        noticiaEN.Visualizaciones = p_visualizaciones;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                noticiaEN.Usuario = new GgesGenNHibernate.EN.Gges.UsuarioEN ();
                noticiaEN.Usuario.Nick = p_usuario;
        }

        //Call to NoticiaCAD

        oid = _INoticiaCAD.CrearNoticia (noticiaEN);
        return oid;
}

public System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.NoticiaEN> NoticiasOrdenInverso ()
{
        return _INoticiaCAD.NoticiasOrdenInverso ();
}
}
}
