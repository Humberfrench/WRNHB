using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;

namespace Repositorio.DAO
{
    public class ClienteDAOCNPJ : GenericDAO<ClienteCNPJ>, IClienteDAOCNPJ
    {
        public ClienteDAOCNPJ(ISession session) : base(session) { }
    }
}
