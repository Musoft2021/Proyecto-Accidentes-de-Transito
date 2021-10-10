using System;
using AcciPro.App.Dominio;
using AcciPro.App.Persistencia;

namespace AcciPro.App.Consola
{
    class Program
    {
        private static IRepositorioAgente _repoAgente=new RepositorioAgente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            AddAgente();
           // BuscarAgente(1);
        }

        private static void AddAgente()
        {
            var agente = new Agente 
            {
                
                Nombre="Nicolay",
                Apellido="Perez",
                Sexo="Masculino",
                edad="26",
                Direccion="Calle 127a N 70g-10",
                Latitud=-75.52290F,
                Longitud=5.07062F,
                Ciudad="Bogota",
                FechaNacimiento=new DateTime(1990,04,12)
            };

            _repoAgente.AddAgente(agente);
         }
    
    
        //private static void BuscarAgente(int idAgente)
        //{
        //var agente = _repoAgente.GetAgente(idAgente);
        //Console.WriteLine(agente.Nombre+" "+agente.Apellido);
        //}

    }

}

    


           