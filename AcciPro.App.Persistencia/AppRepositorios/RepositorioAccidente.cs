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
    var accidenteEncontrado=_appContext.Accidente.Where(p => p.Id==idAccidente)FirstOrDefault();
    if(accidenteEncontrado==null)
        return;
    _appContext.Accidente.Remove(accidenteEncontrado);
    _appContext.SaveChanges(); 
}

IEnumerable<Accidente> IRepositorioAccidente.GetAllAccidentes()
{
    return _appContext.Accidente; 
}

//Accidente IRepositorioAccidente.GetAccidente(int idAccidente)
//{
   //return _appContext.Accidente.FirstOrDefault(p => p.Id==idAgente);
//}

Accidente IRepositorioAccidente.UpdateAccidente(Accidente accidente)
{
    var AccidenteEncontrado=_appContext.Accidente.Where(p => p.Id==accidente.Id)FirstOrDefault();
    if (AccidenteEncontrado!=null)
    {
        accidenteEncontrado.Latitud=accidente.Latitud;
        accidenteEncontrado.Persona=accidente.Persona;
        accidenteEncontrado.Vehiculo=accidente.Vehiculo;
        accidenteEncontrado.Longitud=accidente.Longitud;
        accidenteEncontrado.Direccion=accidente.Direccion;
        accidenteEncontrado.Fecha=accidente.Fecha;
        accidenteEncontrado.Descripcion=accidente.Descripcion;
       
        _appContext.SaveChanges();
        
    }

        return accidenteEncontrado;
}

}
}
