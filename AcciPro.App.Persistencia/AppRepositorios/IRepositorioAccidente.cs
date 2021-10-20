using System.Collections.Generic;
using AcciPro.App.Dominio;

namespace AcciPro.App.Persistencia
{
    public interface IRepositorioAccidente
    {

        IEnumerable<Accidente> GetAllAccidentes();
        Accidente AddAccidente (Accidente accidente);
        Accidente UpdateAccidente (Accidente accidente);
        void DeleteAccidente(int idAccidente);
       Accidente GetAccidente(int idAccidente);
        
        //Agente AsignarAccidente(int idAgente, int idAccidente);
    }
}