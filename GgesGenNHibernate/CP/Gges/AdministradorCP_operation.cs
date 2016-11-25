
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using GgesGenNHibernate.EN.Gges;
using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.CEN.Gges;



/*PROTECTED REGION ID(usingGgesGenNHibernate.CP.Gges_Administrador_operation) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace GgesGenNHibernate.CP.Gges
{
public partial class AdministradorCP : BasicCP
{
public void Operation (string p_oid)
{
        /*PROTECTED REGION ID(GgesGenNHibernate.CP.Gges_Administrador_operation) ENABLED START*/

        IAdministradorCAD administradorCAD = null;
        AdministradorCEN administradorCEN = null;



        try
        {
                SessionInitializeTransaction ();
                administradorCAD = new AdministradorCAD (session);
                administradorCEN = new  AdministradorCEN (administradorCAD);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method Operation() not yet implemented.");



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
