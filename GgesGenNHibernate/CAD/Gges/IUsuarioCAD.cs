
using System;
using GgesGenNHibernate.EN.Gges;

namespace GgesGenNHibernate.CAD.Gges
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string nick
                          );

void ModifyDefault (UsuarioEN usuario);



string CrearUsuario (UsuarioEN usuario);

void CambiarDatos (UsuarioEN usuario);


void BorrarUsuario (string nick
                    );



GgesGenNHibernate.EN.Gges.UsuarioEN UsuarioPorEmail (string p_email);



int PuntuacionMediaComentarios (string p_nick);


int MediaLikesPublicaciones (string nick);
}
}
