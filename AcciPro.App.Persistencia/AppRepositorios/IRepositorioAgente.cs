using System.Collections.Generic;
using AcciPro.App.Dominio;

namespace AcciPro.App.Persistencia
{
    public interface IRepositorioAgente
    {
        IEnumerable<Agente> GetAllAgentes();
        Agente AddAgente (Agente agente);
        Agente UpdateAgente (Agente agente);
        void DeleteAgente(int idAgente);
        Agente GetAgente(int idAgente);
    }
}