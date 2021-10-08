using System.Collections.Generic;

namespace AcciPro.App.Dominio
{
    public class Accidente 
    {
       public int Id {get;set;}
        public string Latitud {get;set;}
        public string Longitud {get;set;}
        public string Direccion {get;set;}
        public char Fecha {get;set;}
        public string Descripcion {get;set;}
    }
}