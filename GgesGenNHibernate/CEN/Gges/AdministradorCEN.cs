

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
 *      Definition of the class AdministradorCEN
 *
 */
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public string CrearAdministrador (string p_nick, string p_pass, string p_nombre, string p_apellidos, string p_correo, Nullable<DateTime> p_fechaNa, int p_sexo, string p_pais, string p_provincia, string p_imagen, bool p_baneado)
{
        AdministradorEN administradorEN = null;
        string oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Nick = p_nick;

        administradorEN.Pass = p_pass;

        administradorEN.Nombre = p_nombre;

        administradorEN.Apellidos = p_apellidos;

        administradorEN.Correo = p_correo;

        administradorEN.FechaNa = p_fechaNa;

        administradorEN.Sexo = p_sexo;

        administradorEN.Pais = p_pais;

        administradorEN.Provincia = p_provincia;

        administradorEN.Imagen = p_imagen;

        administradorEN.Baneado = p_baneado;

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.CrearAdministrador (administradorEN);
        return oid;
}

public void ModificarAdmin (string p_Administrador_OID, string p_pass, string p_nombre, string p_apellidos, string p_correo, Nullable<DateTime> p_fechaNa, int p_sexo, string p_pais, string p_provincia, string p_imagen, bool p_baneado)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Nick = p_Administrador_OID;
        administradorEN.Pass = p_pass;
        administradorEN.Nombre = p_nombre;
        administradorEN.Apellidos = p_apellidos;
        administradorEN.Correo = p_correo;
        administradorEN.FechaNa = p_fechaNa;
        administradorEN.Sexo = p_sexo;
        administradorEN.Pais = p_pais;
        administradorEN.Provincia = p_provincia;
        administradorEN.Imagen = p_imagen;
        administradorEN.Baneado = p_baneado;
        //Call to AdministradorCAD

        _IAdministradorCAD.ModificarAdmin (administradorEN);
}

public void BorrarAdmin (string nick
                         )
{
        _IAdministradorCAD.BorrarAdmin (nick);
}
}
}
