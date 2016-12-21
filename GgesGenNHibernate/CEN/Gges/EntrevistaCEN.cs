

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
 *      Definition of the class EntrevistaCEN
 *
 */
public partial class EntrevistaCEN
{
private IEntrevistaCAD _IEntrevistaCAD;

public EntrevistaCEN()
{
        this._IEntrevistaCAD = new EntrevistaCAD ();
}

public EntrevistaCEN(IEntrevistaCAD _IEntrevistaCAD)
{
        this._IEntrevistaCAD = _IEntrevistaCAD;
}

public IEntrevistaCAD get_IEntrevistaCAD ()
{
        return this._IEntrevistaCAD;
}

public int CrearEntrevista (string p_titulo, System.Collections.Generic.IList<string> p_etiquetas, Nullable<DateTime> p_fechaCrea, string p_contenido, int p_likes, int p_visualizaciones, string p_usuario, string p_entrevistado)
{
        EntrevistaEN entrevistaEN = null;
        int oid;

        //Initialized EntrevistaEN
        entrevistaEN = new EntrevistaEN ();
        entrevistaEN.Titulo = p_titulo;

        entrevistaEN.Etiquetas = p_etiquetas;

        entrevistaEN.FechaCrea = p_fechaCrea;

        entrevistaEN.Contenido = p_contenido;

        entrevistaEN.Likes = p_likes;

        entrevistaEN.Visualizaciones = p_visualizaciones;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                entrevistaEN.Usuario = new GgesGenNHibernate.EN.Gges.UsuarioEN ();
                entrevistaEN.Usuario.Nick = p_usuario;
        }

        entrevistaEN.Entrevistado = p_entrevistado;

        //Call to EntrevistaCAD

        oid = _IEntrevistaCAD.CrearEntrevista (entrevistaEN);
        return oid;
}

public void CambiarEntrevista (int p_Entrevista_OID, string p_titulo, System.Collections.Generic.IList<string> p_etiquetas, Nullable<DateTime> p_fechaCrea, string p_contenido, int p_likes, int p_visualizaciones, string p_entrevistado)
{
        EntrevistaEN entrevistaEN = null;

        //Initialized EntrevistaEN
        entrevistaEN = new EntrevistaEN ();
        entrevistaEN.Id = p_Entrevista_OID;
        entrevistaEN.Titulo = p_titulo;
        entrevistaEN.Etiquetas = p_etiquetas;
        entrevistaEN.FechaCrea = p_fechaCrea;
        entrevistaEN.Contenido = p_contenido;
        entrevistaEN.Likes = p_likes;
        entrevistaEN.Visualizaciones = p_visualizaciones;
        entrevistaEN.Entrevistado = p_entrevistado;
        //Call to EntrevistaCAD

        _IEntrevistaCAD.CambiarEntrevista (entrevistaEN);
}

public System.Collections.Generic.IList<GgesGenNHibernate.EN.Gges.EntrevistaEN> EntrevistasOrdenInverso ()
{
        return _IEntrevistaCAD.EntrevistasOrdenInverso ();
}
}
}
