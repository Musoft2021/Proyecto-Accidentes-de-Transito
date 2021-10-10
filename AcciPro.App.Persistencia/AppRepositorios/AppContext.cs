using Microsoft.EntityFrameworkCore;
using AcciPro.App.Dominio;

namespace AcciPro.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Agente> Agentes {get;set;}
        public DbSet<Accidente> Accidentes {get;set;}
        public DbSet<EventoAccidente> EventoAccidentes {get;set;}
        public DbSet<TipoVehiculo> TipoVehiculos {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}
 

                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
          optionsBuilder
          .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AccidentesPro");

          
      }  
        }
        
    }
}