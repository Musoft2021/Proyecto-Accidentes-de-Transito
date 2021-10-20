using Microsoft.EntityFrameworkCore;
using AcciPro.App.Dominio;

namespace AcciPro.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Agente> Agentes {get;set;}
        public DbSet<Accidente> Accidente {get;set;}
        public DbSet<EventoAccidente> EventoAccidentes {get;set;}
        public DbSet<TipoVehiculo> TipoVehiculos {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}
 

                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
          optionsBuilder
          .UseSqlServer("Server=tcp:misionticmusoft2022.database.windows.net,1433;Initial Catalog=HolaWeb.App.Frontend;Persist Security Info=False;User ID=Admin_01;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

          
      }  
        }
        
    }
}