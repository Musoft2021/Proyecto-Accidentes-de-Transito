using System;
namespace AcciPro.App.Dominio
{
    public class Agente : Persona
    {
        public string Direccion {get;set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public string Ciudad {get;set;}
        public DateTime FechaNacimiento {get;set;}

        public System.Collections.Generic.List<Accidente> Accidentes {get;set;}
    }
}