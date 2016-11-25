
using System;
using GgesGenNHibernate.EN.Gges;

namespace GgesGenNHibernate.CAD.Gges
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (string nick
                                );

void ModifyDefault (AdministradorEN administrador);



string CrearAdministrador (AdministradorEN administrador);

void ModificarAdmin (AdministradorEN administrador);


void BorrarAdmin (string nick
                  );
}
}
