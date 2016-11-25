using System;
using System.Collections.Generic;
namespace GgesGenNHibernate.EN.Gges
{
public class UsuarioEN_OID
{
private string nick;
public virtual string Nick {
        get { return nick; } set { nick = value;  }
}




private string correo;
public virtual string Correo {
        get { return correo; } set { correo = value;  }
}






public UsuarioEN_OID()
{
}
public UsuarioEN_OID(string nick, string correo)
{
        this.nick = nick;
        this.correo = correo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN_OID t = obj as UsuarioEN_OID;
        if (t == null)
                return false;


        if (this.nick == t.Nick && this.correo == t.Correo)

                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        // Su tipo es String
        hash = hash +
               (null == nick                                                     ? 0 : this.nick.GetHashCode ());
        // Su tipo es String
        hash = hash +
               (null == correo                                                   ? 0 : this.correo.GetHashCode ());
        return hash;
}
}
}
