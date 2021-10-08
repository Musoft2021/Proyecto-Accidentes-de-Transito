using System.Collections.Generic;
using System.Linq;
using AcciPro.App.Dominio;


namespace AcciPro.App.Persistencia
{
public class RepositorioAgente : IRepositorioAgente
{
    private readonly AppContext _appContext;

public RepositorioAgente(AppContext AppContext)
{
    _appContext=AppContext;
}

    Agente IRepositorioAgente.AddAgente(Agente agente)
    {
        var agenteAdicionado=_appContext.Agentes.Add(agente);
        _appContext.SaveChanges();
        return agenteAdicionado.Entity;
    }

void IRepositorioAgente.DeleteAgente(int idAgente)
{
    var agenteEncontrado=_appContext.Agentes.FirstOrDefault(p => p.Id==idAgente);
    if(agenteEncontrado==null)
        return;
    _appContext.Agentes.Remove(agenteEncontrado);
    _appContext.SaveChanges(); 
}

IEnumerable<Agente> IRepositorioAgente.GetAllAgentes()
{
    return _appContext.Agentes; 
}

Agente IRepositorioAgente.GetAgente(int idAgente)
{
   return _appContext.Agentes.FirstOrDefault(p => p.Id==idAgente);
}

Agente IRepositorioAgente.UpdateAgente(Agente agente)
{
    var agenteEncontrado=_appContext.Agentes.FirstOrDefault(p => p.Id==agente.Id);
    if (agenteEncontrado!=null)
    {
        agenteEncontrado.Nombre=agente.Nombre;
        agenteEncontrado.Apellido=agente.Apellido;
        agenteEncontrado.Cedula=agente.Cedula;
        agenteEncontrado.Sexo=agente.Sexo;
        agenteEncontrado.edad=agente.edad;
        agenteEncontrado.Direccion=agente.Direccion;
        agenteEncontrado.Latitud=agente.Latitud;
        agenteEncontrado.Longitud=agente.Longitud;
        agenteEncontrado.Ciudad=agente.Ciudad;
        agenteEncontrado.FechaNacimiento=agente.FechaNacimiento;

        _appContext.SaveChanges();
        
    }

        return agenteEncontrado;
}

}
}
