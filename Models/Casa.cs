using System;
using System.ComponentModel.Design;
using OOPVecindario.Models.Habitaciones;
namespace OOPVecindario.Models
{
    class Casa
    {
        int Precio {get; set;}
        int AreaConstruccion {get; set;}
        int CantidadCuartos {get; set;}
        List<Cuarto> Cuartos;
        Cocina Cocina {get; set;}
        int CantidadBanos {get; set;}
    }
}