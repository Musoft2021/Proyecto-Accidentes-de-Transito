using System;
namespace AcciPro.App.Dominio
{
    public class Vehiculo : TipoVehiculo 
    {
      
        public string Tipo_Propietario {get;set;}
        public string Matricula {get;set;}
        public string Modelo {get;set;}  
        public string Ciudad {get;set;}
    }
}