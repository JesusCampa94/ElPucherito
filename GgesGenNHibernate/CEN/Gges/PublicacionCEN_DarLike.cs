
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using GgesGenNHibernate.Exceptions;
using GgesGenNHibernate.EN.Gges;
using GgesGenNHibernate.CAD.Gges;


/*PROTECTED REGION ID(usingGgesGenNHibernate.CEN.Gges_Publicacion_darLike) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace GgesGenNHibernate.CEN.Gges
{
public partial class PublicacionCEN
{
public void DarLike (int p_oid)
{
            /*PROTECTED REGION ID(GgesGenNHibernate.CEN.Gges_Publicacion_darLike) ENABLED START*/

            PublicacionCAD publicacionCAD = new PublicacionCAD();
            PublicacionEN publicacionEN = null;


            //obtenemos la publicacion con el oid pasado por parametro
            publicacionEN = _IPublicacionCAD.ReadOIDDefault(p_oid);

            //subimos un like a la publicacion
            publicacionEN.Likes++;

            publicacionCAD.CambiarPublicacion(publicacionEN);


            /*PROTECTED REGION END*/
        }
}
}
