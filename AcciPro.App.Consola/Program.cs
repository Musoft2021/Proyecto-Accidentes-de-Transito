using System;
using System.Collections.Generic;
using AcciPro.App.Dominio;
using AcciPro.App.Persistencia;

namespace AcciPro.App.Consola
{
    class Program
    {
        private static IRepositorioAgente _repoAgente=new RepositorioAgente(new Persistencia.AppContext());
        private static IRepositorioAccidente _repoAccidente=new RepositorioAccidente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            AddAgenteConAccidente();
            //AddAgente();
           // BuscarAgente(1);
           AddAccidente();
        }

        private static void AddAgente()
        {
            var agente = new Agente 
            {
                
                Nombre="Santiago",
                Apellido="Fernandez",
                Sexo="Masculino",
                edad="29",
                Direccion="Calle 167a N 30g-10",
                Latitud=-73.654490F,
                Longitud=3.09862F,
                Ciudad="Medellin",
                FechaNacimiento=new DateTime(1992,04,12)
            };

            _repoAgente.AddAgente(agente);
         }
    
    private static void AddAgenteConAccidente()
        {
            var agente = new Agente 
            {
                
                Nombre="Santiago",
                Apellido="Fernandez",
                Sexo="Masculino",
                edad="29",
                Direccion="Calle 167a N 30g-10",
                Latitud=-73.654490F,
                Longitud=3.09862F,
                Ciudad="Medellin",
                FechaNacimiento=new DateTime(1990,04,12),
                Accidentes= new List<Accidente>{
                    new Accidente{Id=new Latitud(7.097773),List<Persona>=(Sandra),List<Vehiculo>Vehiculo=(Mazda),
                    Longitud=(4.0865),Direccion=(Calle,127,N,88,90),Fecha=(2021,10,17),Descripcion=(Accidente,leve)}

                }
            };

            _repoAgente.AddAgente(agente);
         }
    
    
        private static void BuscarAgente(int idAgente)
        {
        var agente = _repoAgente.GetAgente(idAgente);
        Console.WriteLine(agente.Nombre+" "+agente.Apellido);
        }

        private static void AsignarAccidente()
        {
        var Accidente=_repoAgente.AsignarAccidente(1, 2);
        Console.WriteLine(agente.Nombre+" "+agente.Apellido);
        }
        
        private static void AddAccidente()
        {
            List<Agente> listaAgente= new List<Agente>{
                new Agente{Nombre="Andres", Apellido="Fernandez", Cedula=109982347, Sexo="Masculino", edad="26"},
                new Agente{Nombre="Camilo", Apellido="Lopez", Cedula=1124838409, Sexo="Masculino", edad="30"},
                new Agente{Nombre="Sandra", Apellido="Perez", Cedula=1209832112, Sexo="Femenino", edad="28"}
            };
            List<Vehiculo> listaVehiculo= new List<Vehiculo>{
                new Vehiculo{Tipo_Propietario="Propio", Matricula="CXU034", Modelo="Clio", Ciudad="Bogota"},
                new Vehiculo{Tipo_Propietario="Propio", Matricula="GSO343", Modelo="Duster", Ciudad="Medellin"},
                new Vehiculo{Tipo_Propietario="Propio", Matricula="NVQ024", Modelo="Mazda 2", Ciudad="Bogota"}
            };

            var nuevoAccidente = new Accidente
            {
                Latitud="65.52290F",
                Longitud="6.07062F",
                Direccion="Transversal 160a N 50g-10",
                //Fecha=1990,04,12,
                Descripcion="Choque Vehiculos"

            };

            _repoAccidente.AddAccidente(nuevoAccidente);

        }

    }

}

    


           