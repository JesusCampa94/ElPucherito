
using System;
using GgesGenNHibernate.EN.Gges;

namespace GgesGenNHibernate.CAD.Gges
{
public partial interface IIngredientesCAD
{
IngredientesEN ReadOIDDefault (int id
                               );

void ModifyDefault (IngredientesEN ingredientes);



int CrearIngrediente (IngredientesEN ingredientes);

void ModificarIngrediente (IngredientesEN ingredientes);


void BorrarIngrediente (int id
                        );
}
}
