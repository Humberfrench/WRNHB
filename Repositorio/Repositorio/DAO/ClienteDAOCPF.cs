using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.Entidades;

namespace Repositorio.DAO.Interface
{
    public class ClienteDAOCPF : GenericDAO<ClienteCPF>, IClienteDAOCPF
    {
        public ClienteDAOCPF(ISession session) : base(session) { }
    }
}
