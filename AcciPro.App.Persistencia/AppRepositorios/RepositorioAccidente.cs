using System.Collections.Generic;
using System.Linq;
using AcciPro.App.Dominio;

namespace AcciPro.App.Persistencia

{
public class RepositorioAccidente : IRepositorioAccidente
{
    private readonly AppContext _appContext;

public RepositorioAccidente(AppContext AppContext)
{
    _appContext=AppContext;
}

    Accidente IRepositorioAccidente.AddAccidente(Accidente accidente)
    {
        var accidenteAdicionado=_appContext.Accidente.Add(accidente);
        _appContext.SaveChanges();
        return accidenteAdicionado.Entity;
    }

void IRepositorioAccidente.DeleteAccidente(int idAccidente)
{
    var accidenteEncontrado=_appContext.Accidente.FirstOrDefault(p => p.Id==idAccidente);
    if(accidenteEncontrado==null)
        return;
    _appContext.Accidente.Remove(accidenteEncontrado);
    _appContext.SaveChanges(); 
}

IEnumerable<Accidente> IRepositorioAccidente.GetAllAccidentes()
{
    return _appContext.Accidente; 
}

Accidente IRepositorioAccidente.GetAccidente(int idAccidente)
{
   return _appContext.Accidente.FirstOrDefault(p => p.Id==idAccidente);
}

Accidente IRepositorioAccidente.UpdateAccidente(Accidente accidente)
{
    var AccidenteEncontrado=_appContext.Accidente.FirstOrDefault(p => p.Id==accidente.Id);
    if (AccidenteEncontrado!=null)
    {
        AccidenteEncontrado.Latitud=accidente.Latitud;
        AccidenteEncontrado.Persona=accidente.Persona;
        AccidenteEncontrado.Vehiculo=accidente.Vehiculo;
        AccidenteEncontrado.Longitud=accidente.Longitud;
        AccidenteEncontrado.Direccion=accidente.Direccion;
        AccidenteEncontrado.Fecha=accidente.Fecha;
        AccidenteEncontrado.Descripcion=accidente.Descripcion;
       
        _appContext.SaveChanges();
        
    }

        return AccidenteEncontrado;
}

public Agente AsignarAccidente(int IdAgente, int IdAccidente)
{
    var AccidenteEncontrado=_appContext.Accidente.firstOrDefault(a => a.Id ==IdAccidente);
    if(AccidenteEncontrado !=null)

    {
       var AgenteEncontrado= _appContext.Agente.firstOrDefault(t => t.Id ==IdAgente);
    }
}

}
}
