

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
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string CrearUsuario (string p_nick, string p_pass, string p_nombre, string p_apellidos, string p_correo, Nullable<DateTime> p_fechaNa, int p_sexo, string p_pais, string p_provincia, string p_imagen, bool p_baneado, bool p_logeado)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nick = p_nick;

        usuarioEN.Pass = p_pass;

        usuarioEN.Nombre = p_nombre;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Correo = p_correo;

        usuarioEN.FechaNa = p_fechaNa;

        usuarioEN.Sexo = p_sexo;

        usuarioEN.Pais = p_pais;

        usuarioEN.Provincia = p_provincia;

        usuarioEN.Imagen = p_imagen;

        usuarioEN.Baneado = p_baneado;

        usuarioEN.Logeado = p_logeado;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.CrearUsuario (usuarioEN);
        return oid;
}

public void CambiarDatos (string p_Usuario_OID, string p_pass, string p_nombre, string p_apellidos, string p_correo, Nullable<DateTime> p_fechaNa, int p_sexo, string p_pais, string p_provincia, string p_imagen, bool p_baneado, bool p_logeado)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nick = p_Usuario_OID;
        usuarioEN.Pass = p_pass;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Correo = p_correo;
        usuarioEN.FechaNa = p_fechaNa;
        usuarioEN.Sexo = p_sexo;
        usuarioEN.Pais = p_pais;
        usuarioEN.Provincia = p_provincia;
        usuarioEN.Imagen = p_imagen;
        usuarioEN.Baneado = p_baneado;
        usuarioEN.Logeado = p_logeado;
        //Call to UsuarioCAD

        _IUsuarioCAD.CambiarDatos (usuarioEN);
}

public void BorrarUsuario (string nick
                           )
{
        _IUsuarioCAD.BorrarUsuario (nick);
}

public GgesGenNHibernate.EN.Gges.UsuarioEN UsuarioPorEmail (string p_email)
{
        return _IUsuarioCAD.UsuarioPorEmail (p_email);
}
public int PuntuacionMediaComentarios (string p_nick)
{
        return _IUsuarioCAD.PuntuacionMediaComentarios (p_nick);
}
public int MediaLikesPublicaciones (string nick)
{
        return _IUsuarioCAD.MediaLikesPublicaciones (nick);
}
}
}
