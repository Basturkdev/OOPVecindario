using System;
namespace OOPVecindario.Models.Habitaciones
{
    class Cocina
    {
        int AreaCocina {get; set;}
        string TipoCocina {get; set;} //-> Electrica o Gas, segun las preferencias del dueno.
        bool Lavaplatos {get; set;} //-> Esta equipada para instalar lavaplatos
    }
}